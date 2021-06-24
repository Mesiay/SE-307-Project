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
    public partial class PurchasedTicket : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public PurchasedTicket()
        {
            InitializeComponent();
        }

        // Displays purchased tickets from the ("BoughtTickets.txt") file
        private void PurchasedTicket_Load(object sender, EventArgs e)
        { 
            PurchasedTicketsDataGridView.DataSource = dt;

            dt.Columns.Add("Ticket ID", typeof(string));
            dt.Columns.Add("Tour ID", typeof(string));
            dt.Columns.Add("Ticket Status", typeof(string));
            dt.Columns.Add("Ticket Price", typeof(string));

            string[] lines = File.ReadAllLines("D:\\BoughtTickets.txt");
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
        }
        
        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            CustomerMenu frm7 = new CustomerMenu();
            frm7.Show();
            this.Hide();
        }

        // Filters purchased tickets by their tour ids
        private void searchText_TextChanged(object sender, EventArgs e)
        {
            bs.DataSource = dt.DefaultView;
            bs.Filter = string.Format("[Tour ID] like '{0}%'", searchText.Text);
        }
    }
}
