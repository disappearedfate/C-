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
    public partial class user3 : Form
    {
        public user3()
        {
            InitializeComponent();
            Table();
        }

        public void Table()//书籍数据显示
        {
            dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_lend where [uid]='{Data.UID}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[1].ToString(), dc[2].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string time = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string id = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from t_lend where [bid]='{id}';update t_book set number=number+1 where id='{id}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("归还成功");
                Table();
            }
            else
            {
                MessageBox.Show("操作失败");
            }
        }
    }
}
