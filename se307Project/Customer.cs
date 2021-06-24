using System;
using System.Collections.Generic;
using System.Text;

namespace se307Project
{
    class Customer : User
    {
        private string id;
        private string name;
        private string surname;
        private string age;
        public static List<Customer> myList = new List<Customer>();

        // Getters and Setters
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Age { get => age; set => age = value; }

        // Parameterized Constructor
        public Customer(string id, string username, string password, string name, string surname, string age) : base(username, password)
        {
            Id = id;

            try
            {
                // Check if id is null
                if (string.IsNullOrEmpty(id))
                {
                    throw new Exception("ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Name = name;

            try
            {
                // Check if name is null
                if (string.IsNullOrEmpty(name))
                {
                    throw new Exception("Name cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Surname = surname;

            try
            {
                // Check if surname is null
                if (string.IsNullOrEmpty(surname))
                {
                    throw new Exception("Surname cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Age = age;

            try
            {
                // Check if age is null
                if (string.IsNullOrEmpty(age))
                {
                    throw new Exception("Age cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}", this.Id, this.Username, this.Password, this.Name, this.Surname, this.Age);
        }
    }
}
