using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6;

namespace WindowsFormsApp3
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void моиАкцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
           myaction myaction = new myaction(); 
           myaction.Show();
           Hide();
        }

        private void запросНаПокупкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
