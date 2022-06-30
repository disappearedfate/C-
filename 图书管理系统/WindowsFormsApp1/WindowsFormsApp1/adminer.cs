using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adminer : Form
    {
        public adminer()
        {
            InitializeComponent();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin2 a = new admin2();
            a.ShowDialog();
        }
    }
}
