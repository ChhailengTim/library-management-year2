using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_E7
{
    public partial class booklist : Form
    {
        public booklist()
        {
            InitializeComponent();
        }

        private void booklist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library_E7DataSet.Book_details' table. You can move, or remove it, as needed.
            this.book_detailsTableAdapter.Fill(this.library_E7DataSet.Book_details);
            coboColumn.SelectedIndex = 1;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtSearch.Text))
                    bookdetailsBindingSource.Filter = string.Empty;
                else
                    bookdetailsBindingSource.Filter = string.Format("{0}='{1}'", coboColumn.Text, txtSearch.Text);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
            new booklist().Show();
            this.Dispose();
        }

        private static void Open()
        {
            throw new NotImplementedException();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
