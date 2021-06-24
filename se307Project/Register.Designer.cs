
namespace se307Project
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerButton = new System.Windows.Forms.Button();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.ageText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.registerPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.registerPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(204, 298);
            this.registerButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(82, 22);
            this.registerButton.TabIndex = 1;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(191, 78);
            this.usernameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(110, 23);
            this.usernameText.TabIndex = 2;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(191, 116);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(110, 23);
            this.passwordText.TabIndex = 3;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(191, 159);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(110, 23);
            this.nameText.TabIndex = 4;
            // 
            // surnameText
            // 
            this.surnameText.Location = new System.Drawing.Point(191, 200);
            this.surnameText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(110, 23);
            this.surnameText.TabIndex = 5;
            // 
            // ageText
            // 
            this.ageText.Location = new System.Drawing.Point(191, 246);
            this.ageText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(110, 23);
            this.ageText.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(102, 80);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(66, 15);
            this.usernameLabel.TabIndex = 8;
            this.usernameLabel.Text = "Username :";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(102, 118);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(63, 15);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(102, 159);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 15);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name :";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(102, 206);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(60, 15);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Surname :";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(102, 248);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(34, 15);
            this.ageLabel.TabIndex = 12;
            this.ageLabel.Text = "Age :";
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(10, 16);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(33, 22);
            this.prevPageButton.TabIndex = 13;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // registerPicture
            // 
            this.registerPicture.Image = ((System.Drawing.Image)(resources.GetObject("registerPicture.Image")));
            this.registerPicture.Location = new System.Drawing.Point(420, 0);
            this.registerPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.registerPicture.Name = "registerPicture";
            this.registerPicture.Size = new System.Drawing.Size(306, 377);
            this.registerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.registerPicture.TabIndex = 14;
            this.registerPicture.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 376);
            this.Controls.Add(this.registerPicture);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.surnameText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.registerButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.registerPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.PictureBox registerPicture;
    }
}