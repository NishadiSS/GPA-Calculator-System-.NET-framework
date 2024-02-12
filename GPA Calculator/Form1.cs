using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPA_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double gpv = 0.0;
            string c1 = c1grade.Text;
            string c2 = c2grade.Text;
            string c3 = c3grade.Text;
            string c4 = c4grade.Text;
            string c5 = c5grade.Text;
            string c6 = c6grade.Text;
            string c7 = c7grade.Text;
            string c8 = c8grade.Text;

            double cr1=double.Parse(c1credit.Text);
            double cr2 = double.Parse(c2credit.Text);
            double cr3 = double.Parse(c3credit.Text);
            double cr4 = double.Parse(c4credit.Text);
            double cr5 = double.Parse(c5credit.Text);
            double cr6 = double.Parse(c6credit.Text);
            double cr7 = double.Parse(c7credit.Text);
            double cr8 = double.Parse(c8credit.Text);

            double upGPA = getGPV(c1) * cr1 + getGPV(c2) * cr2 + getGPV(c3) * cr3 + getGPV(c4) * cr4 + getGPV(c5) * cr5 + getGPV(c6) * cr6 + getGPV(c7) * cr7 + getGPV(c8) * cr8;
            double downGPA = cr1 + cr2 + cr3 + cr4 + cr5 + cr6 + cr7 + cr8;

            double GPA = upGPA / downGPA;


            txtGPA.Text = GPA.ToString();


            double getGPV(String Grade)
            {
                switch (Grade)
                {
                    case "A+":
                        gpv=4.2;
                        break;
                    case "A":
                        gpv = 4.0;
                        break;
                    case "A-":
                        gpv = 3.7;
                        break;
                    case "B+":
                        gpv = 3.3;
                        break;
                    case "B":
                        gpv = 3.0;
                        break;
                    case "B-":
                        gpv = 2.7;
                        break;
                    case "C+":
                        gpv = 2.3;
                        break;
                    case "I":
                        gpv = 0.0;
                        break;
                    case "F":
                        gpv = 0.0;
                        break;
                }
                return gpv;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            c1grade.Text = "";
            c2grade.Text = "";
            c3grade.Text = "";
            c4grade.Text = "";
            c5grade.Text = "";
            c6grade.Text = "";
            c7grade.Text = "";
            c8grade.Text = "";

            c1credit.Text = "";
            c2credit.Text = "";
            c3credit.Text = "";
            c4credit.Text = "";
            c5credit.Text = "";
            c6credit.Text = "";
            c7credit.Text = "";
            c8credit.Text = "";

            txtGPA.Text = "";


        }
    }
}
