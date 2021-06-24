using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Linq;

namespace se307Project
{
    public partial class AddTour : Form
    {
        // Tour list
        List<Tours> tours = new List<Tours>();
        
        public AddTour()
        {
            InitializeComponent();
        }

        // Adds a new tour to the ("Tours.txt") file
        private void AddButton_Click(object sender, EventArgs e)
        {
            // Check if any textbox is empty 
            if (idText.Text.Equals("") || nameText.Text.Equals("") || startDateText.Text.Equals("") || finishDateText.Text.Equals("") || destinationText.Text.Equals("") || departureText.Text.Equals("") || capacityText.Text.Equals("") || statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                Tours tour = new Tours(idText.Text, nameText.Text, startDateText.Text, finishDateText.Text, destinationText.Text, departureText.Text, capacityText.Text, statusComboBox.Text);
                tours.Add(tour);

                var newTour = "\r" + tour.ToString();
                var path = "D:\\Tours.txt";

                if (File.ReadLines(path).Any(line => line.Contains(idText.Text)))
                {
                    MessageBox.Show("A tour with this id already exists");
                }

                else
                {
                    File.AppendAllText(path, newTour);
                }

                idText.Clear();
                nameText.Clear();
                startDateText.Clear();
                finishDateText.Clear();
                destinationText.Clear();
                departureText.Clear();
                capacityText.Clear();
                statusComboBox.SelectedIndex = -1;
            }
        }

        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            AdminMenu fm3 = new AdminMenu();
            fm3.Show();
            this.Hide();
        }


        private void AddRemoveTour_Load(object sender, EventArgs e)
        {
           
        }
    }
}
