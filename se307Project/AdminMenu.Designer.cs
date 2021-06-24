
namespace se307Project
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.addTourButton = new System.Windows.Forms.Button();
            this.dispSearchFilterB = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTourButton
            // 
            this.addTourButton.BackColor = System.Drawing.Color.Coral;
            this.addTourButton.Location = new System.Drawing.Point(307, 168);
            this.addTourButton.Name = "addTourButton";
            this.addTourButton.Size = new System.Drawing.Size(86, 103);
            this.addTourButton.TabIndex = 0;
            this.addTourButton.Text = "Add  Tours";
            this.addTourButton.UseVisualStyleBackColor = false;
            this.addTourButton.Click += new System.EventHandler(this.AddTourButton_Click);
            // 
            // dispSearchFilterB
            // 
            this.dispSearchFilterB.BackColor = System.Drawing.Color.LightCoral;
            this.dispSearchFilterB.Location = new System.Drawing.Point(102, 168);
            this.dispSearchFilterB.Name = "dispSearchFilterB";
            this.dispSearchFilterB.Size = new System.Drawing.Size(94, 103);
            this.dispSearchFilterB.TabIndex = 1;
            this.dispSearchFilterB.Text = "Display Search Filter Tours and Tickets";
            this.dispSearchFilterB.UseVisualStyleBackColor = false;
            this.dispSearchFilterB.Click += new System.EventHandler(this.DispSearchFilterButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.SkyBlue;
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Location = new System.Drawing.Point(671, 27);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(39, 35);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.Color.Tomato;
            this.addTicketButton.Location = new System.Drawing.Point(494, 168);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(90, 103);
            this.addTicketButton.TabIndex = 3;
            this.addTicketButton.Text = "Add Tickets";
            this.addTicketButton.UseVisualStyleBackColor = false;
            this.addTicketButton.Click += new System.EventHandler(this.AddTicketButton_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(742, 451);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dispSearchFilterB);
            this.Controls.Add(this.addTourButton);
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button dispSearchFilterB;
        private System.Windows.Forms.Button addTourButton;
    }
}