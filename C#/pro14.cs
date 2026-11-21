using System;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string gender = rbMale.Checked ? "Male" : "Female";
            string hobbies = "";

            if (chkReading.Checked)
                hobbies += "Reading ";

            if (chkSports.Checked)
                hobbies += "Sports";

            MessageBox.Show(
                "Name: " + txtName.Text +
                "\nGender: " + gender +
                "\nHobbies: " + hobbies);
        }
    }
}