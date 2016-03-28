using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RapidGpaCalculator
{
    public partial class frmRapidGpaCalculator : Form
    {
        Button[] groupCreditButtonArray;
        Button[] groupGradeButtonArray;
        GroupBox[] groupBoxArray;
        String[,] convertGrade;

        public frmRapidGpaCalculator()
        {
            InitializeComponent();

        }//end frmRapidGpaCalculator

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }//end btnQuit_Click()

        private void btnReset_Click(object sender, EventArgs e)
        {
            //blank groupbox buttons

            //groupboxs become false

            blankInputBoxes();
            populateGrpCourseBox(grpCourseOne, btnCourseOne, btnCreditOne, btnGradeOne);
            grpCourseOne.Visible = false;

            populateGrpCourseBox(grpCourseTwo, btnCourseTwo, btnCreditTwo, btnGradeTwo);
            grpCourseTwo.Visible = false;

            populateGrpCourseBox(grpCourseThree, btnCourseThree, btnCreditThree, btnGradeThree);
            grpCourseThree.Visible = false;

            populateGrpCourseBox(grpCourseFour, btnCourseFour, btnCreditFour, btnGradeFour);
            grpCourseFour.Visible = false;

            populateGrpCourseBox(grpCourseFive, btnCourseFive, btnCreditFive, btnGradeFive);
            grpCourseFive.Visible = false;

            populateGrpCourseBox(grpCourseSix, btnCourseSix, btnCreditSix, btnGradeSix);
            grpCourseSix.Visible = false;

            lblCumulativeGPA.Visible = false;

        }//end btnReset_Click()

        private void btnCalculateGPA_Click(object sender, EventArgs e)
        {
            double totalGradePoints = 0;
            double totalCredits = 0;
            double totalGrades = 0;

            //Each visible btnGradeRecieved convert to doubles and add the converted doubles

            //Each visible btnCreditRecieved add credit values

            totalGrades = gatherGradeValues();
            totalGradePoints = gatherGradeValues();
            totalCredits = calculateTotalCredits();

            // Make lblCumulativeGPA visible true
            lblCumulativeGPA.Visible = true;

            //Populate finalGPA label
            lblCumulativeGPA.Text = (totalGradePoints / totalCredits).ToString("#.## Final GPA");

        }//end btnCalculateGPA_Click

        private double gatherGradeValues()

        //stores grade values and adds values together

        {
            double grades = 0;

            for (int n = 0; n < groupBoxArray.Length; n++)
            {
                if (groupBoxArray[n].Visible == true)
                    grades += convertGradeValues(grades, groupGradeButtonArray[n].Text)
                        * Convert.ToDouble(groupCreditButtonArray[n].Text);
            }

            //return grades
            return grades;

        }//end gatherGradeValues()

        private double convertGradeValues(double grades, String letterGrade)

        {
            //convert string grades to double values from an array

            for (int n = 0; n < convertGrade.GetUpperBound(1); n++)
            {
                if (convertGrade[0, n].CompareTo(letterGrade) == 0)
                {
                    grades = Convert.ToDouble(convertGrade[1, n]);
                    break;
                }
            }

            //return grades
            return grades;

        }//end convertGradeValues

        private double calculateTotalCredits()
        {
            double credits = 0;

            for (int n = 0; n < groupCreditButtonArray.Length; n++)
            {
                if (groupBoxArray[n].Visible == true)
                    credits += Convert.ToDouble(groupCreditButtonArray[n].Text);
            }

            //return credits
            return credits;

        }//end calculateTotalCredits()

        private void lblAddCourse_Click(object sender, EventArgs e)
        {
            //display error message if no input

            if (displayInputErrorMessage())
                return;

            if (grpCourseOne.Visible == false)
                populateGrpCourseBox(grpCourseOne, btnCourseOne, btnCreditOne, btnGradeOne);

            else if (grpCourseTwo.Visible == false)
                populateGrpCourseBox(grpCourseTwo, btnCourseTwo, btnCreditTwo, btnGradeTwo);

            else if (grpCourseThree.Visible == false)
                populateGrpCourseBox(grpCourseThree, btnCourseThree, btnCreditThree, btnGradeThree);

            else if (grpCourseFour.Visible == false)
                populateGrpCourseBox(grpCourseFour, btnCourseFour, btnCreditFour, btnGradeFour);

            else if (grpCourseFive.Visible == false)
                populateGrpCourseBox(grpCourseFive, btnCourseFive, btnCreditFive, btnGradeFive);

            else if (grpCourseSix.Visible == false)
                populateGrpCourseBox(grpCourseSix, btnCourseSix, btnCreditSix, btnGradeSix);

            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "ONLY SIX COURSES ARE ALLOWED!";
            }

        }//end lblAddCourse_Click()

        private void populateGrpCourseBox(GroupBox gb, Button b1, Button b2, Button b3)
        {
            if (gb.Visible == false)
            {
                gb.Visible = true;

                b1.Text = txtCourseName.Text;
                b2.Text = lstCreditValue.Text;
                b3.Text = lstGradeRecieved.Text;
            }

            blankInputBoxes();

        }//end populateGrpCourseBox()

        private void blankInputBoxes()
        {
            txtCourseName.Text = "";
            lstCreditValue.Text = "";
            lstGradeRecieved.Text = "";

        }//end blankInputBoxes()

        private bool displayInputErrorMessage()
        {
            //make error label message true and visible

            lblErrorMessage.Visible = true;
            lblErrorMessage.Text = "";

            if (txtCourseName.Text == "")
            {
                lblErrorMessage.Text += "You must have a Course Name!";
            }

            if (lstGradeRecieved.Text.Length == 0)
            {
                if (lblErrorMessage.Text.Length > 0)
                    lblErrorMessage.Text += "\n";

                lblErrorMessage.Text += "You must select a Grade Received!";
            }

            if (lstCreditValue.Text.Length == 0)
            {
                if (lblErrorMessage.Text.Length > 0)
                    lblErrorMessage.Text += "\n";

                lblErrorMessage.Text += "You must select a Credit Value!";
            }

            if (lblErrorMessage.Text.Length == 0)
            {
                lblErrorMessage.Visible = false;
                return false;
            }
            else
                return true;

        }//end displayInputErrorMessage()

        private void btnCourseOne_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseOne.Text;
            lstCreditValue.Text = btnCreditOne.Text;
            lstGradeRecieved.Text = btnGradeOne.Text;

            //make groupbox visible = false;
            grpCourseOne.Visible = false;

        }//end btnCourseOne_Click()

        private void btnCourseTwo_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseTwo.Text;
            lstCreditValue.Text = btnCreditTwo.Text;
            lstGradeRecieved.Text = btnGradeTwo.Text;

            //make groupbox visible = false;
            grpCourseTwo.Visible = false;

        }//end btnCourseTwo_Click()

        private void btnCourseThree_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseThree.Text;
            lstCreditValue.Text = btnCreditThree.Text;
            lstGradeRecieved.Text = btnGradeThree.Text;

            //make groupbox visible = false;
            grpCourseThree.Visible = false;

        }//end btnCourseThree_Click()

        private void btnCourseFour_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseFour.Text;
            lstCreditValue.Text = btnCreditFour.Text;
            lstGradeRecieved.Text = btnGradeFour.Text;

            //make groupbox visible = false;
            grpCourseFour.Visible = false;

        }//end btnCourseFour_Click()

        private void btnCourseFive_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseFive.Text;
            lstCreditValue.Text = btnCreditFive.Text;
            lstGradeRecieved.Text = btnGradeFive.Text;

            //make groupbox visible = false;
            grpCourseFive.Visible = false;

        }//end btnCourseFive_Click()

        private void btnCourseSix_Click(object sender, EventArgs e)
        {
            //move course, credits, and grade to input section

            txtCourseName.Text = btnCourseSix.Text;
            lstCreditValue.Text = btnCreditSix.Text;
            lstGradeRecieved.Text = btnGradeSix.Text;

            //make groupbox visible = false;
            grpCourseSix.Visible = false;

        }//btnCourseSix_Click()

        private void frmRapidGpaCalculator_Load(object sender, EventArgs e)
        {
            groupBoxArray = new GroupBox[6];
            groupBoxArray[0] = grpCourseOne;
            groupBoxArray[1] = grpCourseTwo;
            groupBoxArray[2] = grpCourseThree;
            groupBoxArray[3] = grpCourseFour;
            groupBoxArray[4] = grpCourseFive;
            groupBoxArray[5] = grpCourseSix;

            groupGradeButtonArray = new Button[6];
            groupGradeButtonArray[0] = btnGradeOne;
            groupGradeButtonArray[1] = btnGradeTwo;
            groupGradeButtonArray[2] = btnGradeThree;
            groupGradeButtonArray[3] = btnGradeFour;
            groupGradeButtonArray[4] = btnGradeFive;
            groupGradeButtonArray[5] = btnGradeSix;

            groupCreditButtonArray = new Button[6];
            groupCreditButtonArray[0] = btnCreditOne;
            groupCreditButtonArray[1] = btnCreditTwo;
            groupCreditButtonArray[2] = btnCreditThree;
            groupCreditButtonArray[3] = btnCreditFour;
            groupCreditButtonArray[4] = btnCreditFive;
            groupCreditButtonArray[5] = btnCreditSix;

            convertGrade = new String[2, 12];
            convertGrade[0, 0] = "A";
            convertGrade[1, 0] = "4.00";
            convertGrade[0, 1] = "A-";
            convertGrade[1, 1] = "3.67";
            convertGrade[0, 2] = "B+";
            convertGrade[1, 2] = "3.33";
            convertGrade[0, 3] = "B";
            convertGrade[1, 3] = "3.00";
            convertGrade[0, 4] = "B-";
            convertGrade[1, 4] = "2.67";
            convertGrade[0, 5] = "C+";
            convertGrade[1, 5] = "2.33";
            convertGrade[0, 6] = "C";
            convertGrade[1, 6] = "2.00";
            convertGrade[0, 7] = "C-";
            convertGrade[1, 7] = "1.67";
            convertGrade[0, 8] = "D+";
            convertGrade[1, 8] = "1.33";
            convertGrade[0, 9] = "D";
            convertGrade[1, 9] = "1.00";
            convertGrade[0, 10] = "D-";
            convertGrade[1, 10] = "0.50";
            convertGrade[0, 11] = "F";
            convertGrade[1, 11] = "0.00";

        }//end frmRapidGpaCalculator_Load()
    }
}
