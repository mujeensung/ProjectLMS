using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace Libary_Ver0._1
{
    class BookDB : DBManager, IDBManager
	{
        public int iBookCode;
        public string strTitle;
        public string strAuthor;
        public int key;
        public int primarykey()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Book";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    key = Convert.ToInt32(rdr["bookcode"]);
                }
                key++;
                rdr.Close();
            }
            return key;
        }
        public ArrayList getList()
        {
            return bookList;
        }
        public ArrayList Select_Reader(eItem item, string str)
        {
            stBookData bookData = new stBookData(0, "", "");
            bookList = new ArrayList();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Book WHERE " + item.ToString() + "=" + str + "";

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

        public DataSet GetData(eItem item, string str)
        {
            stBookData bookData = new stBookData(0, "", "");
            bookList = new ArrayList();
            DataSet ds = new DataSet();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Book WHERE " + item.ToString() + "='" + str + "'";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            return ds;
        }

        public void insert()
        {
            DBOpen();
            cmd = new SQLiteCommand(conn);
            cmd.CommandText = "INSERT INTO Book VALUES(" + iBookCode + ",\"" +
                                                                strTitle + "\",\"" +
                                                                strAuthor + "\")";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void bookmanagement()
        {
            DBOpen();
            bookmanager = new SQLiteCommand(conn);
            string sql = "SELECT * FROM Book WHERE";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                cmd.CommandText = "INSERT INTO BookManagement VALUES(\"" + Convert.ToInt32(rdr["bookcode"]) + "\",\"0\")";

            }
            rdr.Close();
            

        }
	}
}
