
namespace se307Project
{
    partial class AdminDisplayTour
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
            this.TourDataGridView = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TourDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(29, 24);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(27, 28);
            this.prevPageButton.TabIndex = 2;
            this.prevPageButton.Text = "<=";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // TourDataGridView
            // 
            this.TourDataGridView.AllowUserToAddRows = false;
            this.TourDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TourDataGridView.Location = new System.Drawing.Point(11, 185);
            this.TourDataGridView.Name = "TourDataGridView";
            this.TourDataGridView.RowHeadersWidth = 51;
            this.TourDataGridView.RowTemplate.Height = 29;
            this.TourDataGridView.Size = new System.Drawing.Size(1177, 188);
            this.TourDataGridView.TabIndex = 3;
            this.TourDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TourDataGridView_CellContentClick);
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(395, 77);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(213, 27);
            this.searchText.TabIndex = 4;
            this.searchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-available",
            "All"});
            this.filterComboBox.Location = new System.Drawing.Point(773, 75);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(151, 28);
            this.filterComboBox.TabIndex = 5;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(159, 81);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(73, 20);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Search by";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(661, 77);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(106, 20);
            this.filterLabel.TabIndex = 7;
            this.filterLabel.Text = "Filter by Status\r\n";
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "ID",
            "Name",
            "Start Date",
            "Finish Date",
            "Destination Place",
            "Departure Place",
            "Tour Capacity",
            "Tour Status"});
            this.searchComboBox.Location = new System.Drawing.Point(238, 77);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(151, 28);
            this.searchComboBox.TabIndex = 8;
            // 
            // AdminDisplayTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 536);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.TourDataGridView);
            this.Controls.Add(this.prevPageButton);
            this.Name = "AdminDisplayTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display/Search/Filter Tours";
            this.Load += new System.EventHandler(this.AdminDisplayTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TourDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.DataGridView TourDataGridView;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label filterLabel;
    }
}