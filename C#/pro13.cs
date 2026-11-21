/* SQL: CREATE DATABASE College; USE College;
   CREATE TABLE Student (Id INT PRIMARY KEY, Name VARCHAR(50), Course VARCHAR(30)); */

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        string cs = @"Data Source=(localdb)\MSSQLLocalDB;
                      Initial Catalog=College;
                      Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                string q = "INSERT INTO Student VALUES (@id,@name,@course)";
                SqlCommand cmd = new SqlCommand(q, con);

                cmd.Parameters.AddWithValue("@id", int.Parse(txtId.Text));
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@course", txtCourse.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Saved");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    MessageBox.Show(dr["Id"] + " " + dr["Name"] + " " +
                                    dr["Course"]);
                }
            }
        }
    }
}