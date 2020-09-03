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
            this.ResultList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultList
            // 
            this.ResultList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.ResultList.HideSelection = false;
            this.ResultList.Location = new System.Drawing.Point(24, 66);
            this.ResultList.MultiSelect = false;
            this.ResultList.Name = "ResultList";
            this.ResultList.Size = new System.Drawing.Size(290, 420);
            this.ResultList.TabIndex = 22;
            this.ResultList.UseCompatibleStateImageBehavior = false;
            this.ResultList.View = System.Windows.Forms.View.Details;
            this.ResultList.SelectedIndexChanged += new System.EventHandler(this.ResultList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "名称";
            this.columnHeader1.Width = 280;
            // 
            // ItemNameInput
            // 
            this.ItemNameInput.Location = new System.Drawing.Point(58, 29);
            this.ItemNameInput.Name = "ItemNameInput";
            this.ItemNameInput.Size = new System.Drawing.Size(256, 20);
            this.ItemNameInput.TabIndex = 21;
            this.ItemNameInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ItemNameInput_KeyUp);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ItemNameInput);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 492);
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
            this.Size = new System.Drawing.Size(365, 492);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView ResultList;
        private System.Windows.Forms.TextBox ItemNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
