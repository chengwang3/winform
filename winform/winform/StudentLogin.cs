using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform
{
    public partial class StudentLogin : Form
    {
        public StudentLogin()
        {
            InitializeComponent();
            comboBox_location.Items.Add("湖北省");
            comboBox_location.Items.Add("湖南省");
            comboBox_location.Items.Add("江苏省");
            comboBox_location.Items.Add("浙江省");
            comboBox_location.SelectedIndex = 0;
        }
  
        private void button_login_Click(object sender, EventArgs e)
        {
            if (radioButton_man.Checked == false && radioButton_woman.Checked == false)
            {
                MessageBox.Show("性别不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (radioButton_yes.Checked == false && radioButton_no.Checked == false)
            {
                MessageBox.Show("选择是否成年不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void comboBox_location_SelectedIndexChanged(object sender, EventArgs e)
        {
            string location = comboBox_location.SelectedItem.ToString();
            switch (location)
            {
                case "湖北省":
                    listBox_city.Items.Clear();
                    listBox_city.Items.Add("武汉市");
                    listBox_city.Items.Add("孝感市");
                    listBox_city.Items.Add("黄冈市");
                    break;
                case "湖南省":
                    listBox_city.Items.Clear();
                    listBox_city.Items.Add("长沙市");
                    listBox_city.Items.Add("孝感市");
                    listBox_city.Items.Add("黄冈市");
                    break;
                case "江苏省":
                    listBox_city.Items.Clear();
                    listBox_city.Items.Add("南京市");
                    listBox_city.Items.Add("苏州市");
                    listBox_city.Items.Add("常州市");
                    break;
                case "浙江省":
                    listBox_city.Items.Clear();
                    listBox_city.Items.Add("杭州市");
                    listBox_city.Items.Add("温州市");
                    listBox_city.Items.Add("无锡市");
                    break;
            }
        }
    }
}
