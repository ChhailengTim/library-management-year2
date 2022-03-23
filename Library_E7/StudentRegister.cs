using Guna.UI2.WinForms.Suite;
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
using HScrollBar = System.Windows.Forms.HScrollBar;

namespace Library_E7
{
    public partial class StudentRegister : Form
    {
        public StudentRegister()
        {
            InitializeComponent();
        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string StudentID = txtstudentID.Text.Trim();
                string StudentName = txtStudentname.Text.Trim();
                string Gender = comboGender.Text.Trim();
                string Class = txtClass.Text.Trim();
                string Year = comboYear.Text.Trim();
                string Departement = txtDepartement.Text.Trim();
                string Phone = txtPhone.Text.Trim();
                string Address = comboAddress.Text.Trim();

                string sql = "INSERT INTO Student_details(Std_Id,Std_Name,Std_Gender,Std_Class,Std_Years,Std_Phone,Std_Address,Departement) VALUES('"+StudentID+"','"+StudentName+"','"+Gender+"','"+Class+"',"+Year+",'"+Phone+"','"+Address+"','"+Departement+"');";
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
    
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sql = "select *from Student_details";
                SqlCommand s = new SqlCommand(sql, DataConnection.Datacon);
                SqlDataReader r = s.ExecuteReader();
                
                while (r.Read())
                {
                    string id = r.GetValue(0) + "";
                    string Stdname = r[1] + "";
                    string Gender = r[2] + "";
                    string Class =r[3] + "";
                    string Year = r[4] + "";
                    string Phone = r[5] + "";
                    string Address = r[6] + "";
                    string Departement = r[7] + "";

                    datastd.Rows.Add(id, Stdname, Gender, Class, Year, Phone, Address, Departement);
                }
                r.Close();
                int count=datastd.RowCount;
                txttotal.Text = count.ToString();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void Lscroll_Scroll(object sender, ScrollEventArgs e)
        {
          
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void StudentRegister_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }
    }
}
