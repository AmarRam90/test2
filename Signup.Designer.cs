namespace test2
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.panel1 = new System.Windows.Forms.Panel();
            this.signup_close = new System.Windows.Forms.Label();
            this.signup_loginHere = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_showPass = new System.Windows.Forms.CheckBox();
            this.signup_btn = new System.Windows.Forms.Button();
            this.signup_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.signup_confirmPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.signup_confirmPassword);
            this.panel1.Controls.Add(this.signup_close);
            this.panel1.Controls.Add(this.signup_loginHere);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.signup_showPass);
            this.panel1.Controls.Add(this.signup_password);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.signup_btn);
            this.panel1.Controls.Add(this.signup_email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.signup_username);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-6, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 402);
            this.panel1.TabIndex = 1;
            // 
            // signup_close
            // 
            this.signup_close.AutoSize = true;
            this.signup_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_close.Location = new System.Drawing.Point(594, 18);
            this.signup_close.Name = "signup_close";
            this.signup_close.Size = new System.Drawing.Size(27, 26);
            this.signup_close.TabIndex = 11;
            this.signup_close.Text = "X";
            this.signup_close.Click += new System.EventHandler(this.signup_close_Click);
            // 
            // signup_loginHere
            // 
            this.signup_loginHere.AutoSize = true;
            this.signup_loginHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginHere.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginHere.ForeColor = System.Drawing.Color.DimGray;
            this.signup_loginHere.Location = new System.Drawing.Point(513, 369);
            this.signup_loginHere.Name = "signup_loginHere";
            this.signup_loginHere.Size = new System.Drawing.Size(97, 20);
            this.signup_loginHere.TabIndex = 10;
            this.signup_loginHere.Text = "Login Here";
            this.signup_loginHere.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(298, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Already have an account?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // signup_showPass
            // 
            this.signup_showPass.AutoSize = true;
            this.signup_showPass.BackColor = System.Drawing.Color.Transparent;
            this.signup_showPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showPass.ForeColor = System.Drawing.Color.Gray;
            this.signup_showPass.Location = new System.Drawing.Point(442, 319);
            this.signup_showPass.Name = "signup_showPass";
            this.signup_showPass.Size = new System.Drawing.Size(179, 29);
            this.signup_showPass.TabIndex = 8;
            this.signup_showPass.Text = "Show Password";
            this.signup_showPass.UseVisualStyleBackColor = false;
            this.signup_showPass.CheckedChanged += new System.EventHandler(this.signup_showPass_CheckedChanged);
            // 
            // signup_btn
            // 
            this.signup_btn.BackColor = System.Drawing.Color.Aqua;
            this.signup_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_btn.FlatAppearance.BorderSize = 0;
            this.signup_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_btn.ForeColor = System.Drawing.Color.White;
            this.signup_btn.Location = new System.Drawing.Point(316, 319);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(100, 35);
            this.signup_btn.TabIndex = 7;
            this.signup_btn.Text = "SignUp";
            this.signup_btn.UseVisualStyleBackColor = false;
            this.signup_btn.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_email
            // 
            this.signup_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_email.Location = new System.Drawing.Point(316, 157);
            this.signup_email.Name = "signup_email";
            this.signup_email.Size = new System.Drawing.Size(305, 30);
            this.signup_email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email Address:";
            // 
            // signup_username
            // 
            this.signup_username.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(316, 92);
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(305, 30);
            this.signup_username.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(311, 27);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(163, 28);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Get Started";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
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
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Location = new System.Drawing.Point(24, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 156);
            this.panel3.TabIndex = 0;
            // 
            // signup_confirmPassword
            // 
            this.signup_confirmPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_confirmPassword.Location = new System.Drawing.Point(316, 274);
            this.signup_confirmPassword.Name = "signup_confirmPassword";
            this.signup_confirmPassword.PasswordChar = '*';
            this.signup_confirmPassword.Size = new System.Drawing.Size(305, 30);
            this.signup_confirmPassword.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Confirm Password:";
            // 
            // signup_password
            // 
            this.signup_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(316, 209);
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(305, 30);
            this.signup_password.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(312, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Password:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 394);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label signup_close;
        private System.Windows.Forms.Label signup_loginHere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox signup_showPass;
        private System.Windows.Forms.Button signup_btn;
        private System.Windows.Forms.TextBox signup_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox signup_confirmPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label9;
    }
}