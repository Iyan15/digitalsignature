namespace RSA
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
            this.encrypt_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chiper_encrypt_rtb = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.plain_decrypt_rtb = new System.Windows.Forms.RichTextBox();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ascii_rtb = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.p_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.private_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.e_txt = new System.Windows.Forms.TextBox();
            this.public_txt = new System.Windows.Forms.TextBox();
            this.q_txt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.M_txt = new System.Windows.Forms.TextBox();
            this.N_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.d_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // encrypt_btn
            // 
            this.encrypt_btn.Location = new System.Drawing.Point(197, 39);
            this.encrypt_btn.Name = "encrypt_btn";
            this.encrypt_btn.Size = new System.Drawing.Size(67, 218);
            this.encrypt_btn.TabIndex = 4;
            this.encrypt_btn.Text = "Encrypt";
            this.encrypt_btn.UseVisualStyleBackColor = true;
            this.encrypt_btn.Click += new System.EventHandler(this.encrypt_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text";
            // 
            // chiper_encrypt_rtb
            // 
            this.chiper_encrypt_rtb.Location = new System.Drawing.Point(272, 39);
            this.chiper_encrypt_rtb.Name = "chiper_encrypt_rtb";
            this.chiper_encrypt_rtb.Size = new System.Drawing.Size(185, 218);
            this.chiper_encrypt_rtb.TabIndex = 6;
            this.chiper_encrypt_rtb.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chiper Text";
            // 
            // plain_decrypt_rtb
            // 
            this.plain_decrypt_rtb.Location = new System.Drawing.Point(536, 39);
            this.plain_decrypt_rtb.Name = "plain_decrypt_rtb";
            this.plain_decrypt_rtb.ReadOnly = true;
            this.plain_decrypt_rtb.Size = new System.Drawing.Size(185, 218);
            this.plain_decrypt_rtb.TabIndex = 9;
            this.plain_decrypt_rtb.Text = "";
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(463, 39);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(67, 218);
            this.decrypt_btn.TabIndex = 7;
            this.decrypt_btn.Text = "Decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Plain Text";
            // 
            // ascii_rtb
            // 
            this.ascii_rtb.Location = new System.Drawing.Point(6, 219);
            this.ascii_rtb.Name = "ascii_rtb";
            this.ascii_rtb.ReadOnly = true;
            this.ascii_rtb.Size = new System.Drawing.Size(185, 38);
            this.ascii_rtb.TabIndex = 3;
            this.ascii_rtb.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 203);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "ASCII Text";
            // 
            // p_txt
            // 
            this.p_txt.Location = new System.Drawing.Point(169, 23);
            this.p_txt.Name = "p_txt";
            this.p_txt.ReadOnly = true;
            this.p_txt.Size = new System.Drawing.Size(291, 20);
            this.p_txt.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "p :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.private_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.e_txt);
            this.groupBox1.Controls.Add(this.public_txt);
            this.groupBox1.Controls.Add(this.q_txt);
            this.groupBox1.Controls.Add(this.p_txt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.M_txt);
            this.groupBox1.Controls.Add(this.N_txt);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.d_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(278, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Private Key :";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(9, 19);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(135, 52);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // private_txt
            // 
            this.private_txt.Location = new System.Drawing.Point(345, 106);
            this.private_txt.Name = "private_txt";
            this.private_txt.ReadOnly = true;
            this.private_txt.Size = new System.Drawing.Size(376, 20);
            this.private_txt.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "q :";
            // 
            // e_txt
            // 
            this.e_txt.Location = new System.Drawing.Point(26, 81);
            this.e_txt.Name = "e_txt";
            this.e_txt.ReadOnly = true;
            this.e_txt.Size = new System.Drawing.Size(242, 20);
            this.e_txt.TabIndex = 10;
            // 
            // public_txt
            // 
            this.public_txt.Location = new System.Drawing.Point(345, 80);
            this.public_txt.Name = "public_txt";
            this.public_txt.ReadOnly = true;
            this.public_txt.Size = new System.Drawing.Size(376, 20);
            this.public_txt.TabIndex = 14;
            // 
            // q_txt
            // 
            this.q_txt.Location = new System.Drawing.Point(169, 50);
            this.q_txt.Name = "q_txt";
            this.q_txt.ReadOnly = true;
            this.q_txt.Size = new System.Drawing.Size(291, 20);
            this.q_txt.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "E :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Public Key :";
            // 
            // M_txt
            // 
            this.M_txt.Location = new System.Drawing.Point(494, 23);
            this.M_txt.Name = "M_txt";
            this.M_txt.ReadOnly = true;
            this.M_txt.Size = new System.Drawing.Size(227, 20);
            this.M_txt.TabIndex = 6;
            // 
            // N_txt
            // 
            this.N_txt.Location = new System.Drawing.Point(494, 50);
            this.N_txt.Name = "N_txt";
            this.N_txt.ReadOnly = true;
            this.N_txt.Size = new System.Drawing.Size(227, 20);
            this.N_txt.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(472, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "M :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "D :";
            // 
            // d_txt
            // 
            this.d_txt.Location = new System.Drawing.Point(26, 107);
            this.d_txt.Name = "d_txt";
            this.d_txt.ReadOnly = true;
            this.d_txt.Size = new System.Drawing.Size(242, 20);
            this.d_txt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "N :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.plain_decrypt_rtb);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ascii_rtb);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chiper_encrypt_rtb);
            this.groupBox2.Controls.Add(this.decrypt_btn);
            this.groupBox2.Controls.Add(this.encrypt_btn);
            this.groupBox2.Location = new System.Drawing.Point(12, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Encryption/Decryption";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Choose File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 422);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button encrypt_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox chiper_encrypt_rtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox plain_decrypt_rtb;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ascii_rtb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox p_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox private_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.TextBox public_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox e_txt;
        private System.Windows.Forms.TextBox q_txt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox M_txt;
        private System.Windows.Forms.TextBox N_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox d_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

