namespace IdeabizDemo
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.txtCONSUMERKEY = new System.Windows.Forms.TextBox();
            this.txtCONSUMERSECRET = new System.Windows.Forms.TextBox();
            this.txtACCESSTOKEN = new System.Windows.Forms.TextBox();
            this.txtREFRESHTOKEN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTOKENURL = new System.Windows.Forms.TextBox();
            this.txtMSISDN = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(682, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "SMS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 215);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(785, 152);
            this.textBox1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(682, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "LBS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtCONSUMERKEY
            // 
            this.txtCONSUMERKEY.Location = new System.Drawing.Point(172, 21);
            this.txtCONSUMERKEY.Name = "txtCONSUMERKEY";
            this.txtCONSUMERKEY.Size = new System.Drawing.Size(204, 20);
            this.txtCONSUMERKEY.TabIndex = 4;
            // 
            // txtCONSUMERSECRET
            // 
            this.txtCONSUMERSECRET.Location = new System.Drawing.Point(172, 53);
            this.txtCONSUMERSECRET.Name = "txtCONSUMERSECRET";
            this.txtCONSUMERSECRET.Size = new System.Drawing.Size(204, 20);
            this.txtCONSUMERSECRET.TabIndex = 5;
            // 
            // txtACCESSTOKEN
            // 
            this.txtACCESSTOKEN.Location = new System.Drawing.Point(172, 84);
            this.txtACCESSTOKEN.Name = "txtACCESSTOKEN";
            this.txtACCESSTOKEN.Size = new System.Drawing.Size(204, 20);
            this.txtACCESSTOKEN.TabIndex = 6;
            // 
            // txtREFRESHTOKEN
            // 
            this.txtREFRESHTOKEN.Location = new System.Drawing.Point(172, 119);
            this.txtREFRESHTOKEN.Name = "txtREFRESHTOKEN";
            this.txtREFRESHTOKEN.Size = new System.Drawing.Size(204, 20);
            this.txtREFRESHTOKEN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "CONSUMER KEY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CONSUMER SECRET";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ACCESS TOKEN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "REFRESH TOKEN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "TOKEN URL";
            // 
            // txtTOKENURL
            // 
            this.txtTOKENURL.Location = new System.Drawing.Point(172, 160);
            this.txtTOKENURL.Name = "txtTOKENURL";
            this.txtTOKENURL.Size = new System.Drawing.Size(204, 20);
            this.txtTOKENURL.TabIndex = 12;
            // 
            // txtMSISDN
            // 
            this.txtMSISDN.Location = new System.Drawing.Point(513, 24);
            this.txtMSISDN.Name = "txtMSISDN";
            this.txtMSISDN.Size = new System.Drawing.Size(140, 20);
            this.txtMSISDN.TabIndex = 14;
            this.txtMSISDN.Text = "94777123456";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(513, 63);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(140, 88);
            this.txtMessage.TabIndex = 15;
            this.txtMessage.Text = "Test Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(414, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "MSISDN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(414, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "MSG";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 186);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 391);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.txtMSISDN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTOKENURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtREFRESHTOKEN);
            this.Controls.Add(this.txtACCESSTOKEN);
            this.Controls.Add(this.txtCONSUMERSECRET);
            this.Controls.Add(this.txtCONSUMERKEY);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtCONSUMERKEY;
        private System.Windows.Forms.TextBox txtCONSUMERSECRET;
        private System.Windows.Forms.TextBox txtACCESSTOKEN;
        private System.Windows.Forms.TextBox txtREFRESHTOKEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTOKENURL;
        private System.Windows.Forms.TextBox txtMSISDN;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
    }
}

