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
        List<Items> _myItems = new List<Items>();
        public MainForm()
        {
            InitializeComponent();
            DGV_Table.DataSource = null;
            DGV_Table.DataSource = _myItems;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            var dlg = new AddForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _myItems.Add(dlg.newItem);
                DGV_Table.DataSource = null;
                DGV_Table.DataSource = _myItems;
            }

        }
    }
}
