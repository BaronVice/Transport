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
            MessageBox.Show("Set size");
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


    }
}
