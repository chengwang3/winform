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
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string str ="";
            txt_show.Clear();
            foreach (System.Windows.Forms.CheckBox item in gbox_food.Controls)
            {
                if (item.Checked)
                {
                    str += item.Text + "+";
                }
            }
            txt_show.Text = str;
        }
    }
}
