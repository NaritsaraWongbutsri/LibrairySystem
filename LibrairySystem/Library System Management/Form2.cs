using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = tbName.Text;
            dataGridView1.Rows[n].Cells[1].Value = tbID.Text;

            if(rdStudent.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdStudent.Text;
                dataGridView1.Rows[n].Cells[3].Value = " ";
                dataGridView1.Rows[n].Cells[4].Value = " ";
            if(rdTeacher.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdTeacher.Text;
                dataGridView1.Rows[n].Cells[3].Value = " ";
                dataGridView1.Rows[n].Cells[4].Value = " ";
            if (rdStaft.Checked)
                dataGridView1.Rows[n].Cells[2].Value = rdStaft.Text;
                dataGridView1.Rows[n].Cells[3].Value = tbUsename.Text;
                dataGridView1.Rows[n].Cells[4].Value = tbPassword.Text;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] output = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            output[0] += columnNames;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    output[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, output, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }
    }
}
