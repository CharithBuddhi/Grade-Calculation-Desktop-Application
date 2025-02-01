using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment__E2140110_
{
    public partial class FrmStudentDetais : Form
    {
        public FrmStudentDetais()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int CAWeightage, ESEMarks, CAMarks, ESEWeightage, totalMarks, Attendance;
            string grade = "Not Grade";
  
            if (int.TryParse(txtCAWeight.Text, out CAWeightage)
                && int.TryParse(txtESEMark.Text, out ESEMarks)
                && int.TryParse(txtCAMarks.Text, out CAMarks)
                && int.TryParse(txtESEWeightage.Text, out ESEWeightage)
                && int.TryParse(txtAttendance.Text, out Attendance))

            {

                if (CAWeightage > 40 || CAWeightage < 0)
                {
                    MessageBox.Show("This Value Not Supporded,Please Enter Valid" +
                        " Continuous Assessment Weightage Value.");
                }
                else
                {
                    if (ESEWeightage > 60 || ESEWeightage < 0)
                    {
                        MessageBox.Show("This Value Not Supporded,Please Enter Valid" +
                           " End-Semester Examination Value.");
                    }
                    else if (Attendance > 100 || Attendance < 0)
                    {
                        MessageBox.Show("This Value Not Supporded,Please Enter Valid" +
                           " Attendance Percentage.");
                    }
                    else if (ESEMarks > 100 || ESEMarks < 0 || CAMarks > 100 || CAMarks < 0)
                    {
                        MessageBox.Show("This Value Not Supporded,Please For Marks Enter " +
                          " a Value Between 100 And 0.");
                    }
                    else
                    {
                        totalMarks = (ESEMarks * ESEWeightage) / 100 + (CAMarks * CAWeightage) / 100;
                        MessageBox.Show("Total Marks" + totalMarks);

                        if (totalMarks >= 85)
                        {
                            grade = "A";
                        }
                        else if (totalMarks >= 65)
                        {
                            grade = "B";
                        }
                        else if (totalMarks >= 50)
                        {
                            grade = "C";
                        }
                        else if (totalMarks >= 40)
                        {
                            grade = "D";
                        }
                        else
                        {
                            grade = "F";
                        }
                        if (Attendance < 80 && Attendance >=60)
                        {
                            if (totalMarks >= 65)
                            {
                                grade = "C";
                            }
                        }
                        else if (Attendance < 60)
                        {
                            grade = "F";
                        }
                        MessageBox.Show("Grade :" + grade);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Include Valid Data.");
            }
            frmCalculatedDataOfStudent Form3 = new frmCalculatedDataOfStudent(txtRegName.Text, txtRegNumber.Text,
                txtModName.Text, txtModCode.Text, grade);
            Form3.Show();

        }
    }
}
