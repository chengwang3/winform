namespace winform
{
    partial class ListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_left = new System.Windows.Forms.ListBox();
            this.listbox_right = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_select = new System.Windows.Forms.Button();
            this.button_show = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_left);
            this.groupBox1.Location = new System.Drawing.Point(47, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "优秀学员候选人";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listbox_right);
            this.groupBox2.Location = new System.Drawing.Point(359, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 225);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "优秀学员";
            // 
            // listBox_left
            // 
            this.listBox_left.FormattingEnabled = true;
            this.listBox_left.ItemHeight = 18;
            this.listBox_left.Location = new System.Drawing.Point(0, 40);
            this.listBox_left.Name = "listBox_left";
            this.listBox_left.Size = new System.Drawing.Size(200, 184);
            this.listBox_left.TabIndex = 0;
            // 
            // listbox_right
            // 
            this.listbox_right.FormattingEnabled = true;
            this.listbox_right.ItemHeight = 18;
            this.listbox_right.Location = new System.Drawing.Point(0, 41);
            this.listbox_right.Name = "listbox_right";
            this.listbox_right.Size = new System.Drawing.Size(200, 184);
            this.listbox_right.TabIndex = 0;
            // 
            // button_select
            // 
            this.button_select.Location = new System.Drawing.Point(266, 179);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(75, 40);
            this.button_select.TabIndex = 1;
            this.button_select.Text = ">>";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(411, 324);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 40);
            this.button_show.TabIndex = 2;
            this.button_show.Text = "显示";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 410);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox_left;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listbox_right;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Button button_show;
    }
}