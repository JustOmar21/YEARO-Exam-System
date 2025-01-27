namespace Desktop.InstructorForms
{
    partial class QuestionForm
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
            questionDATA = new DataGridView();
            bodyTXT = new RichTextBox();
            typeBOX = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            deleteBTN = new Button();
            insertBTN = new Button();
            degreeNUM = new NumericUpDown();
            label3 = new Label();
            choice1TXT = new RichTextBox();
            choice1LBL = new Label();
            choice2LBL = new Label();
            choice2TXT = new RichTextBox();
            choice3LBL = new Label();
            choice3TXT = new RichTextBox();
            choice4LBL = new Label();
            choice4TXT = new RichTextBox();
            correctChoice1 = new Button();
            correctChoice2 = new Button();
            correctChoice3 = new Button();
            correctChoice4 = new Button();
            idTXT = new TextBox();
            endViewBTN = new Button();
            ((System.ComponentModel.ISupportInitialize)questionDATA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).BeginInit();
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
            // questionDATA
            // 
            questionDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            questionDATA.DefaultCellStyle = dataGridViewCellStyle1;
            questionDATA.Location = new Point(12, 80);
            questionDATA.Name = "questionDATA";
            questionDATA.ReadOnly = true;
            questionDATA.RowHeadersWidth = 51;
            questionDATA.Size = new Size(1310, 948);
            questionDATA.TabIndex = 12;
            questionDATA.CellMouseDoubleClick += questionDATA_CellMouseDoubleClick;
            // 
            // bodyTXT
            // 
            bodyTXT.Font = new Font("Segoe UI", 15F);
            bodyTXT.Location = new Point(1328, 183);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.Size = new Size(562, 114);
            bodyTXT.TabIndex = 22;
            bodyTXT.Text = "";
            // 
            // typeBOX
            // 
            typeBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBOX.Font = new Font("Segoe UI", 25F);
            typeBOX.FormattingEnabled = true;
            typeBOX.Items.AddRange(new object[] { "T/F", "MCQ" });
            typeBOX.Location = new Point(1328, 58);
            typeBOX.Name = "typeBOX";
            typeBOX.Size = new Size(562, 65);
            typeBOX.TabIndex = 23;
            typeBOX.SelectedIndexChanged += typeBOX_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1328, 5);
            label1.Name = "label1";
            label1.Size = new Size(90, 46);
            label1.TabIndex = 24;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(1328, 130);
            label2.Name = "label2";
            label2.Size = new Size(95, 46);
            label2.TabIndex = 25;
            label2.Text = "Body";
            // 
            // deleteBTN
            // 
            deleteBTN.Font = new Font("Segoe UI", 25F);
            deleteBTN.Location = new Point(1328, 952);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(281, 76);
            deleteBTN.TabIndex = 28;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // insertBTN
            // 
            insertBTN.Font = new Font("Segoe UI", 25F);
            insertBTN.Location = new Point(1328, 952);
            insertBTN.Name = "insertBTN";
            insertBTN.Size = new Size(562, 76);
            insertBTN.TabIndex = 29;
            insertBTN.Text = "Insert";
            insertBTN.UseVisualStyleBackColor = true;
            insertBTN.Click += insertBTN_Click;
            // 
            // degreeNUM
            // 
            degreeNUM.Font = new Font("Segoe UI", 25F);
            degreeNUM.Location = new Point(1328, 357);
            degreeNUM.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            degreeNUM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            degreeNUM.Name = "degreeNUM";
            degreeNUM.Size = new Size(562, 63);
            degreeNUM.TabIndex = 30;
            degreeNUM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(1328, 304);
            label3.Name = "label3";
            label3.Size = new Size(130, 46);
            label3.TabIndex = 31;
            label3.Text = "Degree";
            // 
            // choice1TXT
            // 
            choice1TXT.Font = new Font("Segoe UI", 15F);
            choice1TXT.Location = new Point(1328, 480);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.Size = new Size(472, 69);
            choice1TXT.TabIndex = 32;
            choice1TXT.Text = "";
            // 
            // choice1LBL
            // 
            choice1LBL.AutoSize = true;
            choice1LBL.Font = new Font("Segoe UI", 20F);
            choice1LBL.Location = new Point(1328, 427);
            choice1LBL.Name = "choice1LBL";
            choice1LBL.Size = new Size(149, 46);
            choice1LBL.TabIndex = 36;
            choice1LBL.Text = "Choice 1";
            // 
            // choice2LBL
            // 
            choice2LBL.AutoSize = true;
            choice2LBL.Font = new Font("Segoe UI", 20F);
            choice2LBL.Location = new Point(1328, 556);
            choice2LBL.Name = "choice2LBL";
            choice2LBL.Size = new Size(149, 46);
            choice2LBL.TabIndex = 38;
            choice2LBL.Text = "Choice 2";
            // 
            // choice2TXT
            // 
            choice2TXT.Font = new Font("Segoe UI", 15F);
            choice2TXT.Location = new Point(1328, 609);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.Size = new Size(472, 69);
            choice2TXT.TabIndex = 37;
            choice2TXT.Text = "";
            // 
            // choice3LBL
            // 
            choice3LBL.AutoSize = true;
            choice3LBL.Font = new Font("Segoe UI", 20F);
            choice3LBL.Location = new Point(1328, 685);
            choice3LBL.Name = "choice3LBL";
            choice3LBL.Size = new Size(149, 46);
            choice3LBL.TabIndex = 40;
            choice3LBL.Text = "Choice 3";
            choice3LBL.Visible = false;
            // 
            // choice3TXT
            // 
            choice3TXT.Font = new Font("Segoe UI", 15F);
            choice3TXT.Location = new Point(1328, 738);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.Size = new Size(472, 69);
            choice3TXT.TabIndex = 39;
            choice3TXT.Text = "";
            choice3TXT.Visible = false;
            // 
            // choice4LBL
            // 
            choice4LBL.AutoSize = true;
            choice4LBL.Font = new Font("Segoe UI", 20F);
            choice4LBL.Location = new Point(1328, 814);
            choice4LBL.Name = "choice4LBL";
            choice4LBL.Size = new Size(149, 46);
            choice4LBL.TabIndex = 42;
            choice4LBL.Text = "Choice 4";
            choice4LBL.Visible = false;
            // 
            // choice4TXT
            // 
            choice4TXT.Font = new Font("Segoe UI", 15F);
            choice4TXT.Location = new Point(1328, 867);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.Size = new Size(472, 69);
            choice4TXT.TabIndex = 41;
            choice4TXT.Text = "";
            choice4TXT.Visible = false;
            // 
            // correctChoice1
            // 
            correctChoice1.BackColor = Color.Green;
            correctChoice1.Cursor = Cursors.Hand;
            correctChoice1.FlatAppearance.BorderColor = Color.Brown;
            correctChoice1.Location = new Point(1806, 480);
            correctChoice1.Name = "correctChoice1";
            correctChoice1.Size = new Size(84, 69);
            correctChoice1.TabIndex = 44;
            correctChoice1.UseVisualStyleBackColor = false;
            correctChoice1.Click += correctChoice1_Click;
            // 
            // correctChoice2
            // 
            correctChoice2.BackColor = Color.White;
            correctChoice2.Cursor = Cursors.Hand;
            correctChoice2.FlatAppearance.BorderColor = Color.Brown;
            correctChoice2.Location = new Point(1806, 609);
            correctChoice2.Name = "correctChoice2";
            correctChoice2.Size = new Size(84, 69);
            correctChoice2.TabIndex = 45;
            correctChoice2.UseVisualStyleBackColor = false;
            correctChoice2.Click += correctChoice2_Click;
            // 
            // correctChoice3
            // 
            correctChoice3.BackColor = Color.White;
            correctChoice3.Cursor = Cursors.Hand;
            correctChoice3.Enabled = false;
            correctChoice3.FlatAppearance.BorderColor = Color.Brown;
            correctChoice3.Location = new Point(1806, 738);
            correctChoice3.Name = "correctChoice3";
            correctChoice3.Size = new Size(84, 69);
            correctChoice3.TabIndex = 46;
            correctChoice3.UseVisualStyleBackColor = false;
            correctChoice3.Visible = false;
            correctChoice3.Click += correctChoice3_Click;
            // 
            // correctChoice4
            // 
            correctChoice4.BackColor = Color.White;
            correctChoice4.Cursor = Cursors.Hand;
            correctChoice4.Enabled = false;
            correctChoice4.FlatAppearance.BorderColor = Color.Brown;
            correctChoice4.Location = new Point(1806, 867);
            correctChoice4.Name = "correctChoice4";
            correctChoice4.Size = new Size(84, 69);
            correctChoice4.TabIndex = 47;
            correctChoice4.UseVisualStyleBackColor = false;
            correctChoice4.Visible = false;
            correctChoice4.Click += correctChoice4_Click;
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
            // endViewBTN
            // 
            endViewBTN.Font = new Font("Segoe UI", 25F);
            endViewBTN.Location = new Point(1609, 952);
            endViewBTN.Name = "endViewBTN";
            endViewBTN.Size = new Size(281, 76);
            endViewBTN.TabIndex = 49;
            endViewBTN.Text = "End View";
            endViewBTN.UseVisualStyleBackColor = true;
            endViewBTN.Visible = false;
            endViewBTN.Click += endViewBTN_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(endViewBTN);
            Controls.Add(deleteBTN);
            Controls.Add(idTXT);
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
            Controls.Add(insertBTN);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(typeBOX);
            Controls.Add(bodyTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(questionDATA);
            Name = "QuestionForm";
            Text = "Question";
            FormClosed += QuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)questionDATA).EndInit();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private DataGridView questionDATA;
        private RichTextBox bodyTXT;
        private ComboBox typeBOX;
        private Label label1;
        private Label label2;
        private Button deleteBTN;
        private Button insertBTN;
        private NumericUpDown degreeNUM;
        private Label label3;
        private RichTextBox choice1TXT;
        private Label choice1LBL;
        private Label choice2LBL;
        private RichTextBox choice2TXT;
        private Label choice3LBL;
        private RichTextBox choice3TXT;
        private Label choice4LBL;
        private RichTextBox choice4TXT;
        private Button correctChoice1;
        private Button correctChoice2;
        private Button correctChoice3;
        private Button correctChoice4;
        private TextBox idTXT;
        private Button endViewBTN;
    }
}