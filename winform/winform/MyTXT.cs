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
    public partial class MyTXT : Form
    {
        public string str = "";
        public MyTXT()
        {
            InitializeComponent();
        }
  
        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            str = richTextBox1.SelectedText;
            Clipboard.SetText(str);
            richTextBox1.SelectedText = "";
        }

        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }

        }

        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = openFileDialog1.SafeFileName;
            }
        }
    }
}
