using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace EVE_SSS
{
    public class DataManager
    {
        public static SQLiteConnection con;

        public static void Init()
        {
            string cs = @"URI=file:.\..\db.db";
            con = new SQLiteConnection(cs);
            con.Open();
        }
    }
}
