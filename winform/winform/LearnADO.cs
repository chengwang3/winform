using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace winform
{
    public partial class LearnADO : Form
    {
        public LearnADO()
        {
            InitializeComponent();
        }

        private void LearnADO_Load(object sender, EventArgs e)
        {
            //连接字符串
            string sqlstr =@"Data Source=CWANG\SQLEXPRESS;Initial Catalog=factory;Integrated Security=True";
            //创建连接对象
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = sqlstr;
            //
            string sqltext = "SELECT * FROM [factory].[dbo].[worker]";
            //打开数据连接
            sqlcon.Open();
            //创建连接命令对象
            SqlCommand sqlcom = new SqlCommand(sqltext, sqlcon);
         
            try {
                //***** SqlDataReader 和 BindingSource
                //SqlDataReader reader = sqlcom.ExecuteReader();
                //BindingSource Bs = new BindingSource();
                //Bs.DataSource = reader;
                //dataGridView1.DataSource = Bs;

                //使用SqlDataReader和方法Read()显示数据
                SqlDataReader reader = sqlcom.ExecuteReader();
                while (reader.Read())
                    {
                        int index = dataGridView1.Rows.Add();
                        dataGridView1.Rows[index].Cells[0].Value = reader[0].ToString();
                        dataGridView1.Rows[index].Cells[1].Value = reader[1].ToString();
                        dataGridView1.Rows[index].Cells[2].Value = reader[2].ToString();
                        dataGridView1.Rows[index].Cells[3].Value = reader[3].ToString();
                        dataGridView1.Rows[index].Cells[4].Value = reader[4].ToString();
                        dataGridView1.Rows[index].Cells[5].Value = reader[5].ToString();
                        dataGridView1.Rows[index].Cells[6].Value = reader[6].ToString();
                }             
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            finally
            {
                    //关闭数据连接
                    sqlcon.Close();
               
            }
            textBox_name.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            if (dataGridView1.Rows[0].Cells[2].Value.ToString() == "男")
            {
                radioButton_male.Checked = true;
            }
            else
            {
                radioButton_female.Checked = true;
            }
            //dateTimePicker_birthday.Value =Convert.ToDateTime(dataGridView1.Rows[0].Cells[3].Value.ToString());
            if (dataGridView1.Rows[0].Cells[4].Value.ToString() == "是")
            {
                radioButton_party.Checked = true;
            }
            else
            {
                radioButton_noparty.Checked = true;
            }
            //dateTimePicker_work.Value = (DateTime)dataGridView1.Rows[0].Cells[5].Value;
            comboBox_depart.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i=0;i<dataGridView1.Rows.Count;i++)
            {
                if (dataGridView1.Rows[i].Selected ==true)
                {
                    textBox_name.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    if (dataGridView1.Rows[i].Cells[2].Value.ToString() == "男")
                    {
                        radioButton_male.Checked = true;
                    }
                    else
                    {
                        radioButton_female.Checked = true;
                    }
                    //dateTimePicker_birthday.Value =Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    if (dataGridView1.Rows[i].Cells[4].Value.ToString() == "是")
                    {
                        radioButton_party.Checked = true;
                    }
                    else
                    {
                        radioButton_noparty.Checked = true;
                    }
                    //dateTimePicker_work.Value = (DateTime)dataGridView1.Rows[i].Cells[5].Value;
                    comboBox_depart.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();

                }
            }
          
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string sex, party;
            if (radioButton_male.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            if (radioButton_party.Checked)
            {
                party = "是";
            }else
            {
                party = "否";
            }
            //连接字符串
            string sqlstr = @"Data Source=CWANG\SQLEXPRESS;Initial Catalog=factory;Integrated Security=True";
            //创建连接对象
            SqlConnection sqlcon = new SqlConnection();
            sqlcon.ConnectionString = sqlstr;
            //
            string sqltext ="Update[factory].[dbo].[worker] Set wname = '" + textBox_name.Text + "', wsex = '"+ sex + "', wparty = '"+party+"', depid = '" + comboBox_depart.Text + "' where wid = '"+ dataGridView1.Rows[index].Cells[0].Value.ToString()+ "'";
            //打开数据连接
            sqlcon.Open();
            //创建连接命令对象
            try {
                SqlCommand sqlcom = new SqlCommand(sqltext, sqlcon);
                int res = sqlcom.ExecuteNonQuery();
                if (res>=0)
                {
                     dataGridView1.Rows[index].Cells[1].Value = textBox_name.Text;
                    if (radioButton_male.Checked)
                    {
                        dataGridView1.Rows[index].Cells[2].Value = "男";
                    }else
                    {
                        dataGridView1.Rows[index].Cells[2].Value = "女";
                    }
                    //dateTimePicker_birthday.Value =Convert.ToDateTime(dataGridView1.Rows[index].Cells[3].Value.ToString());
                    if (radioButton_party.Checked)
                    {
                        dataGridView1.Rows[index].Cells[4].Value = "是";
                    }
                    else
                    {
                        dataGridView1.Rows[index].Cells[4].Value = "否";
                    }
                    //dateTimePicker_work.Value = (DateTime)dataGridView1.Rows[index].Cells[5].Value;
                  dataGridView1.Rows[index].Cells[6].Value = comboBox_depart.Text;
                    MessageBox.Show("保存修改成功");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
           


        }
    }
}
