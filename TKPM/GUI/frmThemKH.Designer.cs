﻿namespace GUI
{
    partial class frmThemKH
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
            this.label12 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TenKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.txt_DayBirth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_monthBirth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_yearBirth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(7, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Ngày sinh:";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DiaChi.Location = new System.Drawing.Point(82, 222);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(257, 22);
            this.txt_DiaChi.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Địa chỉ:";
            // 
            // txt_CMND
            // 
            this.txt_CMND.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_CMND.Location = new System.Drawing.Point(82, 168);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(139, 22);
            this.txt_CMND.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(19, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 3;
            this.label10.Text = "CMND:";
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_TenKH.Location = new System.Drawing.Point(82, 64);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(212, 22);
            this.txt_TenKH.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Họ Tên:";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(90, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "THÊM KHÁCH HÀNG";
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.Chartreuse;
            this.btn_XacNhan.FlatAppearance.BorderSize = 0;
            this.btn_XacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_XacNhan.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_XacNhan.Location = new System.Drawing.Point(90, 265);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(84, 26);
            this.btn_XacNhan.TabIndex = 8;
            this.btn_XacNhan.Text = "Xác Nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Exit.Location = new System.Drawing.Point(180, 265);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 26);
            this.btn_Exit.TabIndex = 9;
            this.btn_Exit.Text = "Hủy";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // txt_DayBirth
            // 
            this.txt_DayBirth.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DayBirth.Location = new System.Drawing.Point(82, 119);
            this.txt_DayBirth.Name = "txt_DayBirth";
            this.txt_DayBirth.Size = new System.Drawing.Size(46, 22);
            this.txt_DayBirth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "/";
            // 
            // txt_monthBirth
            // 
            this.txt_monthBirth.Location = new System.Drawing.Point(156, 119);
            this.txt_monthBirth.Name = "txt_monthBirth";
            this.txt_monthBirth.Size = new System.Drawing.Size(43, 23);
            this.txt_monthBirth.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(205, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "/";
            // 
            // txt_yearBirth
            // 
            this.txt_yearBirth.Location = new System.Drawing.Point(227, 121);
            this.txt_yearBirth.Name = "txt_yearBirth";
            this.txt_yearBirth.Size = new System.Drawing.Size(67, 23);
            this.txt_yearBirth.TabIndex = 5;
            // 
            // frmThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(366, 297);
            this.Controls.Add(this.txt_yearBirth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_monthBirth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DayBirth);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_CMND);
            this.Name = "frmThemKH";
            this.Text = "Thông tin Khách Hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label12;
        private TextBox txt_DiaChi;
        private Label label11;
        private TextBox txt_CMND;
        private Label label10;
        private TextBox txt_TenKH;
        private Label label7;
        private Label label1;
        private Button btn_XacNhan;
        private Button btn_Exit;
        private TextBox txt_DayBirth;
        private Label label2;
        private TextBox txt_monthBirth;
        private Label label3;
        private TextBox txt_yearBirth;
    }
}