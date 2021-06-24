using System;
using System.Collections.Generic;
using System.Text;

namespace se307Project
{
    class Tickets
    {
        private string ticketID;
        private string tourID;
        private string status;
        private string price;

        //Setters and Getters
        public string TicketID { get => ticketID; set => ticketID = value; }
        public string TourID { get => tourID; set => tourID = value; }
        public string Status { get => status; set => status = value; }
        public string Price { get => price; set => price = value; }

        //Parameterized Constructor
        public Tickets(string ticketID, string tourID, string status, string price)
        {
            TicketID = ticketID;
            try
            {
                // Check if ticket id is null
                if (string.IsNullOrEmpty(ticketID))
                {
                    throw new Exception("Ticket ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            TourID = tourID;
            try
            {
                // Check if tour id is null
                if (string.IsNullOrEmpty(tourID))
                {
                    throw new Exception("Tour ID cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Status = status;
            try
            {
                // Check if status is null
                if (string.IsNullOrEmpty(status))
                {
                    throw new Exception("Status cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Price = price;
            try
            {
                // Check if price is null
                if (string.IsNullOrEmpty(price))
                {
                    throw new Exception("Price cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        //Non-Parameterized Constructor
        public Tickets() { }

        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.TicketID, this.TourID, this.Status, this.Price);
        }
    }
}
