using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            materialTextBox1.Clear();
            materialTextBox2.Clear();



        }

        private void materialTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if(materialTextBox1.Text == "user" && materialTextBox2.Text == "password")
            {
                Cliente cl1 = new Cliente();
                this.Hide();


                cl1.Show();


            }
            else
            {

                MessageBox.Show("Las credenciales son incorrecttas");



            }











        }
    }
}
