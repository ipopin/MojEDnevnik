﻿
namespace EDnevnik
{
    partial class logovanje
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
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(62, 40);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(231, 20);
            this.txt_name.TabIndex = 0;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(62, 66);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(194, 20);
            this.txt_pass.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 3;
            this.lbl_name.Text = "E-mail";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Location = new System.Drawing.Point(12, 69);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(44, 13);
            this.lbl_pass.TabIndex = 4;
            this.lbl_pass.Text = "Lozinka";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(78, 123);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(90, 43);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "Uloguh se";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // logovanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(492, 327);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_name);
            this.Name = "logovanje";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Button btn_ok;
    }
}