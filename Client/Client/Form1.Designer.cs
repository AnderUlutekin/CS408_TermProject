﻿namespace client
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
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_playagain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(293, 455);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(116, 22);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(293, 493);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(116, 22);
            this.textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(316, 542);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(93, 27);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(578, 22);
            this.logs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logs.Name = "logs";
            this.logs.ReadOnly = true;
            this.logs.Size = new System.Drawing.Size(372, 596);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(15, 490);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(129, 22);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Message:";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(15, 526);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(87, 32);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_playagain
            // 
            this.button_playagain.Enabled = false;
            this.button_playagain.Location = new System.Drawing.Point(15, 571);
            this.button_playagain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_playagain.Name = "button_playagain";
            this.button_playagain.Size = new System.Drawing.Size(87, 32);
            this.button_playagain.TabIndex = 9;
            this.button_playagain.Text = "play again";
            this.button_playagain.UseVisualStyleBackColor = true;
            this.button_playagain.Click += new System.EventHandler(this.button_playagain_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 629);
            this.Controls.Add(this.button_playagain);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_playagain;
    }
}

