namespace Desktop.StudentForms.ExamsForm
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
            endViewBTN = new Button();
            datePICK = new DateTimePicker();
            enterBTN = new Button();
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
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 15F);
            nameTXT.Location = new Point(1328, 289);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(562, 69);
            nameTXT.TabIndex = 58;
            nameTXT.Text = "";
            nameTXT.MouseDown += nameTXT_MouseDown;
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
            // endViewBTN
            // 
            endViewBTN.Enabled = false;
            endViewBTN.Font = new Font("Segoe UI", 25F);
            endViewBTN.Location = new Point(1328, 952);
            endViewBTN.Name = "endViewBTN";
            endViewBTN.Size = new Size(562, 76);
            endViewBTN.TabIndex = 73;
            endViewBTN.Text = "End View";
            endViewBTN.UseVisualStyleBackColor = true;
            endViewBTN.Click += endViewBTN_Click;
            // 
            // datePICK
            // 
            datePICK.Enabled = false;
            datePICK.Font = new Font("Segoe UI", 15F);
            datePICK.Format = DateTimePickerFormat.Custom;
            datePICK.Location = new Point(1328, 571);
            datePICK.Name = "datePICK";
            datePICK.Size = new Size(562, 41);
            datePICK.TabIndex = 74;
            // 
            // enterBTN
            // 
            enterBTN.Enabled = false;
            enterBTN.Font = new Font("Segoe UI", 25F);
            enterBTN.Location = new Point(1328, 870);
            enterBTN.Name = "enterBTN";
            enterBTN.Size = new Size(562, 76);
            enterBTN.TabIndex = 75;
            enterBTN.Text = "Enter Exam";
            enterBTN.UseVisualStyleBackColor = true;
            enterBTN.Click += enterBTN_Click;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(enterBTN);
            Controls.Add(datePICK);
            Controls.Add(endViewBTN);
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
        private Button endViewBTN;
        private DateTimePicker datePICK;
        private Button enterBTN;
    }
}