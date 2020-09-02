using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace EVE_SSS
{
    public partial class SearchBox : UserControl
    {
        private SQLiteCommand itemSearchSQLcmd;
        private const string itemSearchSQL = "SELECT typeid,value FROM type_i18n WHERE key = 'name' AND language = 'zh' AND value LIKE @name || '%' LIMIT 50";

        public SearchBox()
        {
            InitializeComponent();
        }

        public void SearchBoxInit()
        {
            itemSearchSQLcmd = DataManager.con.CreateCommand();
            itemSearchSQLcmd.CommandText = itemSearchSQL;
            itemSearchSQLcmd.Parameters.AddWithValue("@name", "");
        }

        private void ItemNameInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control || e.KeyCode == Keys.Enter)
            {
                if (ItemNameInput.Text != "")
                {
                    itemSearchSQLcmd.Parameters["@name"].Value = ItemNameInput.Text;
                    itemSearchSQLcmd.Prepare();

                    SQLiteDataReader rdr = itemSearchSQLcmd.ExecuteReader();

                    ResultList.BeginUpdate();

                    ResultList.Items.Clear();
                    while (rdr.Read())
                    {
                        var item = new ListViewItem();

                        item.Text = rdr.GetString(1);

                        ResultList.Items.Add(item);
                    }

                    ResultList.EndUpdate();

                    ResultList.Columns[0].Width = ResultList.ClientSize.Width;

                    rdr.Close();
                }
            }
        }
    }
}
