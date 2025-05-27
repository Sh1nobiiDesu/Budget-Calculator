using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AddDLG;

namespace BudgetCalculator
{
    public partial class MainForm : Form
    {
        List<int> mylist = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            AddForm dlg = new AddForm();
            dlg.ShowDialog();
        }
    }
}
