using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVE_SSS
{
    public partial class MainForm : Form
    {
        public EVEItem EnterInventory_Item = new EVEItem();
        public EVEItem Production_Item = new EVEItem();

        public List<EVEItem> Production_Materials_EVEList;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataManager.Init();

            SearchBox_Enter.SearchBoxInit();
            SearchBox_Enter.onSelectedItem += onSearchBox_Enter_ItemSelected;

            SearchBox_Production.additionalConditions = "EXISTS(SELECT 1 FROM blueprint WHERE id = type_i18n.typeid)";
            SearchBox_Production.SearchBoxInit();
            SearchBox_Production.onSelectedItem += onSearchBox_Production_ItemSelected;
        }

        private void onSearchBox_Enter_ItemSelected(int typeID,string name)
        {
            EnterInventory_Item.typeID = typeID;
            if (DataManager.QueryInventory(EnterInventory_Item) != null)
                updateInventoryItem(EnterInventory_Item);
            ItemName.Text = name;
        }

        private void updateInventoryItem(EVEItem item)
        {
            item = DataManager.QueryInventory(item);
            InventoryCost.Text = item.price.ToString("###,###");
            InventoryNumber.Text = item.number.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int mL = textBox1.SelectionStart;
            string oldStr = textBox1.Text;
            if (oldStr == null || oldStr.Length == 0)
                return;
            double text = double.Parse(textBox1.Text);
            string newStr = String.Format("{0:N0}", text);
            textBox1.Text = newStr;
            textBox1.SelectionStart = mL + newStr.Length - oldStr.Length;
        }

        private void EnterInventory_Click(object sender, EventArgs e)
        {
            if (EnterInventory_Item.typeID != 0)
            {
                DataManager.EnterInventory(EnterInventory_Item.typeID, int.Parse(textBox2.Text), (int)double.Parse(textBox1.Text), ItemName.Text);
                updateInventoryItem(EnterInventory_Item);
            }
        }

        private void onSearchBox_Production_ItemSelected(int typeID, string name)
        {
            Production_Item.typeID = typeID;
            Production_BlueprintName.Text = name;
            createBlueprintInfo();
        }

        private void createBlueprintInfo()
        {
            Production_Materials_EVEList = DataManager.QueryBlueprintMaterials(Production_Item.typeID);

            Production_Materials_List.BeginUpdate();
            Production_Materials_List.Items.Clear();

            foreach (var item in Production_Materials_EVEList)
            {
                var listViewItem = new ListViewItem();

                listViewItem.Text = item.name;
                listViewItem.SubItems.Add(item.number.ToString());
                listViewItem.SubItems.Add(item.price.ToString());

                OverviewList.Items.Add(listViewItem);
            }

            Production_Materials_List.EndUpdate();

            updateBlueprintInfo();
        }

        private void updateBlueprintInfo()
        {

        }

        private void OverviewRefresh_Click(object sender, EventArgs e)
        {
            var list = DataManager.QueryAllInventory();

            OverviewList.BeginUpdate();

            OverviewList.Items.Clear();

            foreach (var item in list)
            {
                var listViewItem = new ListViewItem();

                listViewItem.Text = item.name;
                listViewItem.SubItems.Add(item.number.ToString());
                listViewItem.SubItems.Add(item.price.ToString());

                OverviewList.Items.Add(listViewItem);
            }

            OverviewList.EndUpdate();
        }

    }
}
