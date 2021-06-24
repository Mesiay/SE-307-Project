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
    public partial class AddTicket : Form
    {
        // Ticket list
        List<Tickets> tickets = new List<Tickets>();

        public AddTicket()
        {
            InitializeComponent();
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            AdminMenu fm3 = new AdminMenu();
            fm3.Show();
            this.Hide();
        }

        
        private void AddRemoveTicket_Load(object sender, EventArgs e)
        {
            
        }

        // Adds a new ticket to the ("Tickets.txt") file
        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            // Check if any textbox is empty
            if (ticketidText.Text.Equals("") || touridText.Text.Equals("") || statusComboBox.SelectedIndex == -1 || priceText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                Tickets ticket = new Tickets(ticketidText.Text, touridText.Text, statusComboBox.Text, priceText.Text);
                tickets.Add(ticket);

                var newTicket = "\r" + ticket.ToString();
                var path = "D:\\Tickets.txt";

                if (File.ReadLines(path).Any(line => line.Contains(ticketidText.Text)))
                {
                    MessageBox.Show("A ticket with this id already exists");
                }

                else
                {
                    File.AppendAllText(path, newTicket);
                }

                ticketidText.Clear();
                touridText.Clear();
                priceText.Clear();
                statusComboBox.SelectedIndex = -1;
            }
        }
    }
}
