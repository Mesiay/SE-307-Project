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
    public partial class CustomerMenu : Form
    {
        public CustomerMenu()
        {
            InitializeComponent();
        }

        // Shows PurchasedTicket form
        private void PurchasedTicketsButton_Click(object sender, EventArgs e)
        {
            PurchasedTicket frm8 = new PurchasedTicket();
            frm8.Show();
            this.Hide();
            
        }

        // Shows CustomerDisplayTour form
        private void DispTourTicketButton_Click(object sender, EventArgs e)
        {
            CustomerDisplayTour frm9 = new CustomerDisplayTour();
            frm9.Show();
            this.Hide();
        }

        // Logs out from the customer account
        private void LogoutButton_Click(object sender, EventArgs e)
        {          
            Authentication aut = new Authentication();
            aut.Show();
            this.Hide();
        }
    
    }
}
