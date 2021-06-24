
namespace se307Project
{
    partial class CustomerMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMenu));
            this.dispTourTicketButton = new System.Windows.Forms.Button();
            this.purchasedTicketsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dispTourTicketButton
            // 
            this.dispTourTicketButton.BackColor = System.Drawing.Color.DarkOrange;
            this.dispTourTicketButton.Location = new System.Drawing.Point(229, 163);
            this.dispTourTicketButton.Name = "dispTourTicketButton";
            this.dispTourTicketButton.Size = new System.Drawing.Size(94, 87);
            this.dispTourTicketButton.TabIndex = 0;
            this.dispTourTicketButton.Text = "Display Tours and Buy Tickets";
            this.dispTourTicketButton.UseVisualStyleBackColor = false;
            this.dispTourTicketButton.Click += new System.EventHandler(this.DispTourTicketButton_Click);
            // 
            // purchasedTicketsButton
            // 
            this.purchasedTicketsButton.BackColor = System.Drawing.Color.Brown;
            this.purchasedTicketsButton.Location = new System.Drawing.Point(506, 163);
            this.purchasedTicketsButton.Name = "purchasedTicketsButton";
            this.purchasedTicketsButton.Size = new System.Drawing.Size(94, 87);
            this.purchasedTicketsButton.TabIndex = 1;
            this.purchasedTicketsButton.Text = "Purchased Tickets";
            this.purchasedTicketsButton.UseVisualStyleBackColor = false;
            this.purchasedTicketsButton.Click += new System.EventHandler(this.PurchasedTicketsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.Yellow;
            this.logoutButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoutButton.BackgroundImage")));
            this.logoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoutButton.Location = new System.Drawing.Point(719, 21);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(40, 35);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.purchasedTicketsButton);
            this.Controls.Add(this.dispTourTicketButton);
            this.Name = "CustomerMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button dispTourTicketButton;
        private System.Windows.Forms.Button purchasedTicketsButton;
        private System.Windows.Forms.Button logoutButton;
    }
}