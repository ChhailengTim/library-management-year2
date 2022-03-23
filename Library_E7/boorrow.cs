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
    public partial class boorrow : Form
    {
        public boorrow()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                string libID = txtLID.Text.Trim();
                string StdID = txtSID.Text.Trim();
                string bookID = txtBID.Text.Trim();
                string returnID = txtRID.Text.Trim();
                string Quantity = txtQTY.Text.Trim();
                string startdate = gunaStart.Text.Trim();
                string enddate = gunaEnd.Text.Trim();
                string returndate = gunaReturn.Text.Trim();

                string sql = "INSERT INTO borrow(lib_ID,Std_Id,book_ID,return_ID,Quantity,startdate,enddate,returndate) VALUES('" + libID + "','" + StdID + "','" + bookID + "','" + returnID + "','" + Quantity + "','" + startdate + "','" + enddate + "','" + returndate + "');";
                SqlCommand s = new SqlCommand(sql, DataConnection.Datacon);
                s.ExecuteNonQuery();

                s.Dispose();
                MessageBox.Show("Commpleted Add");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
