namespace Desktop
{
    partial class AdminHome
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
            crsTopBTN = new Button();
            examQuReport = new Button();
            stdAnsBTN = new Button();
            insCrsBTN = new Button();
            stdGradeBTN = new Button();
            stdDeptBTN = new Button();
            logOutBTN = new Button();
            SuspendLayout();
            // 
            // crsTopBTN
            // 
            crsTopBTN.Cursor = Cursors.Hand;
            crsTopBTN.Font = new Font("Segoe UI", 25F);
            crsTopBTN.Location = new Point(12, 606);
            crsTopBTN.Name = "crsTopBTN";
            crsTopBTN.Size = new Size(626, 349);
            crsTopBTN.TabIndex = 1;
            crsTopBTN.Text = "Course and its Topics Report";
            crsTopBTN.UseVisualStyleBackColor = true;
            crsTopBTN.Click += crsTopBTN_Click;
            // 
            // examQuReport
            // 
            examQuReport.Cursor = Cursors.Hand;
            examQuReport.Font = new Font("Segoe UI", 25F);
            examQuReport.Location = new Point(638, 606);
            examQuReport.Name = "examQuReport";
            examQuReport.Size = new Size(626, 349);
            examQuReport.TabIndex = 3;
            examQuReport.Text = "Exam's Questions Report";
            examQuReport.UseVisualStyleBackColor = true;
            examQuReport.Click += examQuReport_Click;
            // 
            // stdAnsBTN
            // 
            stdAnsBTN.Cursor = Cursors.Hand;
            stdAnsBTN.Font = new Font("Segoe UI", 25F);
            stdAnsBTN.Location = new Point(1264, 606);
            stdAnsBTN.Name = "stdAnsBTN";
            stdAnsBTN.Size = new Size(626, 349);
            stdAnsBTN.TabIndex = 5;
            stdAnsBTN.Text = "Student's Answer Report";
            stdAnsBTN.UseVisualStyleBackColor = true;
            stdAnsBTN.Click += stdAnsBTN_Click;
            // 
            // insCrsBTN
            // 
            insCrsBTN.Cursor = Cursors.Hand;
            insCrsBTN.Font = new Font("Segoe UI", 25F);
            insCrsBTN.Location = new Point(1264, 78);
            insCrsBTN.Name = "insCrsBTN";
            insCrsBTN.Size = new Size(626, 390);
            insCrsBTN.TabIndex = 9;
            insCrsBTN.Text = "Instructor's Courses and Students Report";
            insCrsBTN.UseVisualStyleBackColor = true;
            insCrsBTN.Click += insCrsBTN_Click;
            // 
            // stdGradeBTN
            // 
            stdGradeBTN.Cursor = Cursors.Hand;
            stdGradeBTN.Font = new Font("Segoe UI", 25F);
            stdGradeBTN.Location = new Point(638, 78);
            stdGradeBTN.Name = "stdGradeBTN";
            stdGradeBTN.Size = new Size(626, 390);
            stdGradeBTN.TabIndex = 8;
            stdGradeBTN.Text = "Student's Courses Grade Report";
            stdGradeBTN.UseVisualStyleBackColor = true;
            stdGradeBTN.Click += stdGradeBTN_Click;
            // 
            // stdDeptBTN
            // 
            stdDeptBTN.Cursor = Cursors.Hand;
            stdDeptBTN.Font = new Font("Segoe UI", 25F);
            stdDeptBTN.Location = new Point(12, 78);
            stdDeptBTN.Name = "stdDeptBTN";
            stdDeptBTN.Size = new Size(626, 390);
            stdDeptBTN.TabIndex = 7;
            stdDeptBTN.Text = "Students in a Department Report";
            stdDeptBTN.UseVisualStyleBackColor = true;
            stdDeptBTN.Click += stdDeptBTN_Click;
            // 
            // logOutBTN
            // 
            logOutBTN.BackColor = Color.Red;
            logOutBTN.Cursor = Cursors.Hand;
            logOutBTN.FlatAppearance.BorderColor = Color.Red;
            logOutBTN.Font = new Font("Segoe UI", 22F);
            logOutBTN.ForeColor = Color.White;
            logOutBTN.Location = new Point(1264, 12);
            logOutBTN.Name = "logOutBTN";
            logOutBTN.Size = new Size(626, 60);
            logOutBTN.TabIndex = 10;
            logOutBTN.Text = "Log Out";
            logOutBTN.UseVisualStyleBackColor = false;
            logOutBTN.Click += logOutBTN_Click;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(logOutBTN);
            Controls.Add(insCrsBTN);
            Controls.Add(stdGradeBTN);
            Controls.Add(stdDeptBTN);
            Controls.Add(stdAnsBTN);
            Controls.Add(examQuReport);
            Controls.Add(crsTopBTN);
            Name = "AdminHome";
            Text = "Admin Home";
            FormClosed += AdminHome_FormClosed;
            ResumeLayout(false);
        }

        #endregion
        private Button crsTopBTN;
        private Button examQuReport;
        private Button stdAnsBTN;
        private Button insCrsBTN;
        private Button stdGradeBTN;
        private Button stdDeptBTN;
        private Button logOutBTN;
    }
}