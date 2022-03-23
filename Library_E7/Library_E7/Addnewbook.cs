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
    public partial class Addnewbook : Form
    {
        public Addnewbook()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string BookID = txtBID.Text.Trim();
                string BookTitle = txtBtitle.Text.Trim();
                string BookAuthor = txtBauthor.Text.Trim();
                string BookEdition = comboEedition.Text.Trim();
                string BookLanguage = comboBlanguage.Text.Trim();
                string BookType = comboBtype.Text.Trim();

                string sql="insert into Book_details(Book_ID, Book_Title, Book_Author, BooK_Edition, Book_language, Book_Type) values("+BookID+", '"+BookTitle+"', '"+BookAuthor+"', '"+BookEdition+"', '"+BookLanguage+"', '"+BookType+"')";
                SqlCommand s = new SqlCommand(sql, DataConnection.Datacon);
                s.ExecuteNonQuery();

                s.Dispose();
                MessageBox.Show("Commpleted Add");
                this.Dispose();
                new Addnewbook().Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gunaCountBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = "select *from Book_details";
            SqlCommand s = new SqlCommand(sql, DataConnection.Datacon);
            SqlDataReader r = s.ExecuteReader();

            while (r.Read())
            {
                string Book_Id = r.GetValue(0) + "";
                string Book_Tile = r[1] + "";
                string Book_Author = r[2] + "";
                string BooK_Edition = r[3] + "";
                string Book_language = r[4] + "";
                string Book_Type = r[5] + "";
                CountBook.Rows.Add(Book_Id, Book_Tile, Book_Author, BooK_Edition, Book_language, Book_Type);
            }
            r.Close();
            int count = CountBook.RowCount;
            txtTotalbook.Text = count.ToString();
        }
    }
}
