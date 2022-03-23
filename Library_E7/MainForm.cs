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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBookLists_Click(object sender, EventArgs e)
        {
            new booklist().Show();
        }

        private object booklist()
        {
            throw new NotImplementedException();
        }

        private void btnNewbook_Click(object sender, EventArgs e)
        {
            new Addnewbook().Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            new boorrow().Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            new StudentRegister().Show();
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
