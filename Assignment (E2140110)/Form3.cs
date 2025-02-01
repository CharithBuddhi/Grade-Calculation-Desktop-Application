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
    public partial class frmCalculatedDataOfStudent : Form
    {
        public frmCalculatedDataOfStudent(string studentName, string RegistrationNumber,
            string ModuleName, string ModuleCode, string grade)
        {
            InitializeComponent();
            lblStudName.Text = studentName;
            lblRegNumber.Text = RegistrationNumber;
            lblModName.Text = ModuleName;
            lblModCode.Text = ModuleCode;
            lblGrade.Text = grade;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
