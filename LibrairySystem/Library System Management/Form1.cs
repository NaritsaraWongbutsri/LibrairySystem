namespace Library_System_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != ("naritsara");
            {
                MessageBox.Show("Usename ไม่ถูกต้อง");
            }
            if (textBoxPassword.Text != "Naritsara271245")
            {
                MessageBox.Show("Password ไม่ถูกต้อง");
            }
            if (textBoxUsername.Text == "naritsara" && textBoxPassword.Text == "Naritsara271245")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }          
        }

        private void buttonStaftRegis_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}