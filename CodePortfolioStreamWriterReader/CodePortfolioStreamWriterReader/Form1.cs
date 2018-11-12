using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePortfolioStreamWriterReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btStore.Click += BtStore_Click;
            btRetrieve.Click += BtRetrieve_Click;
        }

        private void BtRetrieve_Click(object sender, EventArgs e)
        {
            lbRetrieved.Text = Properties.Settings.Default.txtStored;
            Properties.Settings.Default.Save();
        }

        private void BtStore_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.txtStored = tbTest.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbRetrieved.Text = "";
        }
    }
}
