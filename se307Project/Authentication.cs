using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace se307Project
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }
      
        // Login operation for customers
        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool loginsuccess = false;
            string[] logins = File.ReadAllLines(@"D:\Customers.txt");

            for (int i = 0; i < logins.Length; i++)
            {
                string[] Credential = logins[i].Split(' ');

                if (usernameText.Text == Credential[1] && passwordText.Text == Credential[2])
                {
                    CustomerMenu frm7 = new CustomerMenu();
                    frm7.Show();
                    this.Hide();
                    loginsuccess = true;
                    break;
                }
            }
            // login failed
            if (!loginsuccess)
            {
                MessageBox.Show("Wrong username or password");
                
            }
        }

        // Login operation for admin
        private void AdminButton_Click(object sender, EventArgs e)
        {
            // Create one single instance for the admin
            Admin admin = Admin.GetInstance();
            admin.Username = "admin";
            admin.Password = "1234";

            if (usernameText.Text == admin.Username && passwordText.Text == admin.Password)
            {
                AdminMenu frm3 = new AdminMenu();
                frm3.Show();
                this.Hide();
            }
            else if (usernameText.Text.Equals("") || passwordText.Text.Equals(""))
            {
                MessageBox.Show("Please fill out all fields");
            }

            else
            {
                MessageBox.Show("Wrong admin info");
            }
        }

       
        private void frm_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        // Exits application
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Shows registration form
        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register fm4 = new Register();
            fm4.Show();
            this.Hide();
        }

        // Hides password while writing
        private void passwordText_TextChanged(object sender, EventArgs e)
        {
            passwordText.PasswordChar = '*';
        }
    }
}
