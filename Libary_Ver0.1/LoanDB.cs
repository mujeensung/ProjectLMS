using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;

namespace Libary_Ver0._1
{
    class LoadDB : DBManager, IDBManager
	{
        private int iLoadCode;
        private int iBookCode;
        private int iStudentCode;
        private int iDate;
        public ArrayList Load = new ArrayList();
        public int key;
        public int primarykey()
        {
            return key;
        }
        public void insert()
        {
        }
        public ArrayList getList()
        {
            return Load;
        }
        public ArrayList Select_Reader(eItem item, string str)
        {
            return Load;
        }
        public DataSet GetData(eItem item, string str)
        {
            DataSet db = new DataSet();
            return db;
        }
	}
}
