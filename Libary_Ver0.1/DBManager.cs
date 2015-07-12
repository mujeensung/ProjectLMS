using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace Libary_Ver0._1
{
    struct stBookData
    {
        public int bookcode;
        public string title;
        public string author;
        public stBookData(int bookcode, string title, string author)
        {
            this.bookcode = bookcode;
            this.title = title;
            this.author = author;
        }
    }

    struct data
    {
        public int id;
        public string name;
        public int booklistone;
        public int booklisttwo;
        public int booklistthree;
        public int booklist;
        public data( int id, string name,int booklistone, int booklisttwo, int booklistthree, int booklist)
        {
            this.id = id;
            this.name = name;
            this.booklistone = booklistone;
            this.booklisttwo = booklisttwo;
            this.booklistthree = booklistthree;
            this.booklist = booklist;
        }
    }

    enum eItem
    {
        TITLE, AUTHOR 
    }

    class DBManager
    {
        private string connStr = @"Data Source=c:\db\mydb.db";
        private SQLiteConnection conn;
        private SQLiteCommand cmd;
        public ArrayList bookList;
        public ArrayList memberList;
        
        public void DBOpen()
        {
            conn = new SQLiteConnection(connStr);
            conn.Open();
        }

        public void insert(stBookData d)
        {
            conn = new SQLiteConnection(connStr);
            conn.Open();
            cmd = new SQLiteCommand(conn);
            cmd.CommandText = "INSERT INTO Book_Info VALUES(" + d.bookcode + ",\"" +
                                                                d.title + "\",\"" +
                                                                d.author + "\")";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void _insert(data d)
        {
            conn = new SQLiteConnection(connStr);
            conn.Open();
            cmd = new SQLiteCommand(conn);
            cmd.CommandText = "INSERT INTO \"main\".\"member\" (\"id\",\"name\",\"bookListone\",\"booklisttwo\",\"booklistthree\",\"booklist\") VALUES ("
                +d.id+",\""
                +d.name+"\","+d.booklistone+","
                +d.booklisttwo+","
                +d.booklistthree+","
                +d.booklist+")";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public ArrayList Select_Reader(eItem item, string str)
        {
            data Data = new data(0,"",0,0,0,0);
            memberList = new ArrayList();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM member WHERE " + item.ToString() +"=\"" + str + "\"";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Data.id = Convert.ToInt32(rdr["id"]);
                    Data.name  = rdr["name"].ToString();
                    memberList.Add(Data);
                }
                rdr.Close();
            }
            return memberList;
        }
        public ArrayList _Select_Reader(eItem item, string str)
        {
            stBookData bookData = new stBookData(0, "", "");
            bookList = new ArrayList();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Book_Info WHERE " + item.ToString() + "=\"" + str + "\"";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    bookData.author = rdr["author"].ToString();
                    bookData.title = rdr["title"].ToString();
                    bookList.Add(bookData);
                }
                rdr.Close();
            }
            return bookList;
        }
        public ArrayList getBookList()
        {
            return bookList;
        }
        public ArrayList getmemberList()
        {
            return memberList;
        }
        public DataSet GetData(eItem item, string str)
        {
            stBookData bookData = new stBookData(0, "", "");
            bookList = new ArrayList();
            DataSet ds = new DataSet();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Book_Info WHERE " + item.ToString() + "=\"" + str + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            return ds;
        }
        public DataSet GetmemberData(string str,string strr)
        {
            data Data = new data(0, "",0,0,0,0);
            bookList = new ArrayList();
            DataSet ds = new DataSet();
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM member WHERE id =" + str +" and name =\""+strr+"\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            return ds;
        }
    }
}