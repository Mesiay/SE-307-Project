using System;
using System.Collections.Generic;
using System.Text;

namespace se307Project
{
    class User
    {
        private string username;
        private string password;

        // Getters and Setters
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }

        // Non-parameterized Constructor
        public User() { }

        // Parameterized Constructor
        public User(string username, string password)
        {
            Username = username;

            try
            {
                // Check if username is null
                if (string.IsNullOrEmpty(username))
                {
                    throw new Exception("Username cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Password = password;

            try
            {
                // Check if password is null
                if (string.IsNullOrEmpty(password))
                {
                    throw new Exception("Password cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
