using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Collections;
namespace Libary_Ver0._1
{
	interface IDBManager
	{
        void insert();
        ArrayList getList();
        ArrayList Select_Reader(eItem item, string str);
        int primarykey();
	}
}
