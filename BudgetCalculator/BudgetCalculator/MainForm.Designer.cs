namespace BudgetCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTN_Add = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Delete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTN_Edit = new System.Windows.Forms.ToolStripButton();
            this.LBL_Budget = new System.Windows.Forms.Label();
            this.TXTB_Budget = new System.Windows.Forms.TextBox();
            this.LBL_Total = new System.Windows.Forms.Label();
            this.DGV_Table = new System.Windows.Forms.DataGridView();
            this.BTN_Save = new System.Windows.Forms.Button();
            this.DLG_Save = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTN_Add,
            this.toolStripSeparator1,
            this.BTN_Delete,
            this.toolStripSeparator2,
            this.BTN_Edit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTN_Add
            // 
            this.BTN_Add.AutoSize = false;
            this.BTN_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Add.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Add.Image")));
            this.BTN_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(50, 24);
            this.BTN_Add.Text = "Add";
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Delete.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Delete.Image")));
            this.BTN_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(57, 24);
            this.BTN_Delete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BTN_Edit
            // 
            this.BTN_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BTN_Edit.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Edit.Image")));
            this.BTN_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTN_Edit.Name = "BTN_Edit";
            this.BTN_Edit.Size = new System.Drawing.Size(39, 24);
            this.BTN_Edit.Text = "Edit";
            // 
            // LBL_Budget
            // 
            this.LBL_Budget.AutoSize = true;
            this.LBL_Budget.Location = new System.Drawing.Point(674, 8);
            this.LBL_Budget.Name = "LBL_Budget";
            this.LBL_Budget.Size = new System.Drawing.Size(56, 16);
            this.LBL_Budget.TabIndex = 5;
            this.LBL_Budget.Text = "Budget: ";
            // 
            // TXTB_Budget
            // 
            this.TXTB_Budget.Location = new System.Drawing.Point(736, 5);
            this.TXTB_Budget.Name = "TXTB_Budget";
            this.TXTB_Budget.Size = new System.Drawing.Size(125, 22);
            this.TXTB_Budget.TabIndex = 6;
            this.TXTB_Budget.Text = "0";
            // 
            // LBL_Total
            // 
            this.LBL_Total.Location = new System.Drawing.Point(12, 427);
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(370, 56);
            this.LBL_Total.TabIndex = 7;
            this.LBL_Total.Text = "label1";
            // 
            // DGV_Table
            // 
            this.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Table.Location = new System.Drawing.Point(12, 33);
            this.DGV_Table.Name = "DGV_Table";
            this.DGV_Table.RowHeadersWidth = 51;
            this.DGV_Table.RowTemplate.Height = 24;
            this.DGV_Table.Size = new System.Drawing.Size(849, 385);
            this.DGV_Table.TabIndex = 8;
            // 
            // BTN_Save
            // 
            this.BTN_Save.Location = new System.Drawing.Point(786, 424);
            this.BTN_Save.Name = "BTN_Save";
            this.BTN_Save.Size = new System.Drawing.Size(75, 23);
            this.BTN_Save.TabIndex = 9;
            this.BTN_Save.Text = "Save";
            this.BTN_Save.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 521);
            this.Controls.Add(this.BTN_Save);
            this.Controls.Add(this.DGV_Table);
            this.Controls.Add(this.LBL_Total);
            this.Controls.Add(this.TXTB_Budget);
            this.Controls.Add(this.LBL_Budget);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTN_Add;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTN_Delete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTN_Edit;
        private System.Windows.Forms.Label LBL_Budget;
        private System.Windows.Forms.TextBox TXTB_Budget;
        private System.Windows.Forms.Label LBL_Total;
        private System.Windows.Forms.DataGridView DGV_Table;
        private System.Windows.Forms.Button BTN_Save;
        private System.Windows.Forms.SaveFileDialog DLG_Save;
    }
}

