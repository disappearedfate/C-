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
    public partial class user : Form
    {
        public user()
        {
            InitializeComponent();
        }

        private void user_Load(object sender, EventArgs e)
        {
            
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 当前用户状况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 u3 = new user3();
            u3.ShowDialog();
        }

        private void 图书查借ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 u2 = new user2();
            u2.ShowDialog();
        }
    }
}
