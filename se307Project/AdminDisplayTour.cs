using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace se307Project
{

    public partial class AdminDisplayTour : Form
    {    
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        DataTable dt2 = new DataTable();

        public AdminDisplayTour()
        {
            InitializeComponent();
     
           
        }
       
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            AdminMenu frm3 = new AdminMenu();
            frm3.Show();
            this.Hide();
        }

        // Displays all the tours from ("Tours.txt") file
        private void AdminDisplayTour_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn2 = new DataGridViewButtonColumn();
            buttonColumn2.HeaderText = "Remove Tour";
            buttonColumn2.Text = "Remove";
            buttonColumn2.UseColumnTextForButtonValue = true;
            TourDataGridView.Columns.Add(buttonColumn2);

            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Start Date", typeof(string));
            dt.Columns.Add("Finish Date", typeof(string));
            dt.Columns.Add("Destination Place", typeof(string));
            dt.Columns.Add("Departure Place", typeof(string));
            dt.Columns.Add("Tour Capacity", typeof(string));
            dt.Columns.Add("Tour Status", typeof(string));            

            TourDataGridView.DataSource = dt;

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
            TourDataGridView.Columns.Add(buttonColumn);
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

            else if(filterComboBox.Text == "Available")
            {               
                bs.Filter = string.Format("[Tour Status] LIKE 'Available'");
           
            }

            else if(filterComboBox.Text == "Non-available")
            {               
                bs.Filter = string.Format("[Tour Status] LIKE 'Non-available'");
               
            }           
        }

        // Button events
        private void TourDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            // Removes tour by id and removes all the tickets that belong to the tour
            if (e.ColumnIndex == 0)
            {
                int numberRow = Convert.ToInt32(e.RowIndex);
                var valueIndex = string.Format("{0}", TourDataGridView.Rows[indexRow].Cells[1].Value);

                if (MessageBox.Show("Do you want to remove this tour? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var tempFile = Path.GetTempFileName();
                    var tempFile2 = Path.GetTempFileName();
                    var toursToKeep = File.ReadLines("D:\\Tours.txt").Where(l => !l.Contains(valueIndex));
                    var ticketsToKeep = File.ReadLines("D:\\Tickets.txt").Where(l => !l.Contains(valueIndex));
                    File.WriteAllLines(tempFile, toursToKeep);
                    File.WriteAllLines(tempFile2, ticketsToKeep);
                    File.Delete("D:\\Tours.txt");
                    File.Delete("D:\\Tickets.txt");
                    File.Move(tempFile, "D:\\Tours.txt");
                    File.Move(tempFile2, "D:\\Tickets.txt");
                    int rowIndex = TourDataGridView.CurrentCell.RowIndex;
                    TourDataGridView.Rows.RemoveAt(rowIndex);
                }
            }

            // Opens admin ticket form to show all ticket infos which belongs to chosen tour id
            if (e.ColumnIndex == 9)
            {
                
                var valueIndex = string.Format("{0}",TourDataGridView.Rows[indexRow].Cells[1].Value);
               
                string[] allLines = File.ReadAllLines("D:\\Tickets.txt");
                string[] keepLines = Array.FindAll(allLines, line => line.Contains(valueIndex));
                string[] values;
                int amount = keepLines.Length;
                AdminDisplayTicket frm5 = new AdminDisplayTicket();
                frm5.TicketDataGridView.DataSource = dt2;
                string headline = "The ticket amount: " + amount;
                frm5.ticketInfoText.Text = headline;
           
          
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

                frm5.Show();
                this.Hide();
            }
        }
    }
}
