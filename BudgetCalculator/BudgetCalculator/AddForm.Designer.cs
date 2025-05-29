namespace AddDLG
{
    partial class AddForm
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
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.LBL_Quantity = new System.Windows.Forms.Label();
            this.LBL_Unit = new System.Windows.Forms.Label();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.TXTB_Unit = new System.Windows.Forms.TextBox();
            this.BTN_OK = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.TXTB_Quantity = new System.Windows.Forms.TextBox();
            this.TXTB_Price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Location = new System.Drawing.Point(12, 9);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(44, 16);
            this.LBL_Name.TabIndex = 0;
            this.LBL_Name.Text = "Name";
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(12, 28);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(301, 22);
            this.TXTB_Name.TabIndex = 1;
            // 
            // LBL_Quantity
            // 
            this.LBL_Quantity.AutoSize = true;
            this.LBL_Quantity.Location = new System.Drawing.Point(12, 65);
            this.LBL_Quantity.Name = "LBL_Quantity";
            this.LBL_Quantity.Size = new System.Drawing.Size(104, 16);
            this.LBL_Quantity.TabIndex = 2;
            this.LBL_Quantity.Text = "Amount/Quantity";
            // 
            // LBL_Unit
            // 
            this.LBL_Unit.AutoSize = true;
            this.LBL_Unit.Location = new System.Drawing.Point(12, 119);
            this.LBL_Unit.Name = "LBL_Unit";
            this.LBL_Unit.Size = new System.Drawing.Size(104, 16);
            this.LBL_Unit.TabIndex = 3;
            this.LBL_Unit.Text = "Unit (eg. Lbs,Kg)";
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Location = new System.Drawing.Point(12, 177);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(64, 16);
            this.LBL_Price.TabIndex = 4;
            this.LBL_Price.Text = "Price per ";
            // 
            // TXTB_Unit
            // 
            this.TXTB_Unit.Location = new System.Drawing.Point(12, 138);
            this.TXTB_Unit.Name = "TXTB_Unit";
            this.TXTB_Unit.Size = new System.Drawing.Size(301, 22);
            this.TXTB_Unit.TabIndex = 5;
            this.TXTB_Unit.TextChanged += new System.EventHandler(this.TXTB_Unit_TextChanged);
            // 
            // BTN_OK
            // 
            this.BTN_OK.Location = new System.Drawing.Point(12, 281);
            this.BTN_OK.Name = "BTN_OK";
            this.BTN_OK.Size = new System.Drawing.Size(301, 23);
            this.BTN_OK.TabIndex = 8;
            this.BTN_OK.Text = "Add";
            this.BTN_OK.UseVisualStyleBackColor = true;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Location = new System.Drawing.Point(12, 310);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(301, 23);
            this.BTN_Cancel.TabIndex = 9;
            this.BTN_Cancel.Text = "Cancel";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            // 
            // LBL_Error
            // 
            this.LBL_Error.ForeColor = System.Drawing.Color.Red;
            this.LBL_Error.Location = new System.Drawing.Point(12, 360);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(301, 62);
            this.LBL_Error.TabIndex = 12;
            this.LBL_Error.Text = "Invalid Input detected (Please chek if each input is correct)";
            // 
            // TXTB_Quantity
            // 
            this.TXTB_Quantity.Location = new System.Drawing.Point(16, 84);
            this.TXTB_Quantity.Name = "TXTB_Quantity";
            this.TXTB_Quantity.Size = new System.Drawing.Size(297, 22);
            this.TXTB_Quantity.TabIndex = 13;
            this.TXTB_Quantity.Text = "0";
            // 
            // TXTB_Price
            // 
            this.TXTB_Price.Location = new System.Drawing.Point(12, 196);
            this.TXTB_Price.Name = "TXTB_Price";
            this.TXTB_Price.Size = new System.Drawing.Size(297, 22);
            this.TXTB_Price.TabIndex = 14;
            this.TXTB_Price.Text = "0";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 450);
            this.Controls.Add(this.TXTB_Price);
            this.Controls.Add(this.TXTB_Quantity);
            this.Controls.Add(this.LBL_Error);
            this.Controls.Add(this.BTN_Cancel);
            this.Controls.Add(this.BTN_OK);
            this.Controls.Add(this.TXTB_Unit);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.LBL_Unit);
            this.Controls.Add(this.LBL_Quantity);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.LBL_Name);
            this.Name = "AddForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.Label LBL_Quantity;
        private System.Windows.Forms.Label LBL_Unit;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.TextBox TXTB_Unit;
        private System.Windows.Forms.Button BTN_OK;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Label LBL_Error;
        private System.Windows.Forms.TextBox TXTB_Quantity;
        private System.Windows.Forms.TextBox TXTB_Price;
    }
}

