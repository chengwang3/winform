namespace winform
{
    partial class Radio
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
            this.gbox_sex = new System.Windows.Forms.GroupBox();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.gbox_than = new System.Windows.Forms.GroupBox();
            this.rad_big = new System.Windows.Forms.RadioButton();
            this.rad_small = new System.Windows.Forms.RadioButton();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_than = new System.Windows.Forms.Button();
            this.gbox_sex.SuspendLayout();
            this.gbox_than.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbox_sex
            // 
            this.gbox_sex.Controls.Add(this.btn_submit);
            this.gbox_sex.Controls.Add(this.rad_male);
            this.gbox_sex.Controls.Add(this.rad_female);
            this.gbox_sex.Location = new System.Drawing.Point(122, 100);
            this.gbox_sex.Name = "gbox_sex";
            this.gbox_sex.Size = new System.Drawing.Size(236, 199);
            this.gbox_sex.TabIndex = 0;
            this.gbox_sex.TabStop = false;
            this.gbox_sex.Text = "性别";
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Checked = true;
            this.rad_male.Location = new System.Drawing.Point(70, 36);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(51, 22);
            this.rad_male.TabIndex = 0;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "男";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(70, 88);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(51, 22);
            this.rad_female.TabIndex = 0;
            this.rad_female.Text = "女";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // gbox_than
            // 
            this.gbox_than.Controls.Add(this.btn_than);
            this.gbox_than.Controls.Add(this.rad_small);
            this.gbox_than.Controls.Add(this.rad_big);
            this.gbox_than.Location = new System.Drawing.Point(581, 100);
            this.gbox_than.Name = "gbox_than";
            this.gbox_than.Size = new System.Drawing.Size(200, 199);
            this.gbox_than.TabIndex = 1;
            this.gbox_than.TabStop = false;
            this.gbox_than.Text = "大小";
            // 
            // rad_big
            // 
            this.rad_big.AutoSize = true;
            this.rad_big.Checked = true;
            this.rad_big.Location = new System.Drawing.Point(76, 36);
            this.rad_big.Name = "rad_big";
            this.rad_big.Size = new System.Drawing.Size(51, 22);
            this.rad_big.TabIndex = 0;
            this.rad_big.TabStop = true;
            this.rad_big.Text = "大";
            this.rad_big.UseVisualStyleBackColor = true;
            // 
            // rad_small
            // 
            this.rad_small.AutoSize = true;
            this.rad_small.Location = new System.Drawing.Point(76, 88);
            this.rad_small.Name = "rad_small";
            this.rad_small.Size = new System.Drawing.Size(51, 22);
            this.rad_small.TabIndex = 0;
            this.rad_small.Text = "小";
            this.rad_small.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(70, 137);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(87, 45);
            this.btn_submit.TabIndex = 2;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_than
            // 
            this.btn_than.Location = new System.Drawing.Point(56, 137);
            this.btn_than.Name = "btn_than";
            this.btn_than.Size = new System.Drawing.Size(87, 45);
            this.btn_than.TabIndex = 2;
            this.btn_than.Text = "提交";
            this.btn_than.UseVisualStyleBackColor = true;
            this.btn_than.Click += new System.EventHandler(this.btn_than_Click);
            // 
            // Radio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 390);
            this.Controls.Add(this.gbox_than);
            this.Controls.Add(this.gbox_sex);
            this.Name = "Radio";
            this.Text = "Radio";
            this.gbox_sex.ResumeLayout(false);
            this.gbox_sex.PerformLayout();
            this.gbox_than.ResumeLayout(false);
            this.gbox_than.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_sex;
        private System.Windows.Forms.RadioButton rad_male;
        private System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.GroupBox gbox_than;
        private System.Windows.Forms.RadioButton rad_small;
        private System.Windows.Forms.RadioButton rad_big;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_than;
    }
}