namespace Desktop
{
    partial class InstructorHome
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
            courseDATA = new DataGridView();
            questionBTN = new Button();
            examBTN = new Button();
            studentBTN = new Button();
            selectedLBL = new Label();
            idLBL = new Label();
            nameLBL = new Label();
            searchTXT = new TextBox();
            refreshBTN = new Button();
            button1 = new Button();
            idTXT = new RichTextBox();
            nameTXT = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)courseDATA).BeginInit();
            SuspendLayout();
            // 
            // courseDATA
            // 
            courseDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            courseDATA.DefaultCellStyle = dataGridViewCellStyle1;
            courseDATA.Location = new Point(12, 163);
            courseDATA.Name = "courseDATA";
            courseDATA.ReadOnly = true;
            courseDATA.RowHeadersWidth = 51;
            courseDATA.Size = new Size(1156, 858);
            courseDATA.TabIndex = 0;
            courseDATA.CellDoubleClick += courseDATA_CellDoubleClick;
            // 
            // questionBTN
            // 
            questionBTN.Enabled = false;
            questionBTN.Font = new Font("Segoe UI", 25F);
            questionBTN.Location = new Point(1174, 607);
            questionBTN.Name = "questionBTN";
            questionBTN.Size = new Size(716, 134);
            questionBTN.TabIndex = 3;
            questionBTN.Text = "Questions";
            questionBTN.UseVisualStyleBackColor = true;
            questionBTN.Click += questionBTN_Click;
            // 
            // examBTN
            // 
            examBTN.Enabled = false;
            examBTN.Font = new Font("Segoe UI", 25F);
            examBTN.Location = new Point(1174, 747);
            examBTN.Name = "examBTN";
            examBTN.Size = new Size(716, 134);
            examBTN.TabIndex = 4;
            examBTN.Text = "Exams";
            examBTN.UseVisualStyleBackColor = true;
            examBTN.Click += examBTN_Click;
            // 
            // studentBTN
            // 
            studentBTN.Enabled = false;
            studentBTN.Font = new Font("Segoe UI", 25F);
            studentBTN.Location = new Point(1174, 887);
            studentBTN.Name = "studentBTN";
            studentBTN.Size = new Size(716, 134);
            studentBTN.TabIndex = 5;
            studentBTN.Text = "Students";
            studentBTN.UseVisualStyleBackColor = true;
            studentBTN.Click += studentBTN_Click;
            // 
            // selectedLBL
            // 
            selectedLBL.AutoSize = true;
            selectedLBL.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            selectedLBL.Location = new Point(1174, 100);
            selectedLBL.Name = "selectedLBL";
            selectedLBL.Size = new Size(339, 57);
            selectedLBL.TabIndex = 6;
            selectedLBL.Text = "Selected Course";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            idLBL.Location = new Point(1174, 183);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(56, 46);
            idLBL.TabIndex = 7;
            idLBL.Text = "ID";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nameLBL.Location = new Point(1174, 355);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(114, 46);
            nameLBL.TabIndex = 8;
            nameLBL.Text = "Name";
            // 
            // searchTXT
            // 
            searchTXT.Font = new Font("Segoe UI", 25F);
            searchTXT.Location = new Point(12, 94);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(1156, 63);
            searchTXT.TabIndex = 9;
            searchTXT.TextChanged += searchTXT_TextChanged;
            // 
            // refreshBTN
            // 
            refreshBTN.Font = new Font("Segoe UI", 25F);
            refreshBTN.Location = new Point(12, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(578, 76);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(590, 12);
            button1.Name = "button1";
            button1.Size = new Size(578, 76);
            button1.TabIndex = 11;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idTXT
            // 
            idTXT.BackColor = SystemColors.Control;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 20F);
            idTXT.Location = new Point(1221, 232);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(669, 120);
            idTXT.TabIndex = 12;
            idTXT.Text = "";
            idTXT.Enter += idTXT_Enter;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = SystemColors.Control;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 20F);
            nameTXT.Location = new Point(1221, 432);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(669, 120);
            nameTXT.TabIndex = 13;
            nameTXT.Text = "";
            nameTXT.Enter += nameTXT_Enter;
            // 
            // InstructorHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(nameTXT);
            Controls.Add(idTXT);
            Controls.Add(button1);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
            Controls.Add(nameLBL);
            Controls.Add(idLBL);
            Controls.Add(selectedLBL);
            Controls.Add(studentBTN);
            Controls.Add(examBTN);
            Controls.Add(questionBTN);
            Controls.Add(courseDATA);
            Name = "InstructorHome";
            Text = "Instructor Home";
            FormClosed += InstructorHome_FormClosed;
            ((System.ComponentModel.ISupportInitialize)courseDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView courseDATA;
        private Button questionBTN;
        private Button examBTN;
        private Button studentBTN;
        private Label selectedLBL;
        private Label idLBL;
        private Label nameLBL;
        private TextBox searchTXT;
        private Button refreshBTN;
        private Button button1;
        private RichTextBox idTXT;
        private RichTextBox nameTXT;
    }
}