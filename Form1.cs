using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnGetResult.Enabled = false;
            pnlSetTable.Hide();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.ColumnHeadersVisible = false;
        }

        private void btnCallTable_Click_1(object sender, EventArgs e)
        {
            pnlSetTable.Show();
        }

        private void btnGetResult_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Nothing right now");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSetSize_Click(object sender, EventArgs e)
        {
            if (tbProduce.TextLength == 0 || tbConsume.TextLength == 0)
            {
                MessageBox.Show("Какой-то аргумент не задан", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Int32.Parse(tbConsume.Text) == 0 || Int32.Parse(tbProduce.Text) == 0)
            {
                MessageBox.Show("Значения должны быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<DataGridView> grids = new List<DataGridView>();
            grids.Add(dataGridView1);
            grids.Add(dataGridView2);
            grids.Add(dataGridView3);

            TableManip.clearTables(grids);

            TableManip.setTable(dataGridView1, Int32.Parse(tbConsume.Text), 1, "A");
            TableManip.setTable(dataGridView2, Int32.Parse(tbProduce.Text), 1, "B");
            TableManip.setTable(dataGridView3, Int32.Parse(tbProduce.Text), Int32.Parse(tbConsume.Text), "Prices");

            btnGetResult.Enabled = true;
            pnlSetTable.Hide();

        }

        private void clearTable_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clear");
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


    }

    public class TableManip
    {
        private static void clearChosenTable(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.Rows.Clear();
            grid.Refresh();
        }

        public static void clearTables(List<DataGridView> grids)
        {
            foreach (DataGridView grid in grids)
            {
                clearChosenTable(grid);
            }
        }

        public static void setTable(DataGridView grid, int columns, int rows, string columnLetter)
        {
            int width = Math.Max(951 / columns, 80);
            for (int i = 0; i < columns; i++)
            {
                grid.Columns.Add("column" + columnLetter + (i + 1).ToString(), columnLetter + (i + 1).ToString());
                grid.Columns[i].Width = width;
            }
            for (int i = 0; i < rows; i++)
            {
                grid.Rows.Add();
            }
        }
    }
}
