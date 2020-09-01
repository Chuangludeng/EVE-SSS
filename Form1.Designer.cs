namespace EVE_SSS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemNameInput = new System.Windows.Forms.TextBox();
            this.ResultList = new System.Windows.Forms.ListView();
            this.ItemIcon = new System.Windows.Forms.PictureBox();
            this.ItemName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SellPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InventoryCost = new System.Windows.Forms.Label();
            this.EnterInventory = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(828, 484);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EnterInventory);
            this.tabPage1.Controls.Add(this.InventoryCost);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SellPrice);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ItemName);
            this.tabPage1.Controls.Add(this.ItemIcon);
            this.tabPage1.Controls.Add(this.ResultList);
            this.tabPage1.Controls.Add(this.ItemNameInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(820, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入库";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(820, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "生产";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(820, 458);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "出库";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "物品";
            // 
            // ItemNameInput
            // 
            this.ItemNameInput.Location = new System.Drawing.Point(55, 18);
            this.ItemNameInput.Name = "ItemNameInput";
            this.ItemNameInput.Size = new System.Drawing.Size(174, 20);
            this.ItemNameInput.TabIndex = 1;
            // 
            // ResultList
            // 
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(21, 55);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(208, 245);
            this.ResultList.TabIndex = 2;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            // 
            // ItemIcon
            // 
            this.ItemIcon.Location = new System.Drawing.Point(256, 18);
            this.ItemIcon.Name = "ItemIcon";
            this.ItemIcon.Size = new System.Drawing.Size(64, 64);
            this.ItemIcon.TabIndex = 3;
            this.ItemIcon.TabStop = false;
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(326, 39);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(70, 25);
            this.ItemName.TabIndex = 4;
            this.ItemName.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "市场价";
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSize = true;
            this.SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.SellPrice.Location = new System.Drawing.Point(319, 110);
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Size = new System.Drawing.Size(108, 20);
            this.SellPrice.TabIndex = 6;
            this.SellPrice.Text = "00000000000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(462, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(518, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "00000000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(256, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "入库价";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(323, 220);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "数量";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(323, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(256, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "库存平均成本";
            // 
            // InventoryCost
            // 
            this.InventoryCost.AutoSize = true;
            this.InventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryCost.ForeColor = System.Drawing.Color.ForestGreen;
            this.InventoryCost.Location = new System.Drawing.Point(367, 163);
            this.InventoryCost.Name = "InventoryCost";
            this.InventoryCost.Size = new System.Drawing.Size(108, 20);
            this.InventoryCost.TabIndex = 14;
            this.InventoryCost.Text = "00000000000";
            // 
            // EnterInventory
            // 
            this.EnterInventory.Location = new System.Drawing.Point(523, 221);
            this.EnterInventory.Name = "EnterInventory";
            this.EnterInventory.Size = new System.Drawing.Size(102, 68);
            this.EnterInventory.TabIndex = 15;
            this.EnterInventory.Text = "入库";
            this.EnterInventory.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(820, 458);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EVE-SSS";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SellPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ItemName;
        private System.Windows.Forms.PictureBox ItemIcon;
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.TextBox ItemNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button EnterInventory;
        private System.Windows.Forms.Label InventoryCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

