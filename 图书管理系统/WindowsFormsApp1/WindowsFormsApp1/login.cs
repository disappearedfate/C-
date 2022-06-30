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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("账号或密码输入有误");
            }
        }

        public Boolean Login()
        {
            if(radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from t_user where id = '" + textBox1.Text + "' and psw = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("欢迎" + dc["name"] + "");

                    user user1 = new user();
                    this.Hide();
                    user1.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败，密码或账号错误");
                  
                }
            }
            if (radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = "select * from t_admin where id = '" + textBox1.Text + "' and psw = '" + textBox2.Text + "'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("您好，管理员");
                    adminer admin = new adminer();
                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登录失败，密码或账号错误");
            
                }
            }
            return false;
        }
    }
}
