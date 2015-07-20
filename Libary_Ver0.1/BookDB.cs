using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Libary_Ver0._1
{
    class BookDB : DBManager, IDBManager
	{
        private int iBookCode;
        private string strTitle;
        private string strAuthor;
//hello

        public void insert()
        {
            DBOpen();
            cmd = new SQLiteCommand(conn);
            //cmd.CommandText = "INSERT INTO Book_Info VALUES(" + d.bookcode + ",\"" +
            //                                                    d.title + "\",\"" +
            //                                                    d.author + "\")";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
	}
}
