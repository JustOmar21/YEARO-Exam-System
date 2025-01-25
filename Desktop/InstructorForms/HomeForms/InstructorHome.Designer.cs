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
            ((System.ComponentModel.ISupportInitialize)courseDATA).BeginInit();
            SuspendLayout();
            // 
            // courseDATA
            // 
            courseDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            courseDATA.Location = new Point(12, 80);
            courseDATA.Name = "courseDATA";
            courseDATA.RowHeadersWidth = 51;
            courseDATA.Size = new Size(540, 358);
            courseDATA.TabIndex = 0;
            courseDATA.CellDoubleClick += courseDATA_CellDoubleClick;
            // 
            // questionBTN
            // 
            questionBTN.Enabled = false;
            questionBTN.Location = new Point(558, 198);
            questionBTN.Name = "questionBTN";
            questionBTN.Size = new Size(230, 76);
            questionBTN.TabIndex = 3;
            questionBTN.Text = "Questions";
            questionBTN.UseVisualStyleBackColor = true;
            questionBTN.Click += questionBTN_Click;
            // 
            // examBTN
            // 
            examBTN.Enabled = false;
            examBTN.Location = new Point(558, 280);
            examBTN.Name = "examBTN";
            examBTN.Size = new Size(230, 76);
            examBTN.TabIndex = 4;
            examBTN.Text = "Exams";
            examBTN.UseVisualStyleBackColor = true;
            examBTN.Click += examBTN_Click;
            // 
            // studentBTN
            // 
            studentBTN.Enabled = false;
            studentBTN.Location = new Point(558, 362);
            studentBTN.Name = "studentBTN";
            studentBTN.Size = new Size(230, 76);
            studentBTN.TabIndex = 5;
            studentBTN.Text = "Students";
            studentBTN.UseVisualStyleBackColor = true;
            studentBTN.Click += studentBTN_Click;
            // 
            // selectedLBL
            // 
            selectedLBL.AutoSize = true;
            selectedLBL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            selectedLBL.Location = new Point(558, 13);
            selectedLBL.Name = "selectedLBL";
            selectedLBL.Size = new Size(162, 28);
            selectedLBL.TabIndex = 6;
            selectedLBL.Text = "Selected Course";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            idLBL.Location = new Point(558, 54);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(25, 20);
            idLBL.TabIndex = 7;
            idLBL.Text = "ID";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            nameLBL.Location = new Point(558, 117);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(51, 20);
            nameLBL.TabIndex = 8;
            nameLBL.Text = "Name";
            // 
            // searchTXT
            // 
            searchTXT.Location = new Point(12, 47);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(540, 27);
            searchTXT.TabIndex = 9;
            searchTXT.TextChanged += searchTXT_TextChanged;
            // 
            // refreshBTN
            // 
            refreshBTN.Location = new Point(12, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(270, 29);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(282, 12);
            button1.Name = "button1";
            button1.Size = new Size(270, 29);
            button1.TabIndex = 11;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // InstructorHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}