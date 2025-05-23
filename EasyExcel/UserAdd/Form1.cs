using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserAdd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TXTB_Units.TextChanged += TXTB_Units_TextChanged;
        }

        private void TXTB_Units_TextChanged(object sender, EventArgs e)
        {
            string text = "Price per ";
            LBL_Price.Text = text + TXTB_Units.Text;

        }
    }
}
