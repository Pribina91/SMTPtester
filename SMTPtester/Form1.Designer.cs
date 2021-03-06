﻿namespace SMTPtester
{
    partial class Form1
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
            this.server = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isSSLEnabled = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.receiver = new System.Windows.Forms.TextBox();
            this.consolebox = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.hasAttachment = new System.Windows.Forms.CheckBox();
            this.txtFilepath = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP server";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "useSSL";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(133, 29);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(195, 20);
            this.server.TabIndex = 1;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(133, 116);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(195, 20);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.password.Location = new System.Drawing.Point(133, 144);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(195, 20);
            this.password.TabIndex = 4;
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(133, 171);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(195, 20);
            this.port.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sender
            // 
            this.sender.Location = new System.Drawing.Point(133, 55);
            this.sender.Name = "sender";
            this.sender.Size = new System.Drawing.Size(195, 20);
            this.sender.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "sender";
            // 
            // isSSLEnabled
            // 
            this.isSSLEnabled.AutoSize = true;
            this.isSSLEnabled.Location = new System.Drawing.Point(133, 202);
            this.isSSLEnabled.Name = "isSSLEnabled";
            this.isSSLEnabled.Size = new System.Drawing.Size(89, 19);
            this.isSSLEnabled.TabIndex = 6;
            this.isSSLEnabled.Text = "checkBox1";
            this.isSSLEnabled.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "to";
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(133, 240);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(195, 20);
            this.receiver.TabIndex = 7;
            // 
            // consolebox
            // 
            this.consolebox.Location = new System.Drawing.Point(334, 29);
            this.consolebox.Multiline = true;
            this.consolebox.Name = "consolebox";
            this.consolebox.Size = new System.Drawing.Size(320, 332);
            this.consolebox.TabIndex = 12;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(578, 368);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // hasAttachment
            // 
            this.hasAttachment.AccessibleName = "hasAttachment";
            this.hasAttachment.AutoSize = true;
            this.hasAttachment.Location = new System.Drawing.Point(40, 267);
            this.hasAttachment.Name = "hasAttachment";
            this.hasAttachment.Size = new System.Drawing.Size(115, 19);
            this.hasAttachment.TabIndex = 14;
            this.hasAttachment.Text = "Has attachment";
            this.hasAttachment.UseVisualStyleBackColor = true;
            this.hasAttachment.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtFilepath
            // 
            this.txtFilepath.Location = new System.Drawing.Point(133, 292);
            this.txtFilepath.Name = "txtFilepath";
            this.txtFilepath.Size = new System.Drawing.Size(195, 20);
            this.txtFilepath.TabIndex = 15;
            this.txtFilepath.TextChanged += new System.EventHandler(this.txtFilepath_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(133, 318);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(195, 20);
            this.txtName.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Filepath";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 318);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 500);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtFilepath);
            this.Controls.Add(this.hasAttachment);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.consolebox);
            this.Controls.Add(this.receiver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.isSSLEnabled);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.port);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox isSSLEnabled;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.TextBox consolebox;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.CheckBox hasAttachment;
        private System.Windows.Forms.TextBox txtFilepath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

