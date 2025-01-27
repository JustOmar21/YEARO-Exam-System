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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            returnBTN = new Button();
            refreshBTN = new Button();
            searchTXT = new TextBox();
            studentDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)studentDATA).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.Font = new Font("Segoe UI", 25F);
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(951, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(939, 85);
            returnBTN.TabIndex = 15;
            returnBTN.Text = "Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // refreshBTN
            // 
            refreshBTN.Font = new Font("Segoe UI", 25F);
            refreshBTN.Location = new Point(12, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(939, 85);
            refreshBTN.TabIndex = 14;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            // 
            // searchTXT
            // 
            searchTXT.Font = new Font("Segoe UI", 25F);
            searchTXT.Location = new Point(12, 94);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(1878, 63);
            searchTXT.TabIndex = 13;
            searchTXT.TextChanged += searchTXT_TextChanged;
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
            studentDATA.Location = new Point(12, 163);
            studentDATA.Name = "studentDATA";
            studentDATA.ReadOnly = true;
            studentDATA.RowHeadersWidth = 51;
            studentDATA.Size = new Size(1878, 858);
            studentDATA.TabIndex = 12;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(studentDATA);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
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