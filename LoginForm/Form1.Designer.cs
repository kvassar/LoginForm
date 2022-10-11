namespace LoginForm
{
    partial class loginForm
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
            this.passswordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // passswordTextBox
            // 
            this.passswordTextBox.Location = new System.Drawing.Point(210, 208);
            this.passswordTextBox.Multiline = true;
            this.passswordTextBox.Name = "passswordTextBox";
            this.passswordTextBox.PasswordChar = '*';
            this.passswordTextBox.Size = new System.Drawing.Size(527, 91);
            this.passswordTextBox.TabIndex = 0;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(210, 59);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(527, 95);
            this.usernameTextBox.TabIndex = 1;
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.ForeColor = System.Drawing.Color.White;
            this.logInButton.Location = new System.Drawing.Point(541, 350);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(153, 52);
            this.logInButton.TabIndex = 2;
            this.logInButton.Text = "login";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.MistyRose;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(265, 350);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(154, 52);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(-4, 74);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(208, 70);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User Name";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(12, 220);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(192, 66);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.passswordTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passswordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

