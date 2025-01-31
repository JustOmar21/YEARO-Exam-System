namespace Desktop.StudentForms.AnswersForm
{
    partial class AnswerForm
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
            prevBTN = new Button();
            nextBTN = new Button();
            timeLBL = new Label();
            timeTXT = new Label();
            choice1TXT = new RichTextBox();
            choice2TXT = new RichTextBox();
            choice3TXT = new RichTextBox();
            choice4TXT = new RichTextBox();
            bodyTXT = new RichTextBox();
            questionLBL = new Label();
            endBTN = new Button();
            SuspendLayout();
            // 
            // prevBTN
            // 
            prevBTN.Font = new Font("Segoe UI", 25F);
            prevBTN.Location = new Point(12, 12);
            prevBTN.Name = "prevBTN";
            prevBTN.Size = new Size(664, 88);
            prevBTN.TabIndex = 4;
            prevBTN.Text = "Previous Question";
            prevBTN.UseVisualStyleBackColor = true;
            prevBTN.Click += prevBTN_Click;
            // 
            // nextBTN
            // 
            nextBTN.Font = new Font("Segoe UI", 25F);
            nextBTN.Location = new Point(1226, 12);
            nextBTN.Name = "nextBTN";
            nextBTN.Size = new Size(664, 88);
            nextBTN.TabIndex = 5;
            nextBTN.Text = "Next Question";
            nextBTN.UseVisualStyleBackColor = true;
            nextBTN.Click += nextBTN_Click;
            // 
            // timeLBL
            // 
            timeLBL.AutoSize = true;
            timeLBL.Font = new Font("Segoe UI", 25F);
            timeLBL.Location = new Point(761, 103);
            timeLBL.Name = "timeLBL";
            timeLBL.Size = new Size(217, 57);
            timeLBL.TabIndex = 6;
            timeLBL.Text = "Time Left :";
            // 
            // timeTXT
            // 
            timeTXT.AutoSize = true;
            timeTXT.Font = new Font("Segoe UI", 25F);
            timeTXT.Location = new Point(984, 103);
            timeTXT.Name = "timeTXT";
            timeTXT.Size = new Size(158, 57);
            timeTXT.TabIndex = 7;
            timeTXT.Text = "1:00:00";
            // 
            // choice1TXT
            // 
            choice1TXT.BorderStyle = BorderStyle.FixedSingle;
            choice1TXT.Cursor = Cursors.Hand;
            choice1TXT.Font = new Font("Segoe UI", 15F);
            choice1TXT.Location = new Point(12, 520);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.ReadOnly = true;
            choice1TXT.Size = new Size(1878, 120);
            choice1TXT.TabIndex = 8;
            choice1TXT.Text = "";
            choice1TXT.MouseDown += choice1TXT_MouseDown;
            // 
            // choice2TXT
            // 
            choice2TXT.BorderStyle = BorderStyle.FixedSingle;
            choice2TXT.Cursor = Cursors.Hand;
            choice2TXT.Font = new Font("Segoe UI", 15F);
            choice2TXT.Location = new Point(12, 646);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.ReadOnly = true;
            choice2TXT.Size = new Size(1878, 120);
            choice2TXT.TabIndex = 9;
            choice2TXT.Text = "";
            choice2TXT.MouseDown += choice2TXT_MouseDown;
            // 
            // choice3TXT
            // 
            choice3TXT.BorderStyle = BorderStyle.FixedSingle;
            choice3TXT.Cursor = Cursors.Hand;
            choice3TXT.Font = new Font("Segoe UI", 15F);
            choice3TXT.Location = new Point(12, 772);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.ReadOnly = true;
            choice3TXT.Size = new Size(1878, 120);
            choice3TXT.TabIndex = 10;
            choice3TXT.Text = "";
            choice3TXT.MouseDown += choice3TXT_MouseDown;
            // 
            // choice4TXT
            // 
            choice4TXT.BorderStyle = BorderStyle.FixedSingle;
            choice4TXT.Cursor = Cursors.Hand;
            choice4TXT.Font = new Font("Segoe UI", 15F);
            choice4TXT.Location = new Point(12, 901);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.ReadOnly = true;
            choice4TXT.Size = new Size(1878, 120);
            choice4TXT.TabIndex = 11;
            choice4TXT.Text = "";
            choice4TXT.MouseDown += choice4TXT_MouseDown;
            // 
            // bodyTXT
            // 
            bodyTXT.BorderStyle = BorderStyle.FixedSingle;
            bodyTXT.Font = new Font("Segoe UI", 15F);
            bodyTXT.Location = new Point(12, 163);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.ReadOnly = true;
            bodyTXT.Size = new Size(1878, 350);
            bodyTXT.TabIndex = 12;
            bodyTXT.Text = "";
            bodyTXT.MouseDown += bodyTXT_MouseDown;
            // 
            // questionLBL
            // 
            questionLBL.AutoSize = true;
            questionLBL.BackColor = SystemColors.Control;
            questionLBL.Font = new Font("Segoe UI", 25F);
            questionLBL.Location = new Point(12, 103);
            questionLBL.Name = "questionLBL";
            questionLBL.Size = new Size(229, 57);
            questionLBL.TabIndex = 13;
            questionLBL.Text = "Question 0";
            // 
            // endBTN
            // 
            endBTN.BackColor = Color.Red;
            endBTN.Font = new Font("Segoe UI", 25F);
            endBTN.ForeColor = Color.White;
            endBTN.Location = new Point(682, 12);
            endBTN.Name = "endBTN";
            endBTN.Size = new Size(538, 88);
            endBTN.TabIndex = 14;
            endBTN.Text = "End Exam";
            endBTN.UseVisualStyleBackColor = false;
            endBTN.Click += endBTN_Click;
            // 
            // AnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(endBTN);
            Controls.Add(questionLBL);
            Controls.Add(bodyTXT);
            Controls.Add(choice4TXT);
            Controls.Add(choice3TXT);
            Controls.Add(choice2TXT);
            Controls.Add(choice1TXT);
            Controls.Add(timeTXT);
            Controls.Add(timeLBL);
            Controls.Add(nextBTN);
            Controls.Add(prevBTN);
            Name = "AnswerForm";
            Text = "AnswerForm";
            FormClosed += AnswerForm_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button prevBTN;
        private Button nextBTN;
        private Label timeLBL;
        private Label timeTXT;
        private RichTextBox choice1TXT;
        private RichTextBox choice2TXT;
        private RichTextBox choice3TXT;
        private RichTextBox choice4TXT;
        private RichTextBox bodyTXT;
        private Label questionLBL;
        private Button endBTN;
    }
}