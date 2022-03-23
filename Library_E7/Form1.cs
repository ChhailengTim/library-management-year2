using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_E7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string ip = txtIP.Text.Trim();
                string dbname = "Library_E7";
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                int index = comoAuth.SelectedIndex;
                if (index == 0)
                {
                    //Windows Authentication
                    DataConnection.ConnectionDB(ip, dbname);
                }
                else
                {
                    //SQL Sever Authentication
                    DataConnection.ConnectionDB(ip, dbname, username, password);
                }
                new MainForm().Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comoAuth.SelectedIndex;
            if (index == 0)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
            else
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comoAuth.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
