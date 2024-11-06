using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes_App
{
    public partial class Form1 : Form
    {
        public DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;

            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 136;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            table.Rows.Add(title.Text, message.Text);
            ResetForm();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index > -1)
            {
                title.Text = table.Rows[index].ItemArray[0].ToString();
                message.Text = table.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            table.Rows[index].Delete();
        }

        private void btnSecondForm_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.form1 = this;
            if(title.Text !=null && title.Text != "")
            {
                secondForm.openTitle = title.Text;
            }
            if (message.Text != null && message.Text != "")
            {
                secondForm.openDesc = message.Text;
            }
            secondForm.Show();
        }
        public void ResetForm()
        {
            title.Clear();
            message.Clear();
        }
    }
}
