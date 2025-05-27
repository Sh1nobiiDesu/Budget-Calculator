using BudgetCalculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddDLG
{
    public partial class AddForm : Form
    {
        public Items newItem = null;
        public AddForm()
        {
            InitializeComponent();
            BTN_add.Click += BTN_add_Click;
            BTN_Cancel.Click += BTN_Cancel_Click;
            LBL_Error.Visible = false;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void BTN_add_Click(object sender, EventArgs e)
        {
            bool error = false;
            string name = TXTB_Name.Text;
            string Unit = TXTB_Unit.Text;
            decimal count = TXTB_Quantity.Value;
            decimal price = TXTB_Price.Value;
            if(count <= 0 )
            {
                LBL_Quantity.ForeColor = Color.Red;
                LBL_Error.Visible = true;
                return;
            }
            else if(price <= 0)
            {
                LBL_Price.ForeColor = Color.Red;
                LBL_Error.Visible = true;
                return;
            }

            newItem = new Items(name, Unit, count, price);
            ReInit();
            DialogResult = DialogResult.OK;
        }

        public void ReInit()
        {
            TXTB_Name.Text = "";
            TXTB_Unit.Text = "";
            TXTB_Quantity.Value = 0;
            TXTB_Price.Value = 0;
            LBL_Error.Visible = false;
            LBL_Name.ForeColor = Color.Black;
            LBL_Price.ForeColor = Color.Black;
            LBL_Quantity.ForeColor = Color.Black;
            LBL_Unit.ForeColor = Color.Black;
        }

        private void TXTB_Unit_TextChanged(object sender, EventArgs e)
        {
            LBL_Price.Text = "Price per " + TXTB_Unit.Text;
        }
    }
}
