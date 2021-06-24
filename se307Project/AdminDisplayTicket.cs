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
    public partial class AdminDisplayTicket : Form
    {
        public AdminDisplayTicket()
        {
            InitializeComponent();
        }

        // Adds Remove button for each ticket 
        private void TicketInfo_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Remove Ticket";
            buttonColumn.Text = "Remove";
            buttonColumn.UseColumnTextForButtonValue = true;
            TicketDataGridView.Columns.Add(buttonColumn);
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            AdminDisplayTour frm1 = new AdminDisplayTour();
            frm1.Show();
            this.Hide();
        }

        // Removes tickets from ("Tickets.txt") 
        private void TicketDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;

            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Do you want to remove this ticket? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {                   
                    var valueIndex = string.Format("{0}", TicketDataGridView.Rows[indexRow].Cells[0].Value);
                    var idIndex = string.Format("{0}", TicketDataGridView.Rows[indexRow].Cells[1].Value);

                    string[] ticketList = File.ReadAllLines("D:\\Tickets.txt");
                    var tempFile = Path.GetTempFileName();
                    var linesToKeep = File.ReadLines("D:\\Tickets.txt").Where(l => !l.Contains(valueIndex));

                    File.WriteAllLines(tempFile, linesToKeep);
                 
                    File.Delete("D:\\Tickets.txt");
                    File.Move(tempFile, "D:\\Tickets.txt");
                    ticketInfoText.Clear();
                    var keptlines = File.ReadLines("D:\\Tickets.txt").Where(l => !l.Contains(valueIndex) && l.Contains(idIndex));
                    int amount = keptlines.Count();
                    string headline = "The ticket amount: " + amount;
                    ticketInfoText.Text = headline;
                    int rowIndex = TicketDataGridView.CurrentCell.RowIndex;
                    TicketDataGridView.Rows.RemoveAt(rowIndex);

                }
            }
        }
    }
}
