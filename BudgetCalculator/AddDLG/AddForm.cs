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
        public AddForm()
        {
            InitializeComponent();

        }

        private void TXTB_Unit_TextChanged(object sender, EventArgs e)
        {
            LBL_Price.Text = "Price per " + TXTB_Unit.Text;
        }
    }
}
