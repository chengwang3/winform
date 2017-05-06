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
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
            listBox_left.Items.Add("张三");
            listBox_left.Items.Add("李四");
            listBox_left.Items.Add("小明");
            listBox_left.Items.Add("小牛");
            listBox_left.Items.Add("王五");
        }

        private void button_select_Click(object sender, EventArgs e)
        {
            if (listBox_left.SelectedIndex >= 0)
            {
                listbox_right.Items.Add(listBox_left.SelectedItem);
                listBox_left.Items.RemoveAt(listBox_left.SelectedIndex);
            }
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string str = "优秀学员为：";
            int len = listbox_right.Items.Count;
            if (len > 0)
            {
                for (int i = 0;i<len;i++)
                {
                    str += listbox_right.Items[i].ToString() + ",";
                }
                MessageBox.Show(str);
            }else
            {
                MessageBox.Show("没有优秀学员");
            }
        }
    }
}
