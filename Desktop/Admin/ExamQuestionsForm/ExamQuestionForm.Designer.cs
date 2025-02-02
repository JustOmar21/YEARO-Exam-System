namespace Desktop.Admin.ExamQuestionsForm
{
    partial class ExamQuestionForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            showBTN = new Button();
            examLIST = new ComboBox();
            examLBL = new Label();
            returnBTN = new Button();
            questionsDATA = new DataGridView();
            courseLIST = new ComboBox();
            courseLBL = new Label();
            correctChoice4 = new Button();
            correctChoice3 = new Button();
            correctChoice2 = new Button();
            correctChoice1 = new Button();
            choice4LBL = new Label();
            choice4TXT = new RichTextBox();
            choice3LBL = new Label();
            choice3TXT = new RichTextBox();
            choice2LBL = new Label();
            choice2TXT = new RichTextBox();
            choice1LBL = new Label();
            choice1TXT = new RichTextBox();
            label3 = new Label();
            degreeNUM = new NumericUpDown();
            label2 = new Label();
            bodyTXT = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)questionsDATA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).BeginInit();
            SuspendLayout();
            // 
            // showBTN
            // 
            showBTN.Enabled = false;
            showBTN.Font = new Font("Segoe UI", 25F);
            showBTN.Location = new Point(1174, 887);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 134);
            showBTN.TabIndex = 27;
            showBTN.Text = "Get Questions";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // examLIST
            // 
            examLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            examLIST.Font = new Font("Segoe UI", 15F);
            examLIST.FormattingEnabled = true;
            examLIST.Location = new Point(1174, 165);
            examLIST.Name = "examLIST";
            examLIST.Size = new Size(716, 43);
            examLIST.TabIndex = 26;
            // 
            // examLBL
            // 
            examLBL.AutoSize = true;
            examLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            examLBL.Location = new Point(1174, 112);
            examLBL.Name = "examLBL";
            examLBL.Size = new Size(106, 46);
            examLBL.TabIndex = 25;
            examLBL.Text = "Exam";
            // 
            // returnBTN
            // 
            returnBTN.Font = new Font("Segoe UI", 25F);
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(1156, 76);
            returnBTN.TabIndex = 24;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // questionsDATA
            // 
            questionsDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            questionsDATA.DefaultCellStyle = dataGridViewCellStyle3;
            questionsDATA.Location = new Point(12, 94);
            questionsDATA.Name = "questionsDATA";
            questionsDATA.ReadOnly = true;
            questionsDATA.RowHeadersWidth = 51;
            questionsDATA.Size = new Size(1156, 927);
            questionsDATA.TabIndex = 23;
            questionsDATA.CellDoubleClick += questionsDATA_CellDoubleClick;
            // 
            // courseLIST
            // 
            courseLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            courseLIST.Font = new Font("Segoe UI", 15F);
            courseLIST.FormattingEnabled = true;
            courseLIST.Location = new Point(1174, 62);
            courseLIST.Name = "courseLIST";
            courseLIST.Size = new Size(716, 43);
            courseLIST.TabIndex = 33;
            courseLIST.SelectedIndexChanged += courseLIST_SelectedIndexChanged;
            // 
            // courseLBL
            // 
            courseLBL.AutoSize = true;
            courseLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            courseLBL.Location = new Point(1174, 9);
            courseLBL.Name = "courseLBL";
            courseLBL.Size = new Size(130, 46);
            courseLBL.TabIndex = 32;
            courseLBL.Text = "Course";
            // 
            // correctChoice4
            // 
            correctChoice4.BackColor = Color.White;
            correctChoice4.Cursor = Cursors.Hand;
            correctChoice4.Enabled = false;
            correctChoice4.FlatAppearance.BorderColor = Color.Brown;
            correctChoice4.Location = new Point(1814, 765);
            correctChoice4.Name = "correctChoice4";
            correctChoice4.Size = new Size(84, 69);
            correctChoice4.TabIndex = 63;
            correctChoice4.UseVisualStyleBackColor = false;
            // 
            // correctChoice3
            // 
            correctChoice3.BackColor = Color.White;
            correctChoice3.Cursor = Cursors.Hand;
            correctChoice3.Enabled = false;
            correctChoice3.FlatAppearance.BorderColor = Color.Brown;
            correctChoice3.Location = new Point(1449, 765);
            correctChoice3.Name = "correctChoice3";
            correctChoice3.Size = new Size(84, 69);
            correctChoice3.TabIndex = 62;
            correctChoice3.UseVisualStyleBackColor = false;
            // 
            // correctChoice2
            // 
            correctChoice2.BackColor = Color.White;
            correctChoice2.Cursor = Cursors.Hand;
            correctChoice2.Enabled = false;
            correctChoice2.FlatAppearance.BorderColor = Color.Brown;
            correctChoice2.Location = new Point(1814, 644);
            correctChoice2.Name = "correctChoice2";
            correctChoice2.Size = new Size(84, 69);
            correctChoice2.TabIndex = 61;
            correctChoice2.UseVisualStyleBackColor = false;
            // 
            // correctChoice1
            // 
            correctChoice1.BackColor = Color.Green;
            correctChoice1.Cursor = Cursors.Hand;
            correctChoice1.Enabled = false;
            correctChoice1.FlatAppearance.BorderColor = Color.Brown;
            correctChoice1.Location = new Point(1449, 644);
            correctChoice1.Name = "correctChoice1";
            correctChoice1.Size = new Size(84, 69);
            correctChoice1.TabIndex = 60;
            correctChoice1.UseVisualStyleBackColor = false;
            // 
            // choice4LBL
            // 
            choice4LBL.AutoSize = true;
            choice4LBL.Font = new Font("Segoe UI", 20F);
            choice4LBL.Location = new Point(1539, 716);
            choice4LBL.Name = "choice4LBL";
            choice4LBL.Size = new Size(149, 46);
            choice4LBL.TabIndex = 59;
            choice4LBL.Text = "Choice 4";
            // 
            // choice4TXT
            // 
            choice4TXT.Font = new Font("Segoe UI", 15F);
            choice4TXT.Location = new Point(1539, 765);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.ReadOnly = true;
            choice4TXT.Size = new Size(269, 69);
            choice4TXT.TabIndex = 58;
            choice4TXT.Text = "";
            // 
            // choice3LBL
            // 
            choice3LBL.AutoSize = true;
            choice3LBL.Font = new Font("Segoe UI", 20F);
            choice3LBL.Location = new Point(1174, 716);
            choice3LBL.Name = "choice3LBL";
            choice3LBL.Size = new Size(149, 46);
            choice3LBL.TabIndex = 57;
            choice3LBL.Text = "Choice 3";
            // 
            // choice3TXT
            // 
            choice3TXT.Font = new Font("Segoe UI", 15F);
            choice3TXT.Location = new Point(1174, 765);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.ReadOnly = true;
            choice3TXT.Size = new Size(269, 69);
            choice3TXT.TabIndex = 56;
            choice3TXT.Text = "";
            // 
            // choice2LBL
            // 
            choice2LBL.AutoSize = true;
            choice2LBL.Font = new Font("Segoe UI", 20F);
            choice2LBL.Location = new Point(1539, 591);
            choice2LBL.Name = "choice2LBL";
            choice2LBL.Size = new Size(149, 46);
            choice2LBL.TabIndex = 55;
            choice2LBL.Text = "Choice 2";
            // 
            // choice2TXT
            // 
            choice2TXT.Font = new Font("Segoe UI", 15F);
            choice2TXT.Location = new Point(1539, 644);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.ReadOnly = true;
            choice2TXT.Size = new Size(269, 69);
            choice2TXT.TabIndex = 54;
            choice2TXT.Text = "";
            // 
            // choice1LBL
            // 
            choice1LBL.AutoSize = true;
            choice1LBL.Font = new Font("Segoe UI", 20F);
            choice1LBL.Location = new Point(1174, 591);
            choice1LBL.Name = "choice1LBL";
            choice1LBL.Size = new Size(149, 46);
            choice1LBL.TabIndex = 53;
            choice1LBL.Text = "Choice 1";
            // 
            // choice1TXT
            // 
            choice1TXT.Font = new Font("Segoe UI", 15F);
            choice1TXT.Location = new Point(1174, 644);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.ReadOnly = true;
            choice1TXT.Size = new Size(269, 69);
            choice1TXT.TabIndex = 52;
            choice1TXT.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(1174, 392);
            label3.Name = "label3";
            label3.Size = new Size(130, 46);
            label3.TabIndex = 51;
            label3.Text = "Degree";
            // 
            // degreeNUM
            // 
            degreeNUM.Font = new Font("Segoe UI", 25F);
            degreeNUM.Location = new Point(1174, 445);
            degreeNUM.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            degreeNUM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            degreeNUM.Name = "degreeNUM";
            degreeNUM.ReadOnly = true;
            degreeNUM.Size = new Size(716, 63);
            degreeNUM.TabIndex = 50;
            degreeNUM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1174, 218);
            label2.Name = "label2";
            label2.Size = new Size(95, 46);
            label2.TabIndex = 49;
            label2.Text = "Body";
            // 
            // bodyTXT
            // 
            bodyTXT.Font = new Font("Segoe UI", 15F);
            bodyTXT.Location = new Point(1174, 271);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.ReadOnly = true;
            bodyTXT.Size = new Size(716, 114);
            bodyTXT.TabIndex = 48;
            bodyTXT.Text = "";
            // 
            // ExamQuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(correctChoice4);
            Controls.Add(correctChoice3);
            Controls.Add(correctChoice2);
            Controls.Add(correctChoice1);
            Controls.Add(choice4LBL);
            Controls.Add(choice4TXT);
            Controls.Add(choice3LBL);
            Controls.Add(choice3TXT);
            Controls.Add(choice2LBL);
            Controls.Add(choice2TXT);
            Controls.Add(choice1LBL);
            Controls.Add(choice1TXT);
            Controls.Add(label3);
            Controls.Add(degreeNUM);
            Controls.Add(label2);
            Controls.Add(bodyTXT);
            Controls.Add(courseLIST);
            Controls.Add(courseLBL);
            Controls.Add(showBTN);
            Controls.Add(examLIST);
            Controls.Add(examLBL);
            Controls.Add(returnBTN);
            Controls.Add(questionsDATA);
            Name = "ExamQuestionForm";
            Text = "ExamQuestionForm";
            FormClosed += ExamQuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)questionsDATA).EndInit();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button showBTN;
        private ComboBox examLIST;
        private Label examLBL;
        private Button returnBTN;
        private DataGridView questionsDATA;
        private ComboBox courseLIST;
        private Label courseLBL;
        private Button correctChoice4;
        private Button correctChoice3;
        private Button correctChoice2;
        private Button correctChoice1;
        private Label choice4LBL;
        private RichTextBox choice4TXT;
        private Label choice3LBL;
        private RichTextBox choice3TXT;
        private Label choice2LBL;
        private RichTextBox choice2TXT;
        private Label choice1LBL;
        private RichTextBox choice1TXT;
        private Label label3;
        private NumericUpDown degreeNUM;
        private Label label2;
        private RichTextBox bodyTXT;
    }
}