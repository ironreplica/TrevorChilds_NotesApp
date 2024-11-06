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
    public partial class Form2 : Form
    {
        public Form1 form1;
        public string openTitle;
        public string openDesc;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            form1.table.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);
            form1.ResetForm();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (openTitle != null) {
                titleTextBox.Text = openTitle;
            }
            if (openDesc != null)
            {
                descriptionTextBox.Text = openDesc;
            }
        }
    }
}
