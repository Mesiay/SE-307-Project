using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace se307Project
{
    public partial class CustomerDisplayTour : Form
    {
        DataTable dt = new DataTable();
        DataTable dt2 = new DataTable();
        BindingSource bs = new BindingSource();

        public CustomerDisplayTour()
        {
            InitializeComponent();
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            CustomerMenu frm7 = new CustomerMenu();
            frm7.Show();
            this.Hide();
        }

        // Displays all the tours from ("Tours.txt") file
        private void DisplayTour_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Start Date", typeof(string));
            dt.Columns.Add("Finish Date", typeof(string));
            dt.Columns.Add("Destination Place", typeof(string));
            dt.Columns.Add("Departure Place", typeof(string));
            dt.Columns.Add("Tour Capacity", typeof(string));
            dt.Columns.Add("Tour Status", typeof(string));

            dispTourDataGridView.DataSource = dt;

            string[] lines = File.ReadAllLines("D:\\Tours.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(' ');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                dt.Rows.Add(row);
            }

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Ticket Info";
            buttonColumn.Text = "See Ticket Info";
            buttonColumn.UseColumnTextForButtonValue = true;
            dispTourDataGridView.Columns.Add(buttonColumn);
        }

        // Filters tours according to given attribute in searchComboBox
        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            bs.DataSource = dt.DefaultView;
            bs.Filter = string.Format("[" + searchComboBox.Text + "] like '{0}%'", searchText.Text);
        }

        // Filter tours according to their status
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bs.DataSource = dt.DefaultView;
            if (filterComboBox.Text == "All")
            {
                bs.Filter = "";

            }

            else if (filterComboBox.Text == "Available")
            {
                bs.Filter = string.Format("[Tour Status] LIKE 'Available'");

            }

            else if (filterComboBox.Text == "Non-available")
            {
                bs.Filter = string.Format("[Tour Status] LIKE 'Non-available'");

            }
        }

        // Button events
        private void DispTourDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Opens customer ticket form to show all ticket infos which belongs to chosen tour id
            if (e.ColumnIndex == 8)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);
                var valueIndex = string.Format("{0}", dispTourDataGridView.Rows[numberRow].Cells[0].Value);

                string[] allLines = File.ReadAllLines("D:\\Tickets.txt");
                string[] keepLines = Array.FindAll(allLines, line => line.Contains(valueIndex));
                string[] values;
                
                CustomerDisplayTicket frm10 = new CustomerDisplayTicket();
                frm10.DisplayTicketDataGridView.DataSource = dt2;
                int amount = keepLines.Length;
                string headline = "The ticket amount: " + amount;
                frm10.ticketAmountText.Text = headline;
           
                dt2.Columns.Add("Ticket ID", typeof(string));
                dt2.Columns.Add("Tour ID", typeof(string));
                dt2.Columns.Add("Ticket Status", typeof(string));
                dt2.Columns.Add("Ticket Price", typeof(string));

                for (int i = 0; i < keepLines.Length; i++)
                {
                    values = keepLines[i].ToString().Split(' ');

                    string[] row = new string[values.Length];

                    for (int j = 0; j < values.Length; j++)
                    {
                        row[j] = values[j].Trim();
                    }

                    dt2.Rows.Add(row);
                }

                frm10.StartPosition = FormStartPosition.CenterScreen;
                frm10.Show();
                this.Hide();
            }
        }
    }
}
