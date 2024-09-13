using System;
using System.Windows.Forms;
using test_team1.Dal;

namespace test_team1.Ui
{
    public partial class StudentForm : Form
    {

        private StudentDAL studentDAL;
        public StudentForm()
        {
            InitializeComponent();
            studentDAL = new StudentDAL();
        }

        private void getAllStudents_Click(object sender, EventArgs e)
        {

            String allStudents = "";

            foreach (var Student in studentDAL.GetAllStudents())
            {
                allStudents += Student.ToString() + "\r\n";
            }

            MessageBox.Show(allStudents);

        }
    }
}
