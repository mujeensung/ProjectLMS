using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace Libary_Ver0._1
{
    class StudentDB : DBManager, IDBManager
	{
        public int istudentNum;
        public string iname;
        public string iphone;
        public int key;
        public ArrayList Student;

        public int primarykey()
        {
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Student_Info";
                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    key = Convert.ToInt32(rdr["studentNum"]);
                }
                key++;
                rdr.Close();
            }
            return key;
        }

        public void insert()
        {
            DBOpen();
            cmd = new SQLiteCommand(conn);
            cmd.CommandText = "INSERT INTO Student VALUES(" + istudentNum + ",\"" +
                                                                iname + "\",\"" +
                                                                iphone + "\")";
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public ArrayList Select_Reader(eItem item, string str)
        {
            stStudent StudentData = new stStudent(0, "", "");
            Student = new ArrayList();
            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Student WHERE studentNum =\"" + str + "\"";

                SQLiteCommand cmd = new SQLiteCommand(sql, conn);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    StudentData.studentNum =Convert.ToInt32(rdr["studentNum"]);
                    StudentData.name = rdr["name"].ToString();
                    StudentData.phone = rdr["phone"].ToString();
                    Student.Add(Student);
                }
                rdr.Close();
            }
            return Student;
        }
       
        public ArrayList getList()
        {
            return Student;
        }

        public DataSet GetData(int item, string str)
        {
            stStudent StudentData = new stStudent(0, "", "");
            Student = new ArrayList();
            DataSet ds = new DataSet();

            using (var conn = new SQLiteConnection(connStr))
            {
                conn.Open();
                string sql = "SELECT * FROM Student WHERE StudentNum =\"" + item + "\"";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, conn);
                adapter.Fill(ds);
            }
            return ds;
        }
	}
}
