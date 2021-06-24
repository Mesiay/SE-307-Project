
namespace se307Project
{
    partial class PurchasedTicket
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
            this.PurchasedTicketsDataGridView = new System.Windows.Forms.DataGridView();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedTicketsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PurchasedTicketsDataGridView
            // 
            this.PurchasedTicketsDataGridView.AllowUserToAddRows = false;
            this.PurchasedTicketsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PurchasedTicketsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchasedTicketsDataGridView.Location = new System.Drawing.Point(127, 161);
            this.PurchasedTicketsDataGridView.Name = "PurchasedTicketsDataGridView";
            this.PurchasedTicketsDataGridView.RowHeadersWidth = 51;
            this.PurchasedTicketsDataGridView.RowTemplate.Height = 29;
            this.PurchasedTicketsDataGridView.Size = new System.Drawing.Size(514, 137);
            this.PurchasedTicketsDataGridView.TabIndex = 0;
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(41, 52);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(37, 29);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(156, 82);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(132, 20);
            this.searchLabel.TabIndex = 2;
            this.searchLabel.Text = "Search by Tour ID :";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(294, 79);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(179, 27);
            this.searchText.TabIndex = 3;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // PurchasedTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.PurchasedTicketsDataGridView);
            this.Name = "PurchasedTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchased Tickets";
            this.Load += new System.EventHandler(this.PurchasedTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PurchasedTicketsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PurchasedTicketsDataGridView;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
    }
}