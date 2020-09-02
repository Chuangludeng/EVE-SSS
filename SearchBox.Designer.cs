namespace EVE_SSS
{
    partial class SearchBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BlueprintItemList = new System.Windows.Forms.ListView();
            this.label9 = new System.Windows.Forms.Label();
            this.ResultList = new System.Windows.Forms.ListView();
            this.ItemNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BlueprintItemList
            // 
            this.BlueprintItemList.HideSelection = false;
            this.BlueprintItemList.Location = new System.Drawing.Point(24, 273);
            this.BlueprintItemList.Name = "BlueprintItemList";
            this.BlueprintItemList.Size = new System.Drawing.Size(208, 192);
            this.BlueprintItemList.TabIndex = 24;
            this.BlueprintItemList.UseCompatibleStateImageBehavior = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "蓝图材料";
            // 
            // ResultList
            // 
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(24, 66);
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(208, 164);
            this.ResultList.TabIndex = 22;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            // 
            // ItemNameInput
            // 
            this.ItemNameInput.Location = new System.Drawing.Point(58, 29);
            this.ItemNameInput.Name = "ItemNameInput";
            this.ItemNameInput.Size = new System.Drawing.Size(174, 20);
            this.ItemNameInput.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "物品";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ResultList);
            this.groupBox1.Controls.Add(this.BlueprintItemList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.ItemNameInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 492);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索";
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "SearchBox";
            this.Size = new System.Drawing.Size(265, 492);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView BlueprintItemList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.TextBox ItemNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
