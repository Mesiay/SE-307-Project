
namespace se307Project
{
    partial class Authentication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentication));
            this.loginButton = new System.Windows.Forms.Button();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.adminButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Coral;
            this.loginButton.Location = new System.Drawing.Point(198, 200);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(90, 34);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.AutoSize = true;
            this.registerLinkLabel.BackColor = System.Drawing.Color.Moccasin;
            this.registerLinkLabel.Location = new System.Drawing.Point(214, 255);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(49, 15);
            this.registerLinkLabel.TabIndex = 1;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Register";
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RegisterLinkLabel_LinkClicked);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(272, 68);
            this.usernameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(110, 23);
            this.usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(272, 118);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(110, 23);
            this.passwordText.TabIndex = 3;
            this.passwordText.TextChanged += new System.EventHandler(this.passwordText_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(183, 68);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(60, 15);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(183, 120);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "Password";
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.Coral;
            this.adminButton.Location = new System.Drawing.Point(377, 200);
            this.adminButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(93, 34);
            this.adminButton.TabIndex = 6;
            this.adminButton.Text = "Admin Login";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Crimson;
            this.exitButton.Location = new System.Drawing.Point(29, 20);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(29, 22);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 338);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.registerLinkLabel);
            this.Controls.Add(this.loginButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
    }
}

