
namespace se307Project
{
    partial class AdminDisplayTicket
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
            this.TicketDataGridView = new System.Windows.Forms.DataGridView();
            this.ticketInfoText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(26, 20);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(30, 22);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // TicketDataGridView
            // 
            this.TicketDataGridView.AllowUserToAddRows = false;
            this.TicketDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TicketDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TicketDataGridView.Location = new System.Drawing.Point(116, 106);
            this.TicketDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TicketDataGridView.Name = "TicketDataGridView";
            this.TicketDataGridView.RowHeadersWidth = 51;
            this.TicketDataGridView.RowTemplate.Height = 29;
            this.TicketDataGridView.Size = new System.Drawing.Size(764, 141);
            this.TicketDataGridView.TabIndex = 2;
            this.TicketDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TicketDataGridView_CellContentClick);
            // 
            // ticketInfoText
            // 
            this.ticketInfoText.Location = new System.Drawing.Point(369, 44);
            this.ticketInfoText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ticketInfoText.Name = "ticketInfoText";
            this.ticketInfoText.Size = new System.Drawing.Size(214, 23);
            this.ticketInfoText.TabIndex = 3;
            // 
            // AdminDisplayTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 338);
            this.Controls.Add(this.ticketInfoText);
            this.Controls.Add(this.TicketDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminDisplayTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Info";
            this.Load += new System.EventHandler(this.TicketInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TicketDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prevPageButton;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.TextBox ticketInfoText;
        public System.Windows.Forms.DataGridView TicketdataGridView;
        public System.Windows.Forms.DataGridView TicketDataGridView;
    }
}