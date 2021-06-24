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
    public partial class Register : Form
    {

        public Register()
        {
            InitializeComponent();
        }

        // Adds new account to ("Customers.txt") file
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Checks if any textbox is empty
            if (usernameText.Text.Equals("") || passwordText.Text.Equals("") || nameText.Text.Equals("") || surnameText.Text.Equals("") || ageText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[8];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                User customer = new Customer(finalString, usernameText.Text, passwordText.Text, nameText.Text, surnameText.Text, ageText.Text);
                Customer.myList.Add((Customer)customer);
                var newUser = customer.ToString() + "\r";
                var path = "D:\\Customers.txt";

                if (File.ReadLines(path).Any(line => line.Contains(usernameText.Text)))
                {
                    MessageBox.Show("A user with this username already exists");
                }
                else
                {
                    File.AppendAllText(path, newUser);
                }

                usernameText.Clear();
                passwordText.Clear();
                nameText.Clear();
                surnameText.Clear();
                ageText.Clear();
            }
        }

        // Shows previous page
        private void PreviousPageButton_Click(object sender, EventArgs e)
        {
            Authentication aut = new Authentication();
            aut.Show();
            this.Hide();
        }
    }
}
