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
        }

        private void btnCallTable_Click_1(object sender, EventArgs e)
        {
            pnlSetTable.Show();
        }

        private void btnGetResult_Click(object sender, EventArgs e)
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
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();


            int width = Math.Max(951 / Int32.Parse(tbConsume.Text), 80);
            for (int i = 0; i < Int32.Parse(tbConsume.Text); i++)
            {
                dataGridView1.Columns.Add("columnA" + (i + 1).ToString(), "A" + (i + 1).ToString());
                dataGridView1.Columns[i].Width = width;
            }
            dataGridView1.Rows.Add();

            width = Math.Max(951 / Int32.Parse(tbProduce.Text), 80);
            for (int i = 0; i < Int32.Parse(tbProduce.Text); i++)
            {
                dataGridView2.Columns.Add("columnB" + (i + 1).ToString(), "B" + (i + 1).ToString());
                dataGridView2.Columns[i].Width = width;
            }
            dataGridView2.Rows.Add();

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
}
