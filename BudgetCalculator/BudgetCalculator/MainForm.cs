using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            BTN_Save.Click += BTN_Save_Click;
            dlg.Initialize(AddForm.FormMode.Add, null);

            TXTB_Budget.KeyPress += TXTB_Budget_KeyPress;
            TXTB_Budget.TextChanged += TXTB_Budget_TextChanged;
            DGV_Table.DataSource = _myItems;
            DGV_Table.RowHeadersVisible = false;
            DGV_Table.AllowUserToAddRows = false;
            DGV_Table.ReadOnly = false;
            DGV_Table.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            BTN_Edit.Click += BTN_Edit_Click;
            BTN_Delete.Click += BTN_Delete_Click;
            LBL_Total.Text = "";

        }

        private void BTN_Save_Click(object sender, EventArgs e)
        {
            DLG_Save.Filter = "CSV files (*.csv)|*.csv";
            DLG_Save.Title = "Save as CSV File";
            DLG_Save.FileName = "data.csv";

            if(DLG_Save.ShowDialog() == DialogResult.OK)
            {
                var filePath = DLG_Save.FileName;
                DLG_Save.CheckFileExists = true;
                var content = new List<string>();

                content.Add("Name,Quantity,Cost,TotalPrice");

                foreach (var item in _myItems)
                {
                    content.Add($"\"{item.Name}\",{item.Quantity},{item.Cost},{item.TotalPrice}");
                }

                var total = _myItems.Sum(x => x.TotalPrice);
                content.Add($",,,{total}");
                content.Add($"Budget,,,{_budget}");
                content.Add($"Leftover,,,{_budget - total}");

                try
                {
                    File.WriteAllLines(filePath, content);
                    MessageBox.Show("CSV file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving CSV:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            _myItems.AllowRemove = true;
            var itemTodelete = DGV_Table.CurrentRow?.DataBoundItem;
            if (itemTodelete == null ) return;
            _myItems.Remove((Items)itemTodelete);
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
                ShowTotal();
            }
        }

        private void TXTB_Budget_TextChanged(object sender, EventArgs e)
        {
            if(!double.TryParse(TXTB_Budget.Text, out _budget))
                return;
            ShowTotal();
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
                ShowTotal();
            }
        }

        /// <summary>
        /// Show the user the total spending and budget leftover
        /// </summary>
        private void ShowTotal()
        {
            double total = _myItems.Sum((x) => x.TotalPrice);

            Invoke(new Action(() => { LBL_Total.Text = 
                $"Your total spending is : {total} \n" +
                $"Total budget left : {_budget - total}"; 
            }));
        }
    }
}
