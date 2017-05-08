namespace winform
{
    partial class LearnADO
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_depart = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_work = new System.Windows.Forms.DateTimePicker();
            this.radioButton_noparty = new System.Windows.Forms.RadioButton();
            this.radioButton_party = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_delet = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(768, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_depart);
            this.groupBox1.Controls.Add(this.dateTimePicker_work);
            this.groupBox1.Controls.Add(this.dateTimePicker_birthday);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(51, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "员工信息";
            // 
            // comboBox_depart
            // 
            this.comboBox_depart.FormattingEnabled = true;
            this.comboBox_depart.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox_depart.Location = new System.Drawing.Point(91, 217);
            this.comboBox_depart.Name = "comboBox_depart";
            this.comboBox_depart.Size = new System.Drawing.Size(121, 20);
            this.comboBox_depart.TabIndex = 7;
            // 
            // dateTimePicker_work
            // 
            this.dateTimePicker_work.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_work.Location = new System.Drawing.Point(114, 160);
            this.dateTimePicker_work.Name = "dateTimePicker_work";
            this.dateTimePicker_work.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_work.TabIndex = 6;
            // 
            // radioButton_noparty
            // 
            this.radioButton_noparty.AutoSize = true;
            this.radioButton_noparty.Location = new System.Drawing.Point(102, 7);
            this.radioButton_noparty.Name = "radioButton_noparty";
            this.radioButton_noparty.Size = new System.Drawing.Size(35, 16);
            this.radioButton_noparty.TabIndex = 5;
            this.radioButton_noparty.TabStop = true;
            this.radioButton_noparty.Text = "否";
            this.radioButton_noparty.UseVisualStyleBackColor = true;
            // 
            // radioButton_party
            // 
            this.radioButton_party.AutoSize = true;
            this.radioButton_party.Location = new System.Drawing.Point(23, 7);
            this.radioButton_party.Name = "radioButton_party";
            this.radioButton_party.Size = new System.Drawing.Size(35, 16);
            this.radioButton_party.TabIndex = 4;
            this.radioButton_party.TabStop = true;
            this.radioButton_party.Text = "是";
            this.radioButton_party.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(91, 89);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker_birthday.TabIndex = 3;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(23, 1);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(35, 16);
            this.radioButton_male.TabIndex = 2;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "男";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(102, 1);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(35, 16);
            this.radioButton_female.TabIndex = 2;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "女";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(91, 38);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(175, 21);
            this.textBox_name.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "生日：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "部门：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "参加工作时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "党员";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "性别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_delet);
            this.groupBox2.Controls.Add(this.button_save);
            this.groupBox2.Controls.Add(this.button_add);
            this.groupBox2.Location = new System.Drawing.Point(459, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // button_delet
            // 
            this.button_delet.Location = new System.Drawing.Point(64, 160);
            this.button_delet.Name = "button_delet";
            this.button_delet.Size = new System.Drawing.Size(92, 23);
            this.button_delet.TabIndex = 0;
            this.button_delet.Text = "删除";
            this.button_delet.UseVisualStyleBackColor = true;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(64, 111);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 23);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "修改保存";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(64, 55);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(92, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "添加";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "生日";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "党员";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "参加工作时间";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "部门";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton_party);
            this.panel1.Controls.Add(this.radioButton_noparty);
            this.panel1.Location = new System.Drawing.Point(91, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 34);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton_male);
            this.panel2.Controls.Add(this.radioButton_female);
            this.panel2.Location = new System.Drawing.Point(91, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 19);
            this.panel2.TabIndex = 9;
            // 
            // LearnADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LearnADO";
            this.Load += new System.EventHandler(this.LearnADO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton_noparty;
        private System.Windows.Forms.RadioButton radioButton_party;
        private System.Windows.Forms.ComboBox comboBox_depart;
        private System.Windows.Forms.DateTimePicker dateTimePicker_work;
        private System.Windows.Forms.Button button_delet;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

