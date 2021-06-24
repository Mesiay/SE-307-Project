
namespace se307Project
{
    partial class CustomerDisplayTicket
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
            this.prevPageButton = new System.Windows.Forms.Button();
            this.DisplayTicketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketAmountText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(41, 32);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(32, 22);
            this.prevPageButton.TabIndex = 0;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // DisplayTicketDataGridView
            // 
            this.DisplayTicketDataGridView.AllowUserToAddRows = false;
            this.DisplayTicketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DisplayTicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayTicketDataGridView.Location = new System.Drawing.Point(60, 127);
            this.DisplayTicketDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DisplayTicketDataGridView.Name = "DisplayTicketDataGridView";
            this.DisplayTicketDataGridView.RowHeadersWidth = 51;
            this.DisplayTicketDataGridView.RowTemplate.Height = 29;
            this.DisplayTicketDataGridView.Size = new System.Drawing.Size(665, 141);
            this.DisplayTicketDataGridView.TabIndex = 1;
            this.DisplayTicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayTicketDataGridView_CellContentClick);
            // 
            // ticketAmountText
            // 
            this.ticketAmountText.Location = new System.Drawing.Point(306, 48);
            this.ticketAmountText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketAmountText.Name = "ticketAmountText";
            this.ticketAmountText.Size = new System.Drawing.Size(165, 23);
            this.ticketAmountText.TabIndex = 2;
            this.ticketAmountText.TextChanged += new System.EventHandler(this.TicketAmountText_TextChanged);
            // 
            // UserDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 338);
            this.Controls.Add(this.ticketAmountText);
            this.Controls.Add(this.DisplayTicketDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserDisplayTicket";
            this.Text = "Display Ticket";
            this.Load += new System.EventHandler(this.DisplayTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayTicketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prevPageButton;
        public System.Windows.Forms.DataGridView DisplayTicketDataGridView;
        public System.Windows.Forms.TextBox ticketAmountText;
    }
}