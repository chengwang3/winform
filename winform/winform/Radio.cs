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
    public partial class Radio : Form
    {
        public Radio()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (rad_male.Checked ==true)
            {
                MessageBox.Show("选择男性", "提示", MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("选择女性", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_than_Click(object sender, EventArgs e)
        {
            if (rad_big.Checked == true)
            {
                MessageBox.Show("选择大", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("选择小", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
