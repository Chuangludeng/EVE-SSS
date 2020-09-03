﻿using System;
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

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataManager.Init();

            SearchBox_Enter.SearchBoxInit();
            SearchBox_Enter.onSelectedItem += onSearchBox_Enter_ItemSelected;
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
                DataManager.EnterInventory(EnterInventory_Item.typeID, int.Parse(textBox2.Text), (int)double.Parse(textBox1.Text));
                updateInventoryItem(EnterInventory_Item);
            }
        }
    }
}
