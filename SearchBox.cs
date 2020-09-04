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
        private const string itemSearchSQL = "SELECT type_i18n.value,type.* FROM type_i18n INNER JOIN type on type_i18n.typeid = type.id WHERE {0} AND type_i18n.key = 'name' AND type_i18n.language = 'zh' AND type_i18n.value LIKE @name || '%' LIMIT 50";

        public delegate void OnSelectedItem_Handle(int typeID,string name);

        public event OnSelectedItem_Handle onSelectedItem;

        public string additionalConditions = "TRUE";

        public SearchBox()
        {
            InitializeComponent();
        }

        public void SearchBoxInit()
        {
            itemSearchSQLcmd = DataManager.con.CreateCommand();
            itemSearchSQLcmd.CommandText = string.Format(itemSearchSQL, additionalConditions);
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

                        item.Text = rdr.GetString(0);
                        item.SubItems.Add(rdr.GetInt32(1).ToString());

                        ResultList.Items.Add(item);
                    }

                    ResultList.EndUpdate();

                    ResultList.Columns[0].Width = ResultList.ClientSize.Width;

                    rdr.Close();
                }
            }
        }

        private void ResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ResultList.SelectedItems.Count != 0)
            {
                onSelectedItem(int.Parse(ResultList.SelectedItems[0].SubItems[1].Text), ResultList.SelectedItems[0].Text);
            }
        }

        private void ItemNameInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
