namespace Desktop.Admin.StudentDepartmentForm
{
    partial class StudentDepartmentForm
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
            topicDATA = new DataGridView();
            deptLBL = new Label();
            deptLIST = new ComboBox();
            showBTN = new Button();
            emailTXT = new RichTextBox();
            nameTXT = new RichTextBox();
            emailLBL = new Label();
            nameLBL = new Label();
            dobTXT = new RichTextBox();
            addressTXT = new RichTextBox();
            dobLBL = new Label();
            addressLBL = new Label();
            salaryTXT = new RichTextBox();
            phoneTXT = new RichTextBox();
            salaryLBL = new Label();
            phoneLBL = new Label();
            collegeTXT = new RichTextBox();
            collegeLBL = new Label();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            topicDATA.DefaultCellStyle = dataGridViewCellStyle1;
            topicDATA.Location = new Point(12, 94);
            topicDATA.Name = "topicDATA";
            topicDATA.ReadOnly = true;
            topicDATA.RowHeadersWidth = 51;
            topicDATA.Size = new Size(1156, 927);
            topicDATA.TabIndex = 12;
            topicDATA.CellDoubleClick += topicDATA_CellDoubleClick;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            deptLBL.Location = new Point(1174, 9);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(264, 57);
            deptLBL.TabIndex = 16;
            deptLBL.Text = "Department";
            // 
            // deptLIST
            // 
            deptLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            deptLIST.Font = new Font("Segoe UI", 25F);
            deptLIST.FormattingEnabled = true;
            deptLIST.Location = new Point(1174, 69);
            deptLIST.Name = "deptLIST";
            deptLIST.Size = new Size(716, 65);
            deptLIST.TabIndex = 17;
            // 
            // showBTN
            // 
            showBTN.Font = new Font("Segoe UI", 25F);
            showBTN.Location = new Point(1174, 896);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 125);
            showBTN.TabIndex = 18;
            showBTN.Text = "Get Students";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // emailTXT
            // 
            emailTXT.BackColor = SystemColors.Control;
            emailTXT.BorderStyle = BorderStyle.None;
            emailTXT.Font = new Font("Segoe UI", 20F);
            emailTXT.Location = new Point(1221, 292);
            emailTXT.Name = "emailTXT";
            emailTXT.ReadOnly = true;
            emailTXT.Size = new Size(669, 54);
            emailTXT.TabIndex = 22;
            emailTXT.Text = "";
            emailTXT.MouseDown += idTXT_MouseDown;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = SystemColors.Control;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 20F);
            nameTXT.Location = new Point(1221, 186);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(669, 54);
            nameTXT.TabIndex = 21;
            nameTXT.Text = "";
            nameTXT.MouseDown += idTXT_MouseDown;
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            emailLBL.Location = new Point(1174, 243);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(107, 46);
            emailLBL.TabIndex = 20;
            emailLBL.Text = "Email";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nameLBL.Location = new Point(1174, 137);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(114, 46);
            nameLBL.TabIndex = 19;
            nameLBL.Text = "Name";
            // 
            // dobTXT
            // 
            dobTXT.BackColor = SystemColors.Control;
            dobTXT.BorderStyle = BorderStyle.None;
            dobTXT.Font = new Font("Segoe UI", 20F);
            dobTXT.Location = new Point(1221, 504);
            dobTXT.Name = "dobTXT";
            dobTXT.ReadOnly = true;
            dobTXT.Size = new Size(669, 54);
            dobTXT.TabIndex = 26;
            dobTXT.Text = "";
            dobTXT.MouseDown += idTXT_Mouse;
            // 
            // addressTXT
            // 
            addressTXT.BackColor = SystemColors.Control;
            addressTXT.BorderStyle = BorderStyle.None;
            addressTXT.Font = new Font("Segoe UI", 20F);
            addressTXT.Location = new Point(1221, 398);
            addressTXT.Name = "addressTXT";
            addressTXT.ReadOnly = true;
            addressTXT.Size = new Size(669, 54);
            addressTXT.TabIndex = 25;
            addressTXT.Text = "";
            addressTXT.MouseDown += idTXT_Mouse;
            // 
            // dobLBL
            // 
            dobLBL.AutoSize = true;
            dobLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            dobLBL.Location = new Point(1174, 455);
            dobLBL.Name = "dobLBL";
            dobLBL.Size = new Size(93, 46);
            dobLBL.TabIndex = 24;
            dobLBL.Text = "DOB";
            // 
            // addressLBL
            // 
            addressLBL.AutoSize = true;
            addressLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            addressLBL.Location = new Point(1174, 349);
            addressLBL.Name = "addressLBL";
            addressLBL.Size = new Size(148, 46);
            addressLBL.TabIndex = 23;
            addressLBL.Text = "Address";
            // 
            // salaryTXT
            // 
            salaryTXT.BackColor = SystemColors.Control;
            salaryTXT.BorderStyle = BorderStyle.None;
            salaryTXT.Font = new Font("Segoe UI", 20F);
            salaryTXT.Location = new Point(1221, 716);
            salaryTXT.Name = "salaryTXT";
            salaryTXT.ReadOnly = true;
            salaryTXT.Size = new Size(669, 54);
            salaryTXT.TabIndex = 30;
            salaryTXT.Text = "";
            salaryTXT.MouseDown += idTXT_Mouse;
            // 
            // phoneTXT
            // 
            phoneTXT.BackColor = SystemColors.Control;
            phoneTXT.BorderStyle = BorderStyle.None;
            phoneTXT.Font = new Font("Segoe UI", 20F);
            phoneTXT.Location = new Point(1221, 610);
            phoneTXT.Name = "phoneTXT";
            phoneTXT.ReadOnly = true;
            phoneTXT.Size = new Size(669, 54);
            phoneTXT.TabIndex = 29;
            phoneTXT.Text = "";
            phoneTXT.MouseDown += idTXT_Mouse;
            // 
            // salaryLBL
            // 
            salaryLBL.AutoSize = true;
            salaryLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            salaryLBL.Location = new Point(1174, 667);
            salaryLBL.Name = "salaryLBL";
            salaryLBL.Size = new Size(118, 46);
            salaryLBL.TabIndex = 28;
            salaryLBL.Text = "Salary";
            // 
            // phoneLBL
            // 
            phoneLBL.AutoSize = true;
            phoneLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            phoneLBL.Location = new Point(1174, 561);
            phoneLBL.Name = "phoneLBL";
            phoneLBL.Size = new Size(121, 46);
            phoneLBL.TabIndex = 27;
            phoneLBL.Text = "Phone";
            // 
            // collegeTXT
            // 
            collegeTXT.BackColor = SystemColors.Control;
            collegeTXT.BorderStyle = BorderStyle.None;
            collegeTXT.Font = new Font("Segoe UI", 20F);
            collegeTXT.Location = new Point(1221, 822);
            collegeTXT.Name = "collegeTXT";
            collegeTXT.ReadOnly = true;
            collegeTXT.Size = new Size(669, 54);
            collegeTXT.TabIndex = 33;
            collegeTXT.Text = "";
            collegeTXT.MouseDown += idTXT_Mouse;
            // 
            // collegeLBL
            // 
            collegeLBL.AutoSize = true;
            collegeLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            collegeLBL.Location = new Point(1174, 773);
            collegeLBL.Name = "collegeLBL";
            collegeLBL.Size = new Size(139, 46);
            collegeLBL.TabIndex = 31;
            collegeLBL.Text = "College";
            // 
            // StudentDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(collegeTXT);
            Controls.Add(collegeLBL);
            Controls.Add(salaryTXT);
            Controls.Add(phoneTXT);
            Controls.Add(salaryLBL);
            Controls.Add(phoneLBL);
            Controls.Add(dobTXT);
            Controls.Add(addressTXT);
            Controls.Add(dobLBL);
            Controls.Add(addressLBL);
            Controls.Add(emailTXT);
            Controls.Add(nameTXT);
            Controls.Add(emailLBL);
            Controls.Add(nameLBL);
            Controls.Add(showBTN);
            Controls.Add(deptLIST);
            Controls.Add(deptLBL);
            Controls.Add(returnBTN);
            Controls.Add(topicDATA);
            Name = "StudentDepartmentForm";
            Text = "CourseTopicForm";
            FormClosed += CourseTopicForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private DataGridView topicDATA;
        private Label deptLBL;
        private ComboBox deptLIST;
        private Button showBTN;
        private RichTextBox emailTXT;
        private RichTextBox nameTXT;
        private Label emailLBL;
        private Label nameLBL;
        private RichTextBox dobTXT;
        private RichTextBox addressTXT;
        private Label dobLBL;
        private Label addressLBL;
        private RichTextBox salaryTXT;
        private RichTextBox phoneTXT;
        private Label salaryLBL;
        private Label phoneLBL;
        private RichTextBox collegeTXT;
        private Label collegeLBL;
    }
}