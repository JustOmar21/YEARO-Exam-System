namespace Desktop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            logBTN = new Button();
            Header = new Label();
            userTXT = new TextBox();
            passTXT = new TextBox();
            userLBL = new Label();
            passLBL = new Label();
            warningLBL = new Label();
            SuspendLayout();
            // 
            // logBTN
            // 
            logBTN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logBTN.Cursor = Cursors.Hand;
            logBTN.Font = new Font("Segoe UI", 50F);
            logBTN.Location = new Point(396, 786);
            logBTN.Name = "logBTN";
            logBTN.Size = new Size(1111, 235);
            logBTN.TabIndex = 0;
            logBTN.Text = "Login";
            logBTN.UseVisualStyleBackColor = true;
            logBTN.Click += logBTN_Click;
            logBTN.MouseLeave += logBTN_MouseLeave;
            logBTN.MouseHover += logBTN_MouseHover;
            // 
            // Header
            // 
            Header.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 50F, FontStyle.Bold);
            Header.ForeColor = Color.Black;
            Header.Location = new Point(312, 9);
            Header.Name = "Header";
            Header.Size = new Size(1278, 112);
            Header.TabIndex = 1;
            Header.Text = "YEARO EXAMINATION SYSTEM";
            // 
            // userTXT
            // 
            userTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userTXT.Font = new Font("Segoe UI", 25F);
            userTXT.Location = new Point(169, 293);
            userTXT.MaxLength = 255;
            userTXT.Name = "userTXT";
            userTXT.Size = new Size(1564, 63);
            userTXT.TabIndex = 2;
            // 
            // passTXT
            // 
            passTXT.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passTXT.Font = new Font("Segoe UI", 25F);
            passTXT.Location = new Point(169, 556);
            passTXT.MaxLength = 255;
            passTXT.Name = "passTXT";
            passTXT.Size = new Size(1564, 63);
            passTXT.TabIndex = 3;
            passTXT.UseSystemPasswordChar = true;
            // 
            // userLBL
            // 
            userLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userLBL.AutoSize = true;
            userLBL.Font = new Font("Segoe UI", 25F);
            userLBL.Location = new Point(169, 233);
            userLBL.Name = "userLBL";
            userLBL.Size = new Size(212, 57);
            userLBL.TabIndex = 4;
            userLBL.Text = "Username";
            // 
            // passLBL
            // 
            passLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passLBL.AutoSize = true;
            passLBL.Font = new Font("Segoe UI", 25F);
            passLBL.Location = new Point(169, 483);
            passLBL.Name = "passLBL";
            passLBL.Size = new Size(200, 57);
            passLBL.TabIndex = 5;
            passLBL.Text = "Password";
            // 
            // warningLBL
            // 
            warningLBL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            warningLBL.AutoSize = true;
            warningLBL.Font = new Font("Segoe UI", 25F);
            warningLBL.ForeColor = Color.Red;
            warningLBL.Location = new Point(530, 669);
            warningLBL.Name = "warningLBL";
            warningLBL.Size = new Size(842, 57);
            warningLBL.TabIndex = 6;
            warningLBL.Text = "Either the email or the password is incorrect";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(warningLBL);
            Controls.Add(passLBL);
            Controls.Add(userLBL);
            Controls.Add(passTXT);
            Controls.Add(userTXT);
            Controls.Add(Header);
            Controls.Add(logBTN);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button logBTN;
        private Label Header;
        private TextBox userTXT;
        private TextBox passTXT;
        private Label userLBL;
        private Label passLBL;
        private Label warningLBL;
    }
}
