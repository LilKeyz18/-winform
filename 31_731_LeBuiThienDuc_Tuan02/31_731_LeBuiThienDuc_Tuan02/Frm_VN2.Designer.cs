﻿
namespace _31_731_LeBuiThienDuc_Tuan02
{
    partial class Frm_VN2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RichTxtKq = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(120, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bạn Vui Lòng Chọn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập C";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rd2);
            this.panel1.Controls.Add(this.rd1);
            this.panel1.Location = new System.Drawing.Point(59, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 100);
            this.panel1.TabIndex = 1;
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd1.Location = new System.Drawing.Point(15, 14);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(257, 29);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Phương Trình Bậc Nhất";
            this.rd1.UseVisualStyleBackColor = true;
            this.rd1.CheckedChanged += new System.EventHandler(this.rd1_CheckedChanged);
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd2.Location = new System.Drawing.Point(15, 60);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(224, 29);
            this.rd2.TabIndex = 0;
            this.rd2.TabStop = true;
            this.rd2.Text = "Phương Trình Bậc 2";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.rd2_CheckedChanged);
            // 
            // btnGiai
            // 
            this.btnGiai.Enabled = false;
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(377, 206);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(96, 51);
            this.btnGiai.TabIndex = 1;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.TextChanged += new System.EventHandler(this.btnGiai_TextChanged);
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(377, 274);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 60);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(149, 206);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(182, 22);
            this.txta.TabIndex = 2;
            this.txta.TextChanged += new System.EventHandler(this.txta_TextChanged);
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(149, 264);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(182, 22);
            this.txtb.TabIndex = 2;
            this.txtb.TextChanged += new System.EventHandler(this.txtb_TextChanged);
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(149, 312);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(182, 22);
            this.txtc.TabIndex = 2;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            this.txtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kết Quả";
            // 
            // RichTxtKq
            // 
            this.RichTxtKq.Enabled = false;
            this.RichTxtKq.Location = new System.Drawing.Point(139, 363);
            this.RichTxtKq.Name = "RichTxtKq";
            this.RichTxtKq.Size = new System.Drawing.Size(383, 75);
            this.RichTxtKq.TabIndex = 3;
            this.RichTxtKq.Text = "";
            // 
            // Frm_VN2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.RichTxtKq);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_VN2";
            this.Text = "Frm_VN2";
            this.Load += new System.EventHandler(this.Frm_VN2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox RichTxtKq;
    }
}