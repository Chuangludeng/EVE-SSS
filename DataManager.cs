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
        public static SQLiteConnection con_store;

        public static void Init()
        {
            string cs = @"URI=file:.\..\db.db";
            con = new SQLiteConnection(cs);
            con.Open();

            string cs2 = @"URI=file:.\..\store.db";
            con_store = new SQLiteConnection(cs2);
            con_store.Open();
        }

        public static void EnterInventory(int type,int number,int price,string name)
        {
            var cmd = con_store.CreateCommand();
            cmd.CommandText = "SELECT * FROM store WHERE id = @type";
            cmd.Parameters.AddWithValue("@type", type);
            var reader = cmd.ExecuteReader();

            if(reader.HasRows)
            {
                reader.Read();
                var oldNumber = reader.GetInt32(1);
                var oldPrice = reader.GetInt32(2);
                reader.Close();

                var newNumber = oldNumber + number;
                var newPrice = (oldNumber * oldPrice + number * price) / newNumber;

                cmd.CommandText = "UPDATE store SET number = @number, price = @price WHERE id = @type";
                cmd.Parameters.AddWithValue("@number", newNumber);
                cmd.Parameters.AddWithValue("@price", newPrice);

                cmd.ExecuteNonQuery();
            }
            else
            {
                reader.Close();
                cmd.CommandText = "INSERT INTO store VALUES(@type,@number,@price,@name)";
                cmd.Parameters.AddWithValue("@number", number);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@name", name);

                cmd.ExecuteNonQuery();
            }
        }

        public static EVEItem QueryInventory(EVEItem item)
        {
            var cmd = con_store.CreateCommand();
            cmd.CommandText = "SELECT * FROM store WHERE id = @type";
            cmd.Parameters.AddWithValue("@type", item.typeID);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                var number = reader.GetInt32(1);
                var price = reader.GetInt32(2);

                item.number = number;
                item.price = price;
                reader.Close();

                return item;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public static List<EVEItem> QueryAllInventory()
        {
            var cmd = con_store.CreateCommand();
            cmd.CommandText = "SELECT * FROM store";
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                List<EVEItem> itemList = new List<EVEItem>();

                while(reader.Read())
                {
                    var item = new EVEItem();
                    item.typeID = reader.GetInt32(0);
                    item.number = reader.GetInt32(1);
                    item.price = reader.GetInt32(2);
                    item.name = reader.GetString(3);
                    itemList.Add(item);
                }

                reader.Close();
                return itemList;
            }
            else
            {
                reader.Close();
                return null;
            }
        }

        public static string QueryName(int type)
        {
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT value FROM type_i18n WHERE typeId = @type and key = 'name'";
            cmd.Parameters.AddWithValue("@type", type);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();

                var ret = reader.GetString(0);
                reader.Close();

                return ret;
            }
            else
            {
                reader.Close();
                return "";
            }
        }

        public static List<EVEItem> QueryBlueprintProductionMaterials(int typeID)
        {
            var cmd = con.CreateCommand();
            cmd.CommandText = "SELECT typeID,quantity FROM blueprint_material WHERE id = @type AND activityType = 2";
            cmd.Parameters.AddWithValue("@type", typeID);
            var reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                List<EVEItem> itemList = new List<EVEItem>();

                while (reader.Read())
                {
                    var item = new EVEItem();
                    item.typeID = reader.GetInt32(0);
                    item.request_quantity = reader.GetInt32(1);
                    item.name = QueryName(item.typeID);
                    QueryInventory(item);
                    itemList.Add(item);
                }

                reader.Close();
                return itemList;
            }
            else
            {
                reader.Close();
                return null;
            }
        }
    }
}
