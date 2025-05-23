namespace UserAdd
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
            this.LBL_Name = new System.Windows.Forms.Label();
            this.TXTB_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LBL_Quantity = new System.Windows.Forms.Label();
            this.LBL_Price = new System.Windows.Forms.Label();
            this.TXTB_Price = new System.Windows.Forms.TextBox();
            this.TXTB_Quantity = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.TXTB_Units = new System.Windows.Forms.TextBox();
            this.LBL_Units = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBL_Name
            // 
            this.LBL_Name.AutoSize = true;
            this.LBL_Name.Location = new System.Drawing.Point(12, 29);
            this.LBL_Name.Name = "LBL_Name";
            this.LBL_Name.Size = new System.Drawing.Size(50, 16);
            this.LBL_Name.TabIndex = 0;
            this.LBL_Name.Text = "Name :";
            // 
            // TXTB_Name
            // 
            this.TXTB_Name.Location = new System.Drawing.Point(15, 48);
            this.TXTB_Name.Name = "TXTB_Name";
            this.TXTB_Name.Size = new System.Drawing.Size(306, 22);
            this.TXTB_Name.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LBL_Quantity
            // 
            this.LBL_Quantity.AutoSize = true;
            this.LBL_Quantity.Location = new System.Drawing.Point(12, 86);
            this.LBL_Quantity.Name = "LBL_Quantity";
            this.LBL_Quantity.Size = new System.Drawing.Size(110, 16);
            this.LBL_Quantity.TabIndex = 3;
            this.LBL_Quantity.Text = "Quantity/Amount :";
            // 
            // LBL_Price
            // 
            this.LBL_Price.AutoSize = true;
            this.LBL_Price.Location = new System.Drawing.Point(12, 233);
            this.LBL_Price.Name = "LBL_Price";
            this.LBL_Price.Size = new System.Drawing.Size(64, 16);
            this.LBL_Price.TabIndex = 4;
            this.LBL_Price.Text = "Price per ";
            // 
            // TXTB_Price
            // 
            this.TXTB_Price.Location = new System.Drawing.Point(15, 252);
            this.TXTB_Price.Name = "TXTB_Price";
            this.TXTB_Price.Size = new System.Drawing.Size(306, 22);
            this.TXTB_Price.TabIndex = 5;
            // 
            // TXTB_Quantity
            // 
            this.TXTB_Quantity.Location = new System.Drawing.Point(15, 105);
            this.TXTB_Quantity.Name = "TXTB_Quantity";
            this.TXTB_Quantity.Size = new System.Drawing.Size(306, 22);
            this.TXTB_Quantity.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(306, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TXTB_Units
            // 
            this.TXTB_Units.Location = new System.Drawing.Point(15, 177);
            this.TXTB_Units.Name = "TXTB_Units";
            this.TXTB_Units.Size = new System.Drawing.Size(306, 22);
            this.TXTB_Units.TabIndex = 9;
            // 
            // LBL_Units
            // 
            this.LBL_Units.AutoSize = true;
            this.LBL_Units.Location = new System.Drawing.Point(12, 158);
            this.LBL_Units.Name = "LBL_Units";
            this.LBL_Units.Size = new System.Drawing.Size(124, 16);
            this.LBL_Units.TabIndex = 8;
            this.LBL_Units.Text = "Unit (eg. lbl,gallons)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 450);
            this.Controls.Add(this.TXTB_Units);
            this.Controls.Add(this.LBL_Units);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TXTB_Quantity);
            this.Controls.Add(this.TXTB_Price);
            this.Controls.Add(this.LBL_Price);
            this.Controls.Add(this.LBL_Quantity);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TXTB_Name);
            this.Controls.Add(this.LBL_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Name;
        private System.Windows.Forms.TextBox TXTB_Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBL_Quantity;
        private System.Windows.Forms.Label LBL_Price;
        private System.Windows.Forms.TextBox TXTB_Price;
        private System.Windows.Forms.TextBox TXTB_Quantity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox TXTB_Units;
        private System.Windows.Forms.Label LBL_Units;
    }
}

