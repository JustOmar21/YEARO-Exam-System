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
            logBTN.Cursor = Cursors.Hand;
            logBTN.Location = new Point(161, 343);
            logBTN.Name = "logBTN";
            logBTN.Size = new Size(462, 82);
            logBTN.TabIndex = 0;
            logBTN.Text = "Login";
            logBTN.UseVisualStyleBackColor = true;
            logBTN.Click += logBTN_Click;
            logBTN.MouseLeave += logBTN_MouseLeave;
            logBTN.MouseHover += logBTN_MouseHover;
            // 
            // Header
            // 
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            Header.ForeColor = Color.Black;
            Header.Location = new Point(161, 9);
            Header.Name = "Header";
            Header.Size = new Size(462, 41);
            Header.TabIndex = 1;
            Header.Text = "YEARO EXAMINATION SYSTEM";
            // 
            // userTXT
            // 
            userTXT.Location = new Point(161, 126);
            userTXT.MaxLength = 255;
            userTXT.Name = "userTXT";
            userTXT.Size = new Size(462, 27);
            userTXT.TabIndex = 2;
            // 
            // passTXT
            // 
            passTXT.Location = new Point(161, 243);
            passTXT.MaxLength = 255;
            passTXT.Name = "passTXT";
            passTXT.Size = new Size(462, 27);
            passTXT.TabIndex = 3;
            passTXT.UseSystemPasswordChar = true;
            // 
            // userLBL
            // 
            userLBL.AutoSize = true;
            userLBL.Font = new Font("Segoe UI", 12F);
            userLBL.Location = new Point(161, 95);
            userLBL.Name = "userLBL";
            userLBL.Size = new Size(99, 28);
            userLBL.TabIndex = 4;
            userLBL.Text = "Username";
            // 
            // passLBL
            // 
            passLBL.AutoSize = true;
            passLBL.Font = new Font("Segoe UI", 12F);
            passLBL.Location = new Point(161, 212);
            passLBL.Name = "passLBL";
            passLBL.Size = new Size(93, 28);
            passLBL.TabIndex = 5;
            passLBL.Text = "Password";
            // 
            // warningLBL
            // 
            warningLBL.AutoSize = true;
            warningLBL.Font = new Font("Segoe UI", 12F);
            warningLBL.Location = new Point(192, 287);
            warningLBL.Name = "warningLBL";
            warningLBL.Size = new Size(392, 28);
            warningLBL.TabIndex = 6;
            warningLBL.Text = "Either the email or the password is incorrect";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
