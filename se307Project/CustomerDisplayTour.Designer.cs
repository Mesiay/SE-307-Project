
namespace se307Project
{
    partial class CustomerDisplayTour
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
            this.dispTourDataGridView = new System.Windows.Forms.DataGridView();
            this.prevPageButton = new System.Windows.Forms.Button();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.filterLabel = new System.Windows.Forms.Label();
            this.searchText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dispTourDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dispTourDataGridView
            // 
            this.dispTourDataGridView.AllowUserToAddRows = false;
            this.dispTourDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dispTourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dispTourDataGridView.Location = new System.Drawing.Point(24, 166);
            this.dispTourDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dispTourDataGridView.Name = "dispTourDataGridView";
            this.dispTourDataGridView.RowHeadersWidth = 51;
            this.dispTourDataGridView.RowTemplate.Height = 29;
            this.dispTourDataGridView.Size = new System.Drawing.Size(949, 141);
            this.dispTourDataGridView.TabIndex = 0;
            this.dispTourDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DispTourDataGridView_CellContentClick);
            // 
            // prevPageButton
            // 
            this.prevPageButton.Location = new System.Drawing.Point(34, 28);
            this.prevPageButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevPageButton.Name = "prevPageButton";
            this.prevPageButton.Size = new System.Drawing.Size(36, 26);
            this.prevPageButton.TabIndex = 1;
            this.prevPageButton.Text = "<";
            this.prevPageButton.UseVisualStyleBackColor = true;
            this.prevPageButton.Click += new System.EventHandler(this.PreviousPageButton_Click);
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "Available",
            "Non-available",
            "All"});
            this.filterComboBox.Location = new System.Drawing.Point(690, 58);
            this.filterComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(162, 23);
            this.filterComboBox.TabIndex = 2;
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.FilterComboBox_SelectedIndexChanged);
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
            this.searchComboBox.Location = new System.Drawing.Point(184, 59);
            this.searchComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(157, 23);
            this.searchComboBox.TabIndex = 3;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(115, 62);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(58, 15);
            this.searchLabel.TabIndex = 4;
            this.searchLabel.Text = "Search by";
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Location = new System.Drawing.Point(586, 62);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(90, 15);
            this.filterLabel.TabIndex = 5;
            this.filterLabel.Text = "Filter Status by :";
            // 
            // searchText
            // 
            this.searchText.Location = new System.Drawing.Point(346, 59);
            this.searchText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(170, 23);
            this.searchText.TabIndex = 6;
            this.searchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // UserDisplayTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 390);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.prevPageButton);
            this.Controls.Add(this.dispTourDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserDisplayTour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Display Tour";
            this.Load += new System.EventHandler(this.DisplayTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dispTourDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dispTourDataGridView;
        private System.Windows.Forms.Button prevPageButton;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label filterLabel;
    }
}