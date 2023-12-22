using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubRegistration
{
    public partial class lblFrmClubRegistration : Form
    {
        private ClubRegistrationQuery clubRegistrationQuery;
        private int count = 0;
        private int ID, Age;
        private string FirstName, MiddleName, LastName, Gender, Program;
        private long StudentId;

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshListOfClubMembers();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmUpdateMember fum = new FrmUpdateMember();
            fum.ShowDialog();
        }

        public lblFrmClubRegistration()
        {
            InitializeComponent();
            clubRegistrationQuery = new ClubRegistrationQuery();

            RefreshListOfClubMembers(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            ID = RegistrationID();
            StudentId = long.Parse(txtBoxStudentID.Text);
            FirstName = txtBoxFirstName.Text;
            MiddleName = txtBoxMiddleName.Text;
            LastName = tXtBoxLastName.Text;
            Age = int.Parse(txtBoxAge.Text);
            Gender = cbBoxGender.Text;
            Program = cBoxProgram.Text;

            if (clubRegistrationQuery.RegisterStudent(ID, StudentId, FirstName, MiddleName, LastName, Age, Gender, Program))
            {
                MessageBox.Show("Student registered successfully!");

            }
            else
            {
                MessageBox.Show("Error registering student!");
            }

        }

        private int RegistrationID()
        {
            count++;
            return count;
        }
        private void RefreshListOfClubMembers()
        {
            clubRegistrationQuery.DisplayList();

            dataGridViewLOCM.DataSource = clubRegistrationQuery.bindingSource;
        
        }
    }
}
