using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace Libary_Ver0._1
{
    class StudentDB : DBManager, IDBManager
	{
        public void insert()
        {
            DBOpen();
            cmd = new SQLiteCommand(conn);
            //cmd.CommandText = "INSERT INTO \"main\".\"member\" (\"id\",\"name\",\"bookListone\",\"booklisttwo\",\"booklistthree\",\"booklist\") VALUES ("
            //    + d.id + ",\""
            //    + d.name + "\"," + d.booklistone + ","
            //    + d.booklisttwo + ","
            //    + d.booklistthree + ","
            //    + d.booklist + ")";

            cmd.ExecuteNonQuery();
            conn.Close();
        }
	}
}
