namespace Desktop.InstructorForms.Students
{
    partial class StudentsForm
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
            returnBTN = new Button();
            refreshBTN = new Button();
            searchTXT = new TextBox();
            studentDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentDATA).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(400, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(388, 29);
            returnBTN.TabIndex = 15;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // refreshBTN
            // 
            refreshBTN.Location = new Point(12, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(388, 29);
            refreshBTN.TabIndex = 14;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            // 
            // searchTXT
            // 
            searchTXT.Location = new Point(12, 47);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(776, 27);
            searchTXT.TabIndex = 13;
            searchTXT.TextChanged += searchTXT_TextChanged;
            // 
            // studentDATA
            // 
            studentDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDATA.Location = new Point(12, 80);
            studentDATA.Name = "studentDATA";
            studentDATA.RowHeadersWidth = 51;
            studentDATA.Size = new Size(776, 358);
            studentDATA.TabIndex = 12;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
            Controls.Add(studentDATA);
            Name = "StudentsForm";
            Text = "Students";
            FormClosed += StudentsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)studentDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private TextBox searchTXT;
        private DataGridView studentDATA;
    }
}