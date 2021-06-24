using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace se307Project
{
    public partial class AdminMenu : Form
    { 
        public AdminMenu()
        {
            InitializeComponent();
        }
        
        // Shows AddTour form
        private void AddTourButton_Click(object sender, EventArgs e)
        {
            AddTour fm2 = new AddTour();
            fm2.Show();
            this.Hide();
        }

        // Shows AdminDisplayTour form
        private void DispSearchFilterButton_Click(object sender, EventArgs e)
        {
            AdminDisplayTour fm1 = new AdminDisplayTour();
            fm1.Show();
            this.Hide();
        }

        // Logs out from the admin account
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Authentication aut = new Authentication();
            aut.Show();
            this.Hide();
        }

        // Shows AddTicket form
        private void AddTicketButton_Click(object sender, EventArgs e)
        {
            AddTicket fm6 = new AddTicket();
            fm6.Show();
            this.Hide();
        }
    }
}
