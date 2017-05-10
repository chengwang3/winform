namespace winform
{
    partial class CheckBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckBox));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_food = new System.Windows.Forms.GroupBox();
            this.ckb_fish = new System.Windows.Forms.CheckBox();
            this.ckb_mice = new System.Windows.Forms.CheckBox();
            this.ckb_xiangchang = new System.Windows.Forms.CheckBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbox_food.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(154, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(353, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(168, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "图片";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbox_food
            // 
            this.gbox_food.Controls.Add(this.ckb_xiangchang);
            this.gbox_food.Controls.Add(this.ckb_mice);
            this.gbox_food.Controls.Add(this.ckb_fish);
            this.gbox_food.Location = new System.Drawing.Point(138, 152);
            this.gbox_food.Name = "gbox_food";
            this.gbox_food.Size = new System.Drawing.Size(381, 100);
            this.gbox_food.TabIndex = 2;
            this.gbox_food.TabStop = false;
            this.gbox_food.Text = "喜欢的食物";
            // 
            // ckb_fish
            // 
            this.ckb_fish.AutoSize = true;
            this.ckb_fish.Location = new System.Drawing.Point(16, 42);
            this.ckb_fish.Name = "ckb_fish";
            this.ckb_fish.Size = new System.Drawing.Size(52, 22);
            this.ckb_fish.TabIndex = 0;
            this.ckb_fish.Text = "鱼";
            this.ckb_fish.UseVisualStyleBackColor = true;
            // 
            // ckb_mice
            // 
            this.ckb_mice.AutoSize = true;
            this.ckb_mice.Location = new System.Drawing.Point(260, 42);
            this.ckb_mice.Name = "ckb_mice";
            this.ckb_mice.Size = new System.Drawing.Size(70, 22);
            this.ckb_mice.TabIndex = 0;
            this.ckb_mice.Text = "小鼠";
            this.ckb_mice.UseVisualStyleBackColor = true;
            // 
            // ckb_xiangchang
            // 
            this.ckb_xiangchang.AutoSize = true;
            this.ckb_xiangchang.Location = new System.Drawing.Point(137, 42);
            this.ckb_xiangchang.Name = "ckb_xiangchang";
            this.ckb_xiangchang.Size = new System.Drawing.Size(70, 22);
            this.ckb_xiangchang.TabIndex = 0;
            this.ckb_xiangchang.Text = "香肠";
            this.ckb_xiangchang.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(261, 269);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(123, 34);
            this.btn_submit.TabIndex = 3;
            this.btn_submit.Text = "提交";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(138, 314);
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(381, 28);
            this.txt_show.TabIndex = 4;
            // 
            // CheckRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 354);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.gbox_food);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CheckRadio";
            this.Text = "CheckRadio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbox_food.ResumeLayout(false);
            this.gbox_food.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_food;
        private System.Windows.Forms.CheckBox ckb_xiangchang;
        private System.Windows.Forms.CheckBox ckb_mice;
        private System.Windows.Forms.CheckBox ckb_fish;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.TextBox txt_show;
    }
}