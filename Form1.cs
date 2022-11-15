using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transport.CustomTable;

namespace Transport
{
    public partial class Form1 : Form
    {

        List<GridTable> gridTables = new List<GridTable>(3);
        GridTable tableConsume = new GridTable();
        GridTable tableProduce = new GridTable();
        GridTable tableExpences = new GridTable();

        public Form1()
        {
            InitializeComponent();
            btnGetResult.Enabled = false;
            clearTable.Enabled = false;
            pnlSetTable.Hide();
            dataGridView3.ColumnHeadersVisible = false;

            tableConsume.setArguments(dataGridView1, 3, 1, "B");
            tableProduce.setArguments(dataGridView2, 4, 1, "A");
            tableExpences.setArguments(dataGridView3, 4, 5, "Prices");

            gridTables.Add(tableConsume);
            gridTables.Add(tableProduce);
            gridTables.Add(tableExpences);
        }


        private void btnCallTable_Click_1(object sender, EventArgs e)
        {
            pnlSetTable.Show();
            tbProduce.Focus();
        }

        private void btnGetResult_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing right now");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private bool checkInput()
        {
            if (tbProduce.TextLength == 0 || tbConsume.TextLength == 0)
            {
                MessageBox.Show("Какой-то аргумент не задан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (Int32.Parse(tbConsume.Text) == 0 || Int32.Parse(tbProduce.Text) == 0)
            {
                MessageBox.Show("Значения должны быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            if (!checkInput())
                return;

            tableConsume.columns = Int32.Parse(tbConsume.Text);
            tableProduce.columns = Int32.Parse(tbProduce.Text);
            tableExpences.rows = Int32.Parse(tbProduce.Text) + 1;
            tableExpences.columns = Int32.Parse(tbConsume.Text) + 1;

            TableManip.buildTables(gridTables);

            btnGetResult.Enabled = true;
            clearTable.Enabled = true;
            pnlSetTable.Hide();


        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear");
            TableManip.buildTables(gridTables);
            pnlSetTable.Hide();
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            pnlSetTable.Hide();
        }

        private void tbProduce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbConsume_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbProduce_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                tbConsume.Focus();
            }
        }

        private void tbConsume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (int)Keys.Enter)
            {
                btnSetSize.PerformClick();
            }
        }

        private void dataGridView2_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            TableManip.checkCell(e);
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            TableManip.checkCell(e);
        }

        private void dataGridView3_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            TableManip.checkCell(e, true);
        }
    }
}
