namespace Library_System_Management
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdStaft = new System.Windows.Forms.RadioButton();
            this.rdTeacher = new System.Windows.Forms.RadioButton();
            this.rdStudent = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbMajor = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.btCheakIn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMember.Location = new System.Drawing.Point(364, 117);
            this.dataGridViewMember.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 62;
            this.dataGridViewMember.RowTemplate.Height = 33;
            this.dataGridViewMember.Size = new System.Drawing.Size(1089, 418);
            this.dataGridViewMember.TabIndex = 7;
            this.dataGridViewMember.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ชื่อ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "รหัสนักศึกษาหรือรหัสประจำตัวประชาชน";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "สาขา";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "สถานะ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "เวลาเข้า";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 300;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "เวลาออก";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 300;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdStaft);
            this.groupBox2.Controls.Add(this.rdTeacher);
            this.groupBox2.Controls.Add(this.rdStudent);
            this.groupBox2.Location = new System.Drawing.Point(21, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox2.Size = new System.Drawing.Size(308, 177);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Member";
            // 
            // rdStaft
            // 
            this.rdStaft.AutoSize = true;
            this.rdStaft.Location = new System.Drawing.Point(9, 115);
            this.rdStaft.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdStaft.Name = "rdStaft";
            this.rdStaft.Size = new System.Drawing.Size(91, 46);
            this.rdStaft.TabIndex = 6;
            this.rdStaft.TabStop = true;
            this.rdStaft.Text = "Staft";
            this.rdStaft.UseVisualStyleBackColor = true;
            // 
            // rdTeacher
            // 
            this.rdTeacher.AutoSize = true;
            this.rdTeacher.Location = new System.Drawing.Point(137, 59);
            this.rdTeacher.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdTeacher.Name = "rdTeacher";
            this.rdTeacher.Size = new System.Drawing.Size(123, 46);
            this.rdTeacher.TabIndex = 5;
            this.rdTeacher.TabStop = true;
            this.rdTeacher.Text = "Teacher";
            this.rdTeacher.UseVisualStyleBackColor = true;
            // 
            // rdStudent
            // 
            this.rdStudent.AutoSize = true;
            this.rdStudent.Location = new System.Drawing.Point(8, 59);
            this.rdStudent.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.rdStudent.Name = "rdStudent";
            this.rdStudent.Size = new System.Drawing.Size(123, 46);
            this.rdStudent.TabIndex = 4;
            this.rdStudent.TabStop = true;
            this.rdStudent.Text = "Student";
            this.rdStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbMajor);
            this.groupBox1.Controls.Add(this.tbID);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.groupBox1.Size = new System.Drawing.Size(336, 438);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profile";
            // 
            // tbMajor
            // 
            this.tbMajor.Location = new System.Drawing.Point(134, 176);
            this.tbMajor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbMajor.Name = "tbMajor";
            this.tbMajor.Size = new System.Drawing.Size(180, 48);
            this.tbMajor.TabIndex = 3;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(135, 114);
            this.tbID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(180, 48);
            this.tbID.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(135, 54);
            this.tbName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(180, 48);
            this.tbName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Major";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1226, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 42);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1094, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 42);
            this.label4.TabIndex = 8;
            this.label4.Text = "Time";
            // 
            // btCheckOut
            // 
            this.btCheckOut.Location = new System.Drawing.Point(560, 562);
            this.btCheckOut.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(135, 57);
            this.btCheckOut.TabIndex = 7;
            this.btCheckOut.Text = "CheakOut";
            this.btCheckOut.UseVisualStyleBackColor = true;
            this.btCheckOut.Click += new System.EventHandler(this.btCheckOut_Click);
            // 
            // btCheakIn
            // 
            this.btCheakIn.Location = new System.Drawing.Point(394, 562);
            this.btCheakIn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btCheakIn.Name = "btCheakIn";
            this.btCheakIn.Size = new System.Drawing.Size(135, 57);
            this.btCheakIn.TabIndex = 6;
            this.btCheakIn.Text = "CheakIn";
            this.btCheakIn.UseVisualStyleBackColor = true;
            this.btCheakIn.Click += new System.EventHandler(this.btCheakIn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1491, 56);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 46);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(179, 50);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(179, 50);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(732, 562);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(134, 57);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 42F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 640);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.btCheckOut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btCheakIn);
            this.Font = new System.Drawing.Font("TH Kodchasal", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form4";
            this.Text = "Library System Management";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
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

        private DataGridView dataGridViewMember;
        private GroupBox groupBox2;
        private RadioButton rdTeacher;
        private RadioButton rdStudent;
        private GroupBox groupBox1;
        private Button btCheckOut;
        private Button btCheakIn;
        private TextBox tbMajor;
        private TextBox tbID;
        private TextBox tbName;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Label label4;
        public System.Windows.Forms.Timer timer1;
        private Label label5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private RadioButton rdStaft;
        private Button btCancel;
    }
}