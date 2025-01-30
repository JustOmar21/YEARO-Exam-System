namespace Desktop.InstructorForms.Exams
{
    partial class ExamStudentsForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            returnBTN = new Button();
            refreshBTN = new Button();
            studentDATA = new DataGridView();
            idTXT = new TextBox();
            answersBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)studentDATA).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.Font = new Font("Segoe UI", 20F);
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(667, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(655, 62);
            returnBTN.TabIndex = 21;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // refreshBTN
            // 
            refreshBTN.Font = new Font("Segoe UI", 20F);
            refreshBTN.Location = new Point(12, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(655, 62);
            refreshBTN.TabIndex = 20;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // studentDATA
            // 
            studentDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            studentDATA.DefaultCellStyle = dataGridViewCellStyle1;
            studentDATA.Location = new Point(12, 80);
            studentDATA.Name = "studentDATA";
            studentDATA.ReadOnly = true;
            studentDATA.RowHeadersWidth = 51;
            studentDATA.Size = new Size(1310, 948);
            studentDATA.TabIndex = 12;
            studentDATA.CellMouseDoubleClick += questionDATA_CellMouseDoubleClick;
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(717, 212);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 27);
            idTXT.TabIndex = 48;
            idTXT.Visible = false;
            // 
            // answersBTN
            // 
            answersBTN.Enabled = false;
            answersBTN.Font = new Font("Segoe UI", 25F);
            answersBTN.Location = new Point(1328, 952);
            answersBTN.Name = "answersBTN";
            answersBTN.Size = new Size(562, 76);
            answersBTN.TabIndex = 49;
            answersBTN.Text = "View Answers";
            answersBTN.UseVisualStyleBackColor = true;
            answersBTN.Click += answersBTN_Click;
            // 
            // ExamStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(answersBTN);
            Controls.Add(idTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(studentDATA);
            Name = "ExamStudentsForm";
            Text = "Question";
            FormClosed += QuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)studentDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private DataGridView studentDATA;
        private TextBox idTXT;
        private Button answersBTN;
    }
}