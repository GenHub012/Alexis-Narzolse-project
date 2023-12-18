using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alexis_Narzolse_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Compute_Click(object sender, EventArgs e)
        {
            double networking, hci, pe, rizal, math, mas, comprog,tot,avg;
            string grades;

            //inputing the grade
            networking = int.Parse(txtNetworking.Text);
            hci = int.Parse(txtHCI.Text);
            pe = int.Parse(txtPE.Text);
            rizal = int.Parse(txtRizal.Text);
            math = int.Parse(txtMath.Text);
            mas = int.Parse(txtMAS.Text);
            comprog = int.Parse(txtComprog2.Text);

            //Computing the total
            tot = networking + hci + pe + rizal + math + mas + comprog;
            txtTotal.Text = tot.ToString();

            //Computing the total and average
            avg = tot / 7;
            txtAverage.Text = avg.ToString("F2");  // Display average with two decimal places

            if (avg <= 3.0)
            {
                grades = "Passed";
            }
            else if (avg <= 5.0)  // Assuming the maximum average grade is 5.0
            {
                grades = "Failed";
            }
            else
            {
                grades = "Invalid Grade";
            }

            txtGrade.Text = grades;

            string studentName = txtName.Text;
            string section = txtSection.Text;
            string message = $"Student: {studentName}\nSection: {section}\nFinal Average: {avg:F2}\nGrade: {grades}";

            MessageBox.Show(message, "Result", MessageBoxButtons.OK);
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSection.Text = "";

            // Clearing input fields
            txtNetworking.Text = "";
            txtHCI.Text = "";
            txtPE.Text = "";
            txtRizal.Text = "";
            txtMath.Text = "";
            txtMAS.Text = "";
            txtComprog2.Text = "";

            // Clearing result fields
            txtTotal.Text = "";
            txtAverage.Text = "";
            txtGrade.Text = "";
        }
    }
}
