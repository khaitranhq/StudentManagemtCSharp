using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Student student = new Student();

            student.Name = nameTbx.Text;
            student.Mssv = mssvTbx.Text;
            student.DateOfBirth = dateOfBirthDTP.Value;
            student.Address = addressTbx.Text;
            student.PhoneNumer = Int64.Parse(phoneNumberTbx.Text);
            student.SchoolYear = (int) schoolYearNum.Value;

            if (universityRBtn.Checked)
            {
                student.TypeDegree = "Đại học";
                UniversityStudent universityStudent = student as UniversityStudent;

                if (specializedAutoCmp.SelectedValue != null)
                {
                    universityStudent.Specialized = specializedAutoCmp.SelectedValue.ToString();
                }

                students.Add(universityStudent);
            }

            if (secondaryDegreeRBtn.Checked)
            {
                student.TypeDegree = "Bằng 2";
                SecondaryDegreeStudent secondaryDegreeStudent = student as SecondaryDegreeStudent;
                secondaryDegreeStudent.FirstDegree = firstDegreeTbx.Text;
                secondaryDegreeStudent.WorkPlace = workPlaceTbx.Text;

                students.Add(secondaryDegreeStudent);
            }

            if (collegeRBtn.Checked)
            {
                student.TypeDegree = "Cao đẳng";
                CollegeStudent collegeStudent = student as CollegeStudent;
                students.Add(collegeStudent);
            }

            listStudentView.Items.Add(new ListViewItem(new string[] {
                student.Mssv,
                student.Name,
                student.DateOfBirth.ToString(),
                student.Address,
                student.PhoneNumer.ToString(),
                student.SchoolYear.ToString(),
                student.TypeDegree
            }));
        }

        private void phoneNumberTbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
