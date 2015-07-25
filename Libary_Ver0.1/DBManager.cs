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
    struct stStudent
    {
        public int studentNum;
        public string name;
        public string phone;
        public stStudent(int studentNum, string name, string phone)
        {
            this.studentNum = studentNum;
            this.name = name;
            this.phone = phone;
        }
    }
    public enum eItem
    {
        TITLE, AUTHOR 
    }
    public class DBManager 
    {
        protected string connStr = @"Data Source=c:\db\mydb.db";
        protected SQLiteConnection conn;
        protected SQLiteCommand cmd;
        protected SQLiteCommand bookmanager;
        public ArrayList bookList;
        public ArrayList memberList;
        public void DBOpen()
        {
            conn = new SQLiteConnection(connStr);
            conn.Open();
        }
    }
}