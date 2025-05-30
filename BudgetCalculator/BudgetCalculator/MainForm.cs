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
        BindingList<Items> _myItems = new BindingList<Items>();
        double _budget = 0;
        AddForm dlg = new AddForm();
        public MainForm()
        {
            InitializeComponent();
            dlg.Initialize(AddForm.FormMode.Add, null);

            TXTB_Budget.KeyPress += TXTB_Budget_KeyPress;
            TXTB_Budget.TextChanged += TXTB_Budget_TextChanged;
            TXTB_Budget.Text = "0";
            DGV_Table.DataSource = _myItems;
            DGV_Table.RowHeadersVisible = false;
            DGV_Table.AllowUserToAddRows = false;
            DGV_Table.CellClick += DGV_Table_CellClick;
            DGV_Table.ReadOnly = false;

            BTN_Edit.Click += BTN_Edit_Click;
        }

        private void DGV_Table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
        }

        private void BTN_Edit_Click(object sender, EventArgs e)
        {
            _myItems.AllowEdit = true;
            var itemToedit = DGV_Table.CurrentRow?.DataBoundItem;
            if (itemToedit == null)
                return;
            dlg.Initialize(AddForm.FormMode.Edit, (Items) itemToedit);
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                _myItems[DGV_Table.CurrentRow.Index] = dlg.newItem;
            }
        }

        private void TXTB_Budget_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(TXTB_Budget.Text, out _budget))
            {
                return;
            }
        }

        private void TXTB_Budget_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _myItems.Add(dlg.newItem);
                //DGV_Table.DataSource = _myItems;
                ShowTotal();
            }
        }

        private void ShowTotal()
        {
            double total = _myItems.Sum((x) => x.TotalPrice);

            Invoke(new Action(() => { LBL_Total.Text = 
                $"Your total spending is :{total} \n" +
                $"Total budget left : {_budget - total}"; 
            }));
        }
    }
}
