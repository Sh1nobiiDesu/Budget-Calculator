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
        public enum FormMode
        {
            Add,
            Edit
        };
        public Items newItem = null;
        public AddForm()
        {
            InitializeComponent();
            BTN_OK.Click += BTN_add_Click;
            BTN_Cancel.Click += BTN_Cancel_Click;
            LBL_Error.Visible = false;
            TXTB_Price.KeyPress += NumOnly;
            TXTB_Quantity.KeyPress += NumOnly;
        }
        
        private void NumOnly(object sender, KeyPressEventArgs e)
        {
            // only allow numbers
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        public void Initialize(FormMode mode, Items item)
        {
            if (!(mode == FormMode.Edit))
            {
                return;
            }

            BTN_OK.Text = "Save";
            TXTB_Name.Text = item.Name;
            TXTB_Price.Text = item.Price.ToString();    
            TXTB_Quantity.Text = item.Quantity.ToString();
            TXTB_Unit.Text = item.Unit;
            
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            ReInit();   
            DialogResult = DialogResult.Cancel;
        }


        private void BTN_add_Click(object sender, EventArgs e)
        {
            bool error = false;
            string name = TXTB_Name.Text;
            string Unit = TXTB_Unit.Text;
            double count = double.Parse(TXTB_Quantity.Text);
            double price = double.Parse(TXTB_Price.Text);
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
            TXTB_Price.Text = "0";
            TXTB_Quantity.Text = "0";
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
