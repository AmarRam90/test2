namespace test2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.login_showPass = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.login_registerHere = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.login_close = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.login_close);
            this.panel1.Controls.Add(this.login_registerHere);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.login_showPass);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.login_password);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.login_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 402);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(56)))), ((int)(((byte)(137)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 409);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(311, 37);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(202, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Welcome Back!";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // login_username
            // 
            this.login_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username.Location = new System.Drawing.Point(316, 112);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(305, 30);
            this.login_username.TabIndex = 4;
            // 
            // login_password
            // 
            this.login_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password.Location = new System.Drawing.Point(316, 177);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(305, 30);
            this.login_password.TabIndex = 6;
            this.login_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Aqua;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(316, 262);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(100, 35);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // login_showPass
            // 
            this.login_showPass.AutoSize = true;
            this.login_showPass.BackColor = System.Drawing.Color.Transparent;
            this.login_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_showPass.ForeColor = System.Drawing.Color.Gray;
            this.login_showPass.Location = new System.Drawing.Point(442, 231);
            this.login_showPass.Name = "login_showPass";
            this.login_showPass.Size = new System.Drawing.Size(179, 29);
            this.login_showPass.TabIndex = 8;
            this.login_showPass.Text = "Show Password";
            this.login_showPass.UseVisualStyleBackColor = false;
            this.login_showPass.CheckedChanged += new System.EventHandler(this.login_showPass_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(298, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Don\'t have an account?";
            // 
            // login_registerHere
            // 
            this.login_registerHere.AutoSize = true;
            this.login_registerHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_registerHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_registerHere.ForeColor = System.Drawing.Color.DimGray;
            this.login_registerHere.Location = new System.Drawing.Point(499, 352);
            this.login_registerHere.Name = "login_registerHere";
            this.login_registerHere.Size = new System.Drawing.Size(121, 20);
            this.login_registerHere.TabIndex = 10;
            this.login_registerHere.Text = "Register Now!";
            this.login_registerHere.Click += new System.EventHandler(this.login_registerHere_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(24, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 156);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 55);
            this.label6.TabIndex = 1;
            this.label6.Text = "ٱلسَّلَامُ عَلَيْكُمْ";
            // 
            // login_close
            // 
            this.login_close.AutoSize = true;
            this.login_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_close.Location = new System.Drawing.Point(594, 18);
            this.login_close.Name = "login_close";
            this.login_close.Size = new System.Drawing.Size(27, 26);
            this.login_close.TabIndex = 11;
            this.login_close.Text = "X";
            this.login_close.Click += new System.EventHandler(this.login_close_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.CheckBox login_showPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label login_registerHere;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label login_close;
    }
}

