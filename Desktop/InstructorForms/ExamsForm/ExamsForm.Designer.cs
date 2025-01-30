namespace Desktop.InstructorForms.Exams
{
    partial class ExamsForm
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
            idTXT = new TextBox();
            dateLBL = new Label();
            nameLBL = new Label();
            nameTXT = new RichTextBox();
            returnBTN = new Button();
            refreshBTN = new Button();
            examDATA = new DataGridView();
            insertBTN = new Button();
            endViewBTN = new Button();
            deleteBTN = new Button();
            datePICK = new DateTimePicker();
            updateBTN = new Button();
            studentsBTN = new Button();
            questionsBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)examDATA).BeginInit();
            SuspendLayout();
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(717, 212);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 27);
            idTXT.TabIndex = 70;
            idTXT.Visible = false;
            // 
            // dateLBL
            // 
            dateLBL.AutoSize = true;
            dateLBL.Font = new Font("Segoe UI", 20F);
            dateLBL.Location = new Point(1328, 478);
            dateLBL.Name = "dateLBL";
            dateLBL.Size = new Size(238, 46);
            dateLBL.TabIndex = 61;
            dateLBL.Text = "Date and Time";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI", 20F);
            nameLBL.Location = new Point(1328, 195);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(109, 46);
            nameLBL.TabIndex = 59;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.Font = new Font("Segoe UI", 15F);
            nameTXT.Location = new Point(1328, 289);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(562, 69);
            nameTXT.TabIndex = 58;
            nameTXT.Text = "";
            // 
            // returnBTN
            // 
            returnBTN.Font = new Font("Segoe UI", 20F);
            returnBTN.ForeColor = SystemColors.ControlText;
            returnBTN.Location = new Point(667, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(655, 62);
            returnBTN.TabIndex = 51;
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
            refreshBTN.TabIndex = 50;
            refreshBTN.Text = "Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // examDATA
            // 
            examDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            examDATA.DefaultCellStyle = dataGridViewCellStyle1;
            examDATA.Location = new Point(12, 80);
            examDATA.Name = "examDATA";
            examDATA.ReadOnly = true;
            examDATA.RowHeadersWidth = 51;
            examDATA.Size = new Size(1310, 948);
            examDATA.TabIndex = 49;
            examDATA.CellDoubleClick += examDATA_CellDoubleClick;
            // 
            // insertBTN
            // 
            insertBTN.Font = new Font("Segoe UI", 25F);
            insertBTN.Location = new Point(1328, 952);
            insertBTN.Name = "insertBTN";
            insertBTN.Size = new Size(562, 76);
            insertBTN.TabIndex = 71;
            insertBTN.Text = "Insert";
            insertBTN.UseVisualStyleBackColor = true;
            insertBTN.Click += insertBTN_Click;
            // 
            // endViewBTN
            // 
            endViewBTN.Font = new Font("Segoe UI", 25F);
            endViewBTN.Location = new Point(1328, 952);
            endViewBTN.Name = "endViewBTN";
            endViewBTN.Size = new Size(562, 76);
            endViewBTN.TabIndex = 73;
            endViewBTN.Text = "End View";
            endViewBTN.UseVisualStyleBackColor = true;
            endViewBTN.Visible = false;
            endViewBTN.Click += endViewBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.Font = new Font("Segoe UI", 25F);
            deleteBTN.Location = new Point(1609, 870);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(281, 76);
            deleteBTN.TabIndex = 72;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // datePICK
            // 
            datePICK.Font = new Font("Segoe UI", 15F);
            datePICK.Format = DateTimePickerFormat.Custom;
            datePICK.Location = new Point(1328, 571);
            datePICK.Name = "datePICK";
            datePICK.Size = new Size(562, 41);
            datePICK.TabIndex = 74;
            // 
            // updateBTN
            // 
            updateBTN.Font = new Font("Segoe UI", 25F);
            updateBTN.Location = new Point(1328, 870);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(281, 76);
            updateBTN.TabIndex = 75;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // studentsBTN
            // 
            studentsBTN.Font = new Font("Segoe UI", 25F);
            studentsBTN.Location = new Point(1328, 706);
            studentsBTN.Name = "studentsBTN";
            studentsBTN.Size = new Size(562, 76);
            studentsBTN.TabIndex = 77;
            studentsBTN.Text = "View Students";
            studentsBTN.UseVisualStyleBackColor = true;
            studentsBTN.Visible = false;
            studentsBTN.Click += studentsBTN_Click;
            // 
            // questionsBTN
            // 
            questionsBTN.Font = new Font("Segoe UI", 25F);
            questionsBTN.Location = new Point(1328, 788);
            questionsBTN.Name = "questionsBTN";
            questionsBTN.Size = new Size(562, 76);
            questionsBTN.TabIndex = 76;
            questionsBTN.Text = "View Questions";
            questionsBTN.UseVisualStyleBackColor = true;
            questionsBTN.Visible = false;
            questionsBTN.Click += questionsBTN_Click;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(studentsBTN);
            Controls.Add(questionsBTN);
            Controls.Add(updateBTN);
            Controls.Add(datePICK);
            Controls.Add(endViewBTN);
            Controls.Add(deleteBTN);
            Controls.Add(insertBTN);
            Controls.Add(idTXT);
            Controls.Add(dateLBL);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(examDATA);
            Name = "ExamsForm";
            Text = "Exams";
            FormClosed += ExamsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)examDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTXT;
        private Label dateLBL;
        private Label nameLBL;
        private RichTextBox nameTXT;
        private Button returnBTN;
        private Button refreshBTN;
        private DataGridView examDATA;
        private Button insertBTN;
        private Button endViewBTN;
        private Button deleteBTN;
        private DateTimePicker datePICK;
        private Button updateBTN;
        private Button studentsBTN;
        private Button questionsBTN;
    }
}