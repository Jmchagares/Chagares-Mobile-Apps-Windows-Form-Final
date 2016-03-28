namespace RapidGpaCalculator
{
    partial class frmRapidGpaCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapidGpaCalculator));
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblGradeRecieved = new System.Windows.Forms.Label();
            this.lblCreditValue = new System.Windows.Forms.Label();
            this.lstGradeRecieved = new System.Windows.Forms.ComboBox();
            this.btnCalculateGPA = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblAddCourse = new System.Windows.Forms.Button();
            this.lstCreditValue = new System.Windows.Forms.ComboBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCumulativeGPA = new System.Windows.Forms.Label();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnCourseOne = new System.Windows.Forms.Button();
            this.btnCreditOne = new System.Windows.Forms.Button();
            this.btnGradeOne = new System.Windows.Forms.Button();
            this.grpCourseOne = new System.Windows.Forms.GroupBox();
            this.grpCourseTwo = new System.Windows.Forms.GroupBox();
            this.btnGradeTwo = new System.Windows.Forms.Button();
            this.btnCreditTwo = new System.Windows.Forms.Button();
            this.btnCourseTwo = new System.Windows.Forms.Button();
            this.grpCourseThree = new System.Windows.Forms.GroupBox();
            this.btnGradeThree = new System.Windows.Forms.Button();
            this.btnCreditThree = new System.Windows.Forms.Button();
            this.btnCourseThree = new System.Windows.Forms.Button();
            this.grpCourseFour = new System.Windows.Forms.GroupBox();
            this.btnGradeFour = new System.Windows.Forms.Button();
            this.btnCreditFour = new System.Windows.Forms.Button();
            this.btnCourseFour = new System.Windows.Forms.Button();
            this.grpCourseFive = new System.Windows.Forms.GroupBox();
            this.btnGradeFive = new System.Windows.Forms.Button();
            this.btnCreditFive = new System.Windows.Forms.Button();
            this.btnCourseFive = new System.Windows.Forms.Button();
            this.grpCourseSix = new System.Windows.Forms.GroupBox();
            this.btnGradeSix = new System.Windows.Forms.Button();
            this.btnCreditSix = new System.Windows.Forms.Button();
            this.btnCourseSix = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.grpCourseOne.SuspendLayout();
            this.grpCourseTwo.SuspendLayout();
            this.grpCourseThree.SuspendLayout();
            this.grpCourseFour.SuspendLayout();
            this.grpCourseFive.SuspendLayout();
            this.grpCourseSix.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourseName.ForeColor = System.Drawing.Color.Black;
            this.lblCourseName.Location = new System.Drawing.Point(153, 17);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(138, 24);
            this.lblCourseName.TabIndex = 0;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblGradeRecieved
            // 
            this.lblGradeRecieved.AutoSize = true;
            this.lblGradeRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeRecieved.ForeColor = System.Drawing.Color.Black;
            this.lblGradeRecieved.Location = new System.Drawing.Point(464, 20);
            this.lblGradeRecieved.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradeRecieved.Name = "lblGradeRecieved";
            this.lblGradeRecieved.Size = new System.Drawing.Size(161, 24);
            this.lblGradeRecieved.TabIndex = 1;
            this.lblGradeRecieved.Text = "Grade Recieved";
            // 
            // lblCreditValue
            // 
            this.lblCreditValue.AutoSize = true;
            this.lblCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditValue.ForeColor = System.Drawing.Color.Black;
            this.lblCreditValue.Location = new System.Drawing.Point(512, 81);
            this.lblCreditValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCreditValue.Name = "lblCreditValue";
            this.lblCreditValue.Size = new System.Drawing.Size(125, 24);
            this.lblCreditValue.TabIndex = 2;
            this.lblCreditValue.Text = "Credit Value";
            // 
            // lstGradeRecieved
            // 
            this.lstGradeRecieved.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGradeRecieved.FormattingEnabled = true;
            this.lstGradeRecieved.Items.AddRange(new object[] {
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "F"});
            this.lstGradeRecieved.Location = new System.Drawing.Point(687, 10);
            this.lstGradeRecieved.Margin = new System.Windows.Forms.Padding(4);
            this.lstGradeRecieved.Name = "lstGradeRecieved";
            this.lstGradeRecieved.Size = new System.Drawing.Size(128, 32);
            this.lstGradeRecieved.TabIndex = 8;
            // 
            // btnCalculateGPA
            // 
            this.btnCalculateGPA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCalculateGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateGPA.Location = new System.Drawing.Point(33, 863);
            this.btnCalculateGPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculateGPA.Name = "btnCalculateGPA";
            this.btnCalculateGPA.Size = new System.Drawing.Size(221, 58);
            this.btnCalculateGPA.TabIndex = 9;
            this.btnCalculateGPA.Text = "Calculate GPA";
            this.btnCalculateGPA.UseVisualStyleBackColor = false;
            this.btnCalculateGPA.Click += new System.EventHandler(this.btnCalculateGPA_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Yellow;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(298, 863);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(221, 58);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblAddCourse
            // 
            this.lblAddCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCourse.Location = new System.Drawing.Point(642, 118);
            this.lblAddCourse.Margin = new System.Windows.Forms.Padding(4);
            this.lblAddCourse.Name = "lblAddCourse";
            this.lblAddCourse.Size = new System.Drawing.Size(177, 58);
            this.lblAddCourse.TabIndex = 11;
            this.lblAddCourse.Text = "Add Course";
            this.lblAddCourse.UseVisualStyleBackColor = true;
            this.lblAddCourse.Click += new System.EventHandler(this.lblAddCourse_Click);
            // 
            // lstCreditValue
            // 
            this.lstCreditValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCreditValue.FormattingEnabled = true;
            this.lstCreditValue.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2",
            "3",
            "4"});
            this.lstCreditValue.Location = new System.Drawing.Point(687, 78);
            this.lstCreditValue.Margin = new System.Windows.Forms.Padding(4);
            this.lstCreditValue.Name = "lstCreditValue";
            this.lstCreditValue.Size = new System.Drawing.Size(128, 32);
            this.lstCreditValue.TabIndex = 12;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourseName.Location = new System.Drawing.Point(32, 53);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(412, 27);
            this.txtCourseName.TabIndex = 13;
            // 
            // lblCumulativeGPA
            // 
            this.lblCumulativeGPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumulativeGPA.Location = new System.Drawing.Point(308, 830);
            this.lblCumulativeGPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCumulativeGPA.Name = "lblCumulativeGPA";
            this.lblCumulativeGPA.Size = new System.Drawing.Size(201, 29);
            this.lblCumulativeGPA.TabIndex = 14;
            this.lblCumulativeGPA.Text = "Cumulative GPA";
            this.lblCumulativeGPA.Visible = false;
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Red;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.Black;
            this.btnQuit.Location = new System.Drawing.Point(572, 863);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(221, 58);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnCourseOne
            // 
            this.btnCourseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseOne.Location = new System.Drawing.Point(24, 21);
            this.btnCourseOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseOne.Name = "btnCourseOne";
            this.btnCourseOne.Size = new System.Drawing.Size(413, 36);
            this.btnCourseOne.TabIndex = 16;
            this.btnCourseOne.UseVisualStyleBackColor = true;
            this.btnCourseOne.Click += new System.EventHandler(this.btnCourseOne_Click);
            // 
            // btnCreditOne
            // 
            this.btnCreditOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditOne.Location = new System.Drawing.Point(495, 21);
            this.btnCreditOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditOne.Name = "btnCreditOne";
            this.btnCreditOne.Size = new System.Drawing.Size(128, 36);
            this.btnCreditOne.TabIndex = 17;
            this.btnCreditOne.UseVisualStyleBackColor = true;
            // 
            // btnGradeOne
            // 
            this.btnGradeOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeOne.Location = new System.Drawing.Point(656, 21);
            this.btnGradeOne.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeOne.Name = "btnGradeOne";
            this.btnGradeOne.Size = new System.Drawing.Size(128, 36);
            this.btnGradeOne.TabIndex = 18;
            this.btnGradeOne.UseVisualStyleBackColor = true;
            // 
            // grpCourseOne
            // 
            this.grpCourseOne.Controls.Add(this.btnGradeOne);
            this.grpCourseOne.Controls.Add(this.btnCreditOne);
            this.grpCourseOne.Controls.Add(this.btnCourseOne);
            this.grpCourseOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseOne.Location = new System.Drawing.Point(9, 207);
            this.grpCourseOne.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseOne.Name = "grpCourseOne";
            this.grpCourseOne.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseOne.Size = new System.Drawing.Size(807, 75);
            this.grpCourseOne.TabIndex = 19;
            this.grpCourseOne.TabStop = false;
            this.grpCourseOne.Text = "Course One";
            this.grpCourseOne.Visible = false;
            // 
            // grpCourseTwo
            // 
            this.grpCourseTwo.Controls.Add(this.btnGradeTwo);
            this.grpCourseTwo.Controls.Add(this.btnCreditTwo);
            this.grpCourseTwo.Controls.Add(this.btnCourseTwo);
            this.grpCourseTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseTwo.Location = new System.Drawing.Point(9, 312);
            this.grpCourseTwo.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseTwo.Name = "grpCourseTwo";
            this.grpCourseTwo.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseTwo.Size = new System.Drawing.Size(807, 75);
            this.grpCourseTwo.TabIndex = 20;
            this.grpCourseTwo.TabStop = false;
            this.grpCourseTwo.Text = "Course Two";
            this.grpCourseTwo.Visible = false;
            // 
            // btnGradeTwo
            // 
            this.btnGradeTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeTwo.Location = new System.Drawing.Point(656, 21);
            this.btnGradeTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeTwo.Name = "btnGradeTwo";
            this.btnGradeTwo.Size = new System.Drawing.Size(128, 36);
            this.btnGradeTwo.TabIndex = 18;
            this.btnGradeTwo.UseVisualStyleBackColor = true;
            // 
            // btnCreditTwo
            // 
            this.btnCreditTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditTwo.Location = new System.Drawing.Point(495, 21);
            this.btnCreditTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditTwo.Name = "btnCreditTwo";
            this.btnCreditTwo.Size = new System.Drawing.Size(128, 36);
            this.btnCreditTwo.TabIndex = 17;
            this.btnCreditTwo.UseVisualStyleBackColor = true;
            // 
            // btnCourseTwo
            // 
            this.btnCourseTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseTwo.Location = new System.Drawing.Point(24, 21);
            this.btnCourseTwo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseTwo.Name = "btnCourseTwo";
            this.btnCourseTwo.Size = new System.Drawing.Size(413, 36);
            this.btnCourseTwo.TabIndex = 16;
            this.btnCourseTwo.UseVisualStyleBackColor = true;
            this.btnCourseTwo.Click += new System.EventHandler(this.btnCourseTwo_Click);
            // 
            // grpCourseThree
            // 
            this.grpCourseThree.Controls.Add(this.btnGradeThree);
            this.grpCourseThree.Controls.Add(this.btnCreditThree);
            this.grpCourseThree.Controls.Add(this.btnCourseThree);
            this.grpCourseThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseThree.Location = new System.Drawing.Point(9, 416);
            this.grpCourseThree.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseThree.Name = "grpCourseThree";
            this.grpCourseThree.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseThree.Size = new System.Drawing.Size(807, 75);
            this.grpCourseThree.TabIndex = 21;
            this.grpCourseThree.TabStop = false;
            this.grpCourseThree.Text = "Course Three";
            this.grpCourseThree.Visible = false;
            // 
            // btnGradeThree
            // 
            this.btnGradeThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeThree.Location = new System.Drawing.Point(656, 21);
            this.btnGradeThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeThree.Name = "btnGradeThree";
            this.btnGradeThree.Size = new System.Drawing.Size(128, 36);
            this.btnGradeThree.TabIndex = 18;
            this.btnGradeThree.UseVisualStyleBackColor = true;
            // 
            // btnCreditThree
            // 
            this.btnCreditThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditThree.Location = new System.Drawing.Point(495, 21);
            this.btnCreditThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditThree.Name = "btnCreditThree";
            this.btnCreditThree.Size = new System.Drawing.Size(128, 36);
            this.btnCreditThree.TabIndex = 17;
            this.btnCreditThree.UseVisualStyleBackColor = true;
            // 
            // btnCourseThree
            // 
            this.btnCourseThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseThree.Location = new System.Drawing.Point(24, 21);
            this.btnCourseThree.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseThree.Name = "btnCourseThree";
            this.btnCourseThree.Size = new System.Drawing.Size(413, 36);
            this.btnCourseThree.TabIndex = 16;
            this.btnCourseThree.UseVisualStyleBackColor = true;
            this.btnCourseThree.Click += new System.EventHandler(this.btnCourseThree_Click);
            // 
            // grpCourseFour
            // 
            this.grpCourseFour.Controls.Add(this.btnGradeFour);
            this.grpCourseFour.Controls.Add(this.btnCreditFour);
            this.grpCourseFour.Controls.Add(this.btnCourseFour);
            this.grpCourseFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseFour.Location = new System.Drawing.Point(8, 517);
            this.grpCourseFour.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseFour.Name = "grpCourseFour";
            this.grpCourseFour.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseFour.Size = new System.Drawing.Size(807, 75);
            this.grpCourseFour.TabIndex = 22;
            this.grpCourseFour.TabStop = false;
            this.grpCourseFour.Text = "Course Four";
            this.grpCourseFour.Visible = false;
            // 
            // btnGradeFour
            // 
            this.btnGradeFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeFour.Location = new System.Drawing.Point(656, 21);
            this.btnGradeFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeFour.Name = "btnGradeFour";
            this.btnGradeFour.Size = new System.Drawing.Size(128, 36);
            this.btnGradeFour.TabIndex = 18;
            this.btnGradeFour.UseVisualStyleBackColor = true;
            // 
            // btnCreditFour
            // 
            this.btnCreditFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditFour.Location = new System.Drawing.Point(495, 21);
            this.btnCreditFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditFour.Name = "btnCreditFour";
            this.btnCreditFour.Size = new System.Drawing.Size(128, 36);
            this.btnCreditFour.TabIndex = 17;
            this.btnCreditFour.UseVisualStyleBackColor = true;
            // 
            // btnCourseFour
            // 
            this.btnCourseFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseFour.Location = new System.Drawing.Point(24, 21);
            this.btnCourseFour.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseFour.Name = "btnCourseFour";
            this.btnCourseFour.Size = new System.Drawing.Size(413, 36);
            this.btnCourseFour.TabIndex = 16;
            this.btnCourseFour.UseVisualStyleBackColor = true;
            this.btnCourseFour.Click += new System.EventHandler(this.btnCourseFour_Click);
            // 
            // grpCourseFive
            // 
            this.grpCourseFive.Controls.Add(this.btnGradeFive);
            this.grpCourseFive.Controls.Add(this.btnCreditFive);
            this.grpCourseFive.Controls.Add(this.btnCourseFive);
            this.grpCourseFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseFive.Location = new System.Drawing.Point(9, 624);
            this.grpCourseFive.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseFive.Name = "grpCourseFive";
            this.grpCourseFive.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseFive.Size = new System.Drawing.Size(807, 75);
            this.grpCourseFive.TabIndex = 23;
            this.grpCourseFive.TabStop = false;
            this.grpCourseFive.Text = "Course Five";
            this.grpCourseFive.Visible = false;
            // 
            // btnGradeFive
            // 
            this.btnGradeFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeFive.Location = new System.Drawing.Point(656, 21);
            this.btnGradeFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeFive.Name = "btnGradeFive";
            this.btnGradeFive.Size = new System.Drawing.Size(128, 36);
            this.btnGradeFive.TabIndex = 18;
            this.btnGradeFive.UseVisualStyleBackColor = true;
            // 
            // btnCreditFive
            // 
            this.btnCreditFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditFive.Location = new System.Drawing.Point(495, 21);
            this.btnCreditFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditFive.Name = "btnCreditFive";
            this.btnCreditFive.Size = new System.Drawing.Size(128, 36);
            this.btnCreditFive.TabIndex = 17;
            this.btnCreditFive.UseVisualStyleBackColor = true;
            // 
            // btnCourseFive
            // 
            this.btnCourseFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseFive.Location = new System.Drawing.Point(24, 21);
            this.btnCourseFive.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseFive.Name = "btnCourseFive";
            this.btnCourseFive.Size = new System.Drawing.Size(413, 36);
            this.btnCourseFive.TabIndex = 16;
            this.btnCourseFive.UseVisualStyleBackColor = true;
            this.btnCourseFive.Click += new System.EventHandler(this.btnCourseFive_Click);
            // 
            // grpCourseSix
            // 
            this.grpCourseSix.Controls.Add(this.btnGradeSix);
            this.grpCourseSix.Controls.Add(this.btnCreditSix);
            this.grpCourseSix.Controls.Add(this.btnCourseSix);
            this.grpCourseSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCourseSix.Location = new System.Drawing.Point(8, 728);
            this.grpCourseSix.Margin = new System.Windows.Forms.Padding(4);
            this.grpCourseSix.Name = "grpCourseSix";
            this.grpCourseSix.Padding = new System.Windows.Forms.Padding(4);
            this.grpCourseSix.Size = new System.Drawing.Size(807, 75);
            this.grpCourseSix.TabIndex = 24;
            this.grpCourseSix.TabStop = false;
            this.grpCourseSix.Text = "Course Six";
            this.grpCourseSix.Visible = false;
            // 
            // btnGradeSix
            // 
            this.btnGradeSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradeSix.Location = new System.Drawing.Point(656, 21);
            this.btnGradeSix.Margin = new System.Windows.Forms.Padding(4);
            this.btnGradeSix.Name = "btnGradeSix";
            this.btnGradeSix.Size = new System.Drawing.Size(128, 36);
            this.btnGradeSix.TabIndex = 18;
            this.btnGradeSix.UseVisualStyleBackColor = true;
            // 
            // btnCreditSix
            // 
            this.btnCreditSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreditSix.Location = new System.Drawing.Point(495, 21);
            this.btnCreditSix.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreditSix.Name = "btnCreditSix";
            this.btnCreditSix.Size = new System.Drawing.Size(128, 36);
            this.btnCreditSix.TabIndex = 17;
            this.btnCreditSix.UseVisualStyleBackColor = true;
            // 
            // btnCourseSix
            // 
            this.btnCourseSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourseSix.Location = new System.Drawing.Point(24, 21);
            this.btnCourseSix.Margin = new System.Windows.Forms.Padding(4);
            this.btnCourseSix.Name = "btnCourseSix";
            this.btnCourseSix.Size = new System.Drawing.Size(413, 36);
            this.btnCourseSix.TabIndex = 16;
            this.btnCourseSix.UseVisualStyleBackColor = true;
            this.btnCourseSix.Click += new System.EventHandler(this.btnCourseSix_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(33, 95);
            this.lblErrorMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(411, 92);
            this.lblErrorMessage.TabIndex = 25;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(203, 187);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(71, 24);
            this.lblCourse.TabIndex = 26;
            this.lblCourse.Text = "Course";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(534, 187);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(59, 24);
            this.lblCredit.TabIndex = 27;
            this.lblCredit.Text = "Credit";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(701, 187);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(62, 24);
            this.lblGrade.TabIndex = 28;
            this.lblGrade.Text = "Grade";
            // 
            // frmRapidGpaCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(832, 944);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.grpCourseSix);
            this.Controls.Add(this.grpCourseFive);
            this.Controls.Add(this.grpCourseFour);
            this.Controls.Add(this.grpCourseThree);
            this.Controls.Add(this.grpCourseTwo);
            this.Controls.Add(this.grpCourseOne);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.lblCumulativeGPA);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lstCreditValue);
            this.Controls.Add(this.lblAddCourse);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateGPA);
            this.Controls.Add(this.lstGradeRecieved);
            this.Controls.Add(this.lblCreditValue);
            this.Controls.Add(this.lblGradeRecieved);
            this.Controls.Add(this.lblCourseName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRapidGpaCalculator";
            this.Text = "Rapid GPA Calculator";
            this.Load += new System.EventHandler(this.frmRapidGpaCalculator_Load);
            this.grpCourseOne.ResumeLayout(false);
            this.grpCourseTwo.ResumeLayout(false);
            this.grpCourseThree.ResumeLayout(false);
            this.grpCourseFour.ResumeLayout(false);
            this.grpCourseFive.ResumeLayout(false);
            this.grpCourseSix.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblGradeRecieved;
        private System.Windows.Forms.Label lblCreditValue;
        private System.Windows.Forms.ComboBox lstGradeRecieved;
        private System.Windows.Forms.Button btnCalculateGPA;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button lblAddCourse;
        private System.Windows.Forms.ComboBox lstCreditValue;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCumulativeGPA;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnCourseOne;
        private System.Windows.Forms.Button btnCreditOne;
        private System.Windows.Forms.Button btnGradeOne;
        private System.Windows.Forms.GroupBox grpCourseOne;
        private System.Windows.Forms.GroupBox grpCourseTwo;
        private System.Windows.Forms.Button btnGradeTwo;
        private System.Windows.Forms.Button btnCreditTwo;
        private System.Windows.Forms.Button btnCourseTwo;
        private System.Windows.Forms.GroupBox grpCourseThree;
        private System.Windows.Forms.Button btnGradeThree;
        private System.Windows.Forms.Button btnCreditThree;
        private System.Windows.Forms.Button btnCourseThree;
        private System.Windows.Forms.GroupBox grpCourseFour;
        private System.Windows.Forms.Button btnGradeFour;
        private System.Windows.Forms.Button btnCreditFour;
        private System.Windows.Forms.Button btnCourseFour;
        private System.Windows.Forms.GroupBox grpCourseFive;
        private System.Windows.Forms.Button btnGradeFive;
        private System.Windows.Forms.Button btnCreditFive;
        private System.Windows.Forms.Button btnCourseFive;
        private System.Windows.Forms.GroupBox grpCourseSix;
        private System.Windows.Forms.Button btnGradeSix;
        private System.Windows.Forms.Button btnCreditSix;
        private System.Windows.Forms.Button btnCourseSix;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Label lblGrade;
    }
}

