
namespace se307Project
{
    partial class AddTicket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTicket));
            this.ticketIDLabel = new System.Windows.Forms.Label();
            this.tourIDLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.ticketidText = new System.Windows.Forms.TextBox();
            this.touridText = new System.Windows.Forms.TextBox();
            this.priceText = new System.Windows.Forms.TextBox();
            this.ticketPicture = new System.Windows.Forms.PictureBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ticketIDLabel
            // 
            this.ticketIDLabel.AutoSize = true;
            this.ticketIDLabel.Location = new System.Drawing.Point(120, 74);
            this.ticketIDLabel.Name = "ticketIDLabel";
            this.ticketIDLabel.Size = new System.Drawing.Size(58, 15);
            this.ticketIDLabel.TabIndex = 0;
            this.ticketIDLabel.Text = "Ticket ID :";
            // 
            // tourIDLabel
            // 
            this.tourIDLabel.AutoSize = true;
            this.tourIDLabel.Location = new System.Drawing.Point(120, 117);
            this.tourIDLabel.Name = "tourIDLabel";
            this.tourIDLabel.Size = new System.Drawing.Size(50, 15);
            this.tourIDLabel.TabIndex = 1;
            this.tourIDLabel.Text = "Tour ID :";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(120, 158);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(79, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Ticket Status :";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(120, 201);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 15);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Ticket Price :";
            // 
            // addTicketButton
            // 
            this.addTicketButton.Location = new System.Drawing.Point(244, 269);
            this.addTicketButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(90, 22);
            this.addTicketButton.TabIndex = 4;
            this.addTicketButton.Text = "Add Ticket";
            this.addTicketButton.UseVisualStyleBackColor = true;
            this.addTicketButton.Click += new System.EventHandler(this.AddTicketButton_Click);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(32, 27);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(29, 22);
            this.prevPageButton.TabIndex = 6;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // ticketidText
            // 
            this.ticketidText.Location = new System.Drawing.Point(236, 72);
            this.ticketidText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketidText.Name = "ticketidText";
            this.ticketidText.Size = new System.Drawing.Size(110, 23);
            this.ticketidText.TabIndex = 7;
            // 
            // touridText
            // 
            this.touridText.Location = new System.Drawing.Point(236, 112);
            this.touridText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.touridText.Name = "touridText";
            this.touridText.Size = new System.Drawing.Size(110, 23);
            this.touridText.TabIndex = 8;
            // 
            // priceText
            // 
            this.priceText.Location = new System.Drawing.Point(236, 196);
            this.priceText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(110, 23);
            this.priceText.TabIndex = 9;
            // 
            // ticketPicture
            // 
            this.ticketPicture.Image = ((System.Drawing.Image)(resources.GetObject("ticketPicture.Image")));
            this.ticketPicture.Location = new System.Drawing.Point(458, 0);
            this.ticketPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketPicture.Name = "ticketPicture";
            this.ticketPicture.Size = new System.Drawing.Size(332, 375);
            this.ticketPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ticketPicture.TabIndex = 11;
            this.ticketPicture.TabStop = false;
            // 
            // statusComboBox
            // 
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-Available"});
            this.statusComboBox.Location = new System.Drawing.Point(236, 158);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(110, 23);
            this.statusComboBox.TabIndex = 12;
            // 
            // AddTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 376);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.ticketPicture);
            this.Controls.Add(this.priceText);
            this.Controls.Add(this.touridText);
            this.Controls.Add(this.ticketidText);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tourIDLabel);
            this.Controls.Add(this.ticketIDLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Ticket";
            this.Load += new System.EventHandler(this.AddRemoveTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ticketIDLabel;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.TextBox ticketidText;
        private System.Windows.Forms.TextBox touridText;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox priceText;
        private System.Windows.Forms.PictureBox ticketPicture;
        private System.Windows.Forms.Label tourIDLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button addTicketButton;
    }
}