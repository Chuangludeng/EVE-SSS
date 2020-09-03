namespace EVE_SSS
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InventoryNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SellPrice = new System.Windows.Forms.Label();
            this.EnterInventory = new System.Windows.Forms.Button();
            this.ItemIcon = new System.Windows.Forms.PictureBox();
            this.InventoryCost = new System.Windows.Forms.Label();
            this.ItemName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.SearchBox_Enter = new EVE_SSS.SearchBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(878, 559);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SearchBox_Enter);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(870, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "入库";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.InventoryNumber);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.SellPrice);
            this.groupBox1.Controls.Add(this.EnterInventory);
            this.groupBox1.Controls.Add(this.ItemIcon);
            this.groupBox1.Controls.Add(this.InventoryCost);
            this.groupBox1.Controls.Add(this.ItemName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(344, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 507);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "明细";
            // 
            // InventoryNumber
            // 
            this.InventoryNumber.AutoSize = true;
            this.InventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryNumber.ForeColor = System.Drawing.Color.ForestGreen;
            this.InventoryNumber.Location = new System.Drawing.Point(343, 181);
            this.InventoryNumber.Name = "InventoryNumber";
            this.InventoryNumber.Size = new System.Drawing.Size(108, 20);
            this.InventoryNumber.TabIndex = 17;
            this.InventoryNumber.Text = "00000000000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "库存数量";
            // 
            // SellPrice
            // 
            this.SellPrice.AutoSize = true;
            this.SellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellPrice.ForeColor = System.Drawing.Color.ForestGreen;
            this.SellPrice.Location = new System.Drawing.Point(90, 128);
            this.SellPrice.Name = "SellPrice";
            this.SellPrice.Size = new System.Drawing.Size(108, 20);
            this.SellPrice.TabIndex = 6;
            this.SellPrice.Text = "00000000000";
            // 
            // EnterInventory
            // 
            this.EnterInventory.Location = new System.Drawing.Point(294, 239);
            this.EnterInventory.Name = "EnterInventory";
            this.EnterInventory.Size = new System.Drawing.Size(102, 68);
            this.EnterInventory.TabIndex = 15;
            this.EnterInventory.Text = "入库";
            this.EnterInventory.UseVisualStyleBackColor = true;
            this.EnterInventory.Click += new System.EventHandler(this.EnterInventory_Click);
            // 
            // ItemIcon
            // 
            this.ItemIcon.Location = new System.Drawing.Point(27, 36);
            this.ItemIcon.Name = "ItemIcon";
            this.ItemIcon.Size = new System.Drawing.Size(64, 64);
            this.ItemIcon.TabIndex = 3;
            this.ItemIcon.TabStop = false;
            // 
            // InventoryCost
            // 
            this.InventoryCost.AutoSize = true;
            this.InventoryCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryCost.ForeColor = System.Drawing.Color.ForestGreen;
            this.InventoryCost.Location = new System.Drawing.Point(138, 181);
            this.InventoryCost.Name = "InventoryCost";
            this.InventoryCost.Size = new System.Drawing.Size(108, 20);
            this.InventoryCost.TabIndex = 14;
            this.InventoryCost.Text = "00000000000";
            // 
            // ItemName
            // 
            this.ItemName.AutoSize = true;
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(97, 57);
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(70, 25);
            this.ItemName.TabIndex = 4;
            this.ItemName.Text = "label2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "库存平均成本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "市场价";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 288);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "数量";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(289, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "00000000000";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "入库价";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(870, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "生产";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(870, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "出库";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(870, 533);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "查询";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SearchBox_Enter
            // 
            this.SearchBox_Enter.Location = new System.Drawing.Point(6, 18);
            this.SearchBox_Enter.Name = "SearchBox_Enter";
            this.SearchBox_Enter.Size = new System.Drawing.Size(326, 507);
            this.SearchBox_Enter.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 559);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "EVE-SSS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button EnterInventory;
        private System.Windows.Forms.Label InventoryCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label InventoryNumber;
        private System.Windows.Forms.Label label8;
        private SearchBox SearchBox_Enter;
    }
}

