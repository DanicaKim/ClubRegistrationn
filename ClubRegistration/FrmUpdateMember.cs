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

namespace ClubRegistration
{
    public partial class FrmUpdateMember : Form
    {
        public FrmUpdateMember()
        {
            InitializeComponent();
            displayStudentID();


        }

        public void displayStudentID()
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\ClubRegistration\ClubRegistration\ClubDB.mdf;Integrated Security=True");

            string studentID = "SELECT * FROM ClubMembers";

            SqlCommand sqlcomm = new SqlCommand(studentID, sqlconn);
            SqlDataReader myReader;

            try
            {
                sqlconn.Open();
                myReader = sqlcomm.ExecuteReader();

                while (myReader.Read())
                {
                    Int64 StudID = myReader.GetInt64(1);
                    comboBox1.Items.Add(StudID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlconn.Close();
        }
        

       

        private void FrmUpdateMember_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\ClubRegistration\ClubRegistration\Club_DB.mdf;Integrated Security=True");
            string StudentID = "SELECT * FROM ClubMembers WHERE StudentId = '" + comboBox1.Text + "';";

            SqlCommand sqlcomm = new SqlCommand(StudentID, sqlconn);
            SqlDataReader myReader;

            try
            {
                sqlconn.Open();
                myReader = sqlcomm.ExecuteReader();

                while (myReader.Read())
                {
                    string fname = myReader.GetString(2);
                    string mname = myReader.GetString(3);
                    string lname = myReader.GetString(4);
                    string age = myReader.GetInt32(5).ToString();
                    string gender = myReader.GetString(6);
                    string program = myReader.GetString(7);

                    txtBoxFirstName.Text = fname;
                    txtBoxMiddleName.Text = mname;
                    tXtBoxLastName.Text = lname;
                    txtBoxAge.Text = age;
                    cbBoxGender.Text = gender;
                    cBoxProgram.Text = program;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlconn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\ClubRegistration\ClubRegistration\Club_DB.mdf;Integrated Security=True");

            try
            {
                sqlconn.Open();

                string updatedQuery = "UPDATE ClubMembers SET StudentID=@StudentId, FirstName=@FirstName, MiddleName=@MiddleName, LastName=@LastName, Age=@Age, Gender=@Gender, Program=@Program WHERE ID=@ID";

                using (SqlCommand sqlcomm = new SqlCommand(updatedQuery, sqlconn))
                {
                    int selectedID = 2;

                    sqlcomm.Parameters.AddWithValue("@ID", selectedID);
                    sqlcomm.Parameters.AddWithValue("@StudentId", comboBox1.Text);
                    sqlcomm.Parameters.AddWithValue("@FirstName", txtBoxFirstName.Text);
                    sqlcomm.Parameters.AddWithValue("@MiddleName", txtBoxMiddleName.Text);
                    sqlcomm.Parameters.AddWithValue("@LastName", tXtBoxLastName.Text);
                    sqlcomm.Parameters.AddWithValue("@Age", Convert.ToInt32(txtBoxAge.Text));
                    sqlcomm.Parameters.AddWithValue("@Gender", cbBoxGender.Text);
                    sqlcomm.Parameters.AddWithValue("@Program", cBoxProgram.Text);

                    MessageBox.Show("Record Updated");

                    sqlcomm.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            sqlconn.Close();
        }
    }
}
    