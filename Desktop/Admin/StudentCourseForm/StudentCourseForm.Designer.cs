namespace Desktop.Admin.StudentCourseForm
{
    partial class StudentCourseForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            returnBTN = new Button();
            topicDATA = new DataGridView();
            studentLBL = new Label();
            studentLIST = new ComboBox();
            showBTN = new Button();
            nameTXT = new RichTextBox();
            idTXT = new RichTextBox();
            nameLBL = new Label();
            idLBL = new Label();
            ((System.ComponentModel.ISupportInitialize)topicDATA).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.Font = new Font("Segoe UI", 25F);
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(1156, 76);
            returnBTN.TabIndex = 15;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // topicDATA
            // 
            topicDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            topicDATA.DefaultCellStyle = dataGridViewCellStyle2;
            topicDATA.Location = new Point(12, 94);
            topicDATA.Name = "topicDATA";
            topicDATA.ReadOnly = true;
            topicDATA.RowHeadersWidth = 51;
            topicDATA.Size = new Size(1156, 927);
            topicDATA.TabIndex = 12;
            topicDATA.CellDoubleClick += topicDATA_CellDoubleClick;
            // 
            // studentLBL
            // 
            studentLBL.AutoSize = true;
            studentLBL.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            studentLBL.Location = new Point(1174, 94);
            studentLBL.Name = "studentLBL";
            studentLBL.Size = new Size(179, 57);
            studentLBL.TabIndex = 16;
            studentLBL.Text = "Student";
            // 
            // studentLIST
            // 
            studentLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            studentLIST.Font = new Font("Segoe UI", 25F);
            studentLIST.FormattingEnabled = true;
            studentLIST.Location = new Point(1174, 168);
            studentLIST.Name = "studentLIST";
            studentLIST.Size = new Size(716, 65);
            studentLIST.TabIndex = 17;
            // 
            // showBTN
            // 
            showBTN.Font = new Font("Segoe UI", 25F);
            showBTN.Location = new Point(1174, 887);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 134);
            showBTN.TabIndex = 18;
            showBTN.Text = "Get Courses";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = SystemColors.Control;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 20F);
            nameTXT.Location = new Point(1221, 594);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(669, 120);
            nameTXT.TabIndex = 22;
            nameTXT.Text = "";
            nameTXT.MouseDown += idTXT_MouseDown;
            // 
            // idTXT
            // 
            idTXT.BackColor = SystemColors.Control;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 20F);
            idTXT.Location = new Point(1221, 394);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(669, 120);
            idTXT.TabIndex = 21;
            idTXT.Text = "";
            idTXT.MouseDown += idTXT_MouseDown;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nameLBL.Location = new Point(1174, 517);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(114, 46);
            nameLBL.TabIndex = 20;
            nameLBL.Text = "Name";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            idLBL.Location = new Point(1174, 345);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(56, 46);
            idLBL.TabIndex = 19;
            idLBL.Text = "ID";
            // 
            // StudentCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(nameTXT);
            Controls.Add(idTXT);
            Controls.Add(nameLBL);
            Controls.Add(idLBL);
            Controls.Add(showBTN);
            Controls.Add(studentLIST);
            Controls.Add(studentLBL);
            Controls.Add(returnBTN);
            Controls.Add(topicDATA);
            Name = "StudentCourseForm";
            Text = "CourseTopicForm";
            FormClosed += CourseTopicForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private DataGridView topicDATA;
        private Label studentLBL;
        private ComboBox studentLIST;
        private Button showBTN;
        private RichTextBox nameTXT;
        private RichTextBox idTXT;
        private Label nameLBL;
        private Label idLBL;
    }
}