namespace Library_System_Management
{
    partial class Form2
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btRegister = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btCancel = new System.Windows.Forms.Button();
            this.tbUsename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdStaft = new System.Windows.Forms.RadioButton();
            this.rdTeacher = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(175, 118);
            this.tbID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(242, 48);
            this.tbID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 42);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Card";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(175, 55);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(242, 48);
            this.tbName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 42);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // btRegister
            // 
            this.btRegister.Location = new System.Drawing.Point(229, 457);
            this.btRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(134, 57);
            this.btRegister.TabIndex = 8;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = true;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(446, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(805, 838);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "รหัสประจำตัวประชาชน";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "สถานะ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Usename";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Password";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(47, 457);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(134, 57);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // tbUsename
            // 
            this.tbUsename.Location = new System.Drawing.Point(148, 37);
            this.tbUsename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbUsename.Name = "tbUsename";
            this.tbUsename.Size = new System.Drawing.Size(242, 48);
            this.tbUsename.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 42);
            this.label3.TabIndex = 10;
            this.label3.Text = "Usename";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 105);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 42);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(148, 95);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(242, 48);
            this.tbPassword.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdStaft);
            this.groupBox2.Controls.Add(this.rdTeacher);
            this.groupBox2.Controls.Add(this.rdStudent);
            this.groupBox2.Location = new System.Drawing.Point(35, 176);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(382, 123);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member";
            // 
            // rdStaft
            // 
            this.rdStaft.AutoSize = true;
            this.rdStaft.Location = new System.Drawing.Point(266, 61);
            this.rdStaft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdStaft.Name = "rdStaft";
            this.rdStaft.Size = new System.Drawing.Size(91, 46);
            this.rdStaft.TabIndex = 5;
            this.rdStaft.TabStop = true;
            this.rdStaft.Text = "Staft";
            this.rdStaft.UseVisualStyleBackColor = true;
            // 
            // rdTeacher
            // 
            this.rdTeacher.AutoSize = true;
            this.rdTeacher.Location = new System.Drawing.Point(137, 61);
            this.rdTeacher.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdTeacher.Name = "rdTeacher";
            this.rdTeacher.Size = new System.Drawing.Size(123, 46);
            this.rdTeacher.TabIndex = 4;
            this.rdTeacher.TabStop = true;
            this.rdTeacher.Text = "Teacher";
            this.rdTeacher.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(8, 61);
            this.rdStudent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(123, 46);
            this.rdStudent.TabIndex = 3;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Student";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbUsename);
            this.groupBox1.Controls.Add(this.tbPassword);
            this.groupBox1.Location = new System.Drawing.Point(24, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 150);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "For Staft";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1307, 50);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 46);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 50);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1307, 924);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form3";
            this.Text = "ลงทะเบียน";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox tbID;
        private Label label2;
        private TextBox tbName;
        private Label label1;
        private Button btRegister;
        private DataGridView dataGridView1;
        private Button btCancel;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox tbUsename;
        private Label label3;
        private Label label4;
        private TextBox tbPassword;
        private GroupBox groupBox2;
        private RadioButton rdStaft;
        private RadioButton rdTeacher;
        private RadioButton rdStudent;
        private GroupBox groupBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}