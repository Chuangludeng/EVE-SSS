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
        public Blueprint Production_Blueprint;

        ORECalculate ore_calculate = new ORECalculate(false);

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

            textBox4.Text = typeID.ToString();

            var priceS = PriceService.GetPrice(typeID);
            float sell = priceS.sell.min;
            float buy = priceS.buy.max;

            SellPrice.Text = sell.ToString("###,###");
            BuyPrice.Text = buy.ToString("###,###");
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

        private void EnterInventory_Discount_Click(object sender, EventArgs e)
        {
            if (EnterInventory_Item.typeID != 0)
            {
                DataManager.EnterInventory(EnterInventory_Item.typeID, int.Parse(textBox2.Text), (int)(double.Parse(SellPrice.Text) * double.Parse(Price_Discount.Text)), ItemName.Text);
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
            Production_Blueprint = DataManager.QueryBlueprintProduction(Production_Item.typeID);
            Production_Materials_EVEList = DataManager.QueryBlueprintProductionMaterials(Production_Item.typeID);

            Production_Materials_List.BeginUpdate();
            Production_Materials_List.Items.Clear();

            foreach (var item in Production_Materials_EVEList)
            {
                var listViewItem = new ListViewItem();

                listViewItem.Text = item.name;
                listViewItem.Tag = item.typeID;
                listViewItem.SubItems.Add(item.request_quantity.ToString());
                listViewItem.SubItems.Add(item.number.ToString());
                listViewItem.SubItems.Add(item.price.ToString());
                listViewItem.SubItems.Add("");

                Production_Materials_List.Items.Add(listViewItem);
            }

            Production_Materials_List.EndUpdate();

            updateBlueprintInfo();
        }

        private void updateBlueprintInfo()
        {
            Production_Materials_List.BeginUpdate();

            int index = 0;
            int outNumber = 0;
            int production_Number = 1;

            int save = 0;

            float cost = 0;

            bool canProduction = true;

            if (int.TryParse(Production_Number.Text, out outNumber))
            {
                if (outNumber == 0)
                    outNumber = 1;
                production_Number = outNumber;
            }

            if (int.TryParse(Production_BlueprintSave.Text, out outNumber))
            {
                save += outNumber;
            }

            if (int.TryParse(Production_BuildingsSave.Text, out outNumber))
            {
                save += outNumber;
            }

            if (int.TryParse(Production_BlueprintCost.Text, out outNumber))
            {
                cost += outNumber;
            }

            if (int.TryParse(Production_InventCost.Text, out outNumber))
            {
                cost += outNumber;
            }

            if (int.TryParse(Production_BuildingsCost.Text, out outNumber))
            {
                cost += outNumber;
            }

            cost = cost / production_Number;

            foreach (ListViewItem item in Production_Materials_List.Items )
            {
                EVEItem eveItem = Production_Materials_EVEList[index];
                DataManager.QueryInventory(eveItem);

                int number = (int) Math.Round(eveItem.request_quantity * ((100 - save)*0.01f));

                float market_price = PriceService.GetPrice(eveItem.typeID).sell.min;

                item.SubItems[1].Text = (number * production_Number).ToString();
                item.SubItems[2].Text = (eveItem.number).ToString();
                if (number * production_Number > eveItem.number)
                {
                    item.ForeColor = Color.Red;
                    canProduction = false;
                }
                else
                    item.ForeColor = Color.Black;
                item.SubItems[3].Text = (eveItem.price).ToString();
                item.SubItems[4].Text = (market_price).ToString();

                if (eveItem.number > 0)
                    cost += number * eveItem.price;
                else
                    cost += number * market_price;

                index++;
            }

            Production_Materials_List.EndUpdate();
            var priceS = PriceService.GetPrice(Production_Blueprint.targetID);
            float sell = priceS.sell.min;
            float buy = priceS.buy.max;

            Production_SingleCost.Text = cost.ToString("###,###");
            Production_Cost.Text = (cost * production_Number).ToString("###,###");
            Production_Sell.Text = sell.ToString("###,###");
            Production_Buy.Text = buy.ToString("###,###");
            Production_SingleProfit.Text = (sell - cost).ToString("###,###");
            Production_Profit.Text = ((sell - cost) * production_Number).ToString("###,###");

            Production.Enabled = canProduction;
        }
        private void Production_Number_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if(Production_Materials_EVEList != null && int.TryParse(Production_Number.Text,out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_BuildingsSave_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if (Production_Materials_EVEList != null && int.TryParse(Production_BuildingsSave.Text, out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_BlueprintSave_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if (Production_Materials_EVEList != null && int.TryParse(Production_BlueprintSave.Text, out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_BlueprintCost_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if (Production_Materials_EVEList != null && int.TryParse(Production_BlueprintCost.Text, out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_InventCost_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if (Production_Materials_EVEList != null && int.TryParse(Production_InventCost.Text, out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_BuildingsCost_TextChanged(object sender, EventArgs e)
        {
            int outNumber = 0;
            if (Production_Materials_EVEList != null && int.TryParse(Production_BuildingsCost.Text, out outNumber))
            {
                updateBlueprintInfo();
            }
        }

        private void Production_Materials_List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[0];
            if (Production_Materials_List.SelectedItems.Count != 0)
            {
                int typeID = (int)Production_Materials_List.SelectedItems[0].Tag;
                textBox2.Text = Production_Materials_List.SelectedItems[0].SubItems[1].Text;
                onSearchBox_Enter_ItemSelected(typeID, Production_Materials_List.SelectedItems[0].Text);
            }
        }

        private void Production_Click(object sender, EventArgs e)
        {
            Production_Materials_List.BeginUpdate();

            int index = 0;

            foreach (ListViewItem item in Production_Materials_List.Items)
            {
                EVEItem eveItem = Production_Materials_EVEList[index];
                DataManager.QueryInventory(eveItem);

                eveItem.number = eveItem.number - int.Parse(item.SubItems[1].Text);

                DataManager.UpdateInventoryNumber(eveItem);

                index++;
            }

            Production_Materials_List.EndUpdate();

            DataManager.EnterInventory(Production_Blueprint.targetID, int.Parse(Production_Number.Text), int.Parse(Production_SingleCost.Text.Replace(",","")), Production_Blueprint.targetName);

            updateBlueprintInfo();
        }

        private void Production_Refresh_Click(object sender, EventArgs e)
        {
            updateBlueprintInfo();
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
                listViewItem.SubItems.Add(item.number.ToString("###,###"));
                listViewItem.SubItems.Add(item.price.ToString("###,###"));

                OverviewList.Items.Add(listViewItem);
            }

            OverviewList.EndUpdate();
        }

        private void calculateMineral_Click(object sender, EventArgs e)
        {
            ore_calculate.UpdateOREPrice(buyPriceButton.Checked);
            ore_calculate.SetOREData(float.Parse(ratio_input.Text));
            optimize_output.Text = ore_calculate.Calculate(
                int.Parse(a_input.Text),
                int.Parse(b_input.Text),
                int.Parse(c_input.Text),
                int.Parse(d_input.Text),
                int.Parse(e_input.Text),
                int.Parse(f_input.Text),
                int.Parse(g_input.Text),
                int.Parse(h_input.Text));
        }

        private void Production_Materials_List_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
