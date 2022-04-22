namespace Library_System_Management
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStaftRegis = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(143, 62);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(251, 48);
            this.textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(143, 161);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(251, 48);
            this.textBoxPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 171);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(187, 248);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(128, 64);
            this.buttonLogin.TabIndex = 3;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(48, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.groupBox1.Size = new System.Drawing.Size(421, 328);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login For Staft";
            // 
            // buttonStaftRegis
            // 
            this.buttonStaftRegis.Location = new System.Drawing.Point(229, 379);
            this.buttonStaftRegis.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStaftRegis.Name = "buttonStaftRegis";
            this.buttonStaftRegis.Size = new System.Drawing.Size(134, 57);
            this.buttonStaftRegis.TabIndex = 4;
            this.buttonStaftRegis.Text = "Click";
            this.buttonStaftRegis.UseVisualStyleBackColor = true;
            this.buttonStaftRegis.Click += new System.EventHandler(this.buttonStaftRegis_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 42);
            this.label5.TabIndex = 10;
            this.label5.Text = "ลงทะเบียน";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 465);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonStaftRegis);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "Form1";
            this.Text = "Library System Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private GroupBox groupBox1;
        private Button buttonStaftRegis;
        private Label label5;
    }
}