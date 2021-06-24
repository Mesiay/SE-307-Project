using System;
using System.Collections.Generic;
using System.Text;

namespace se307Project
{
    class Tours
    {
        private string id;
        private string name;
        private string startDate;
        private string finishDate;
        private string destinationPlace;
        private string departurePlace;
        private string tourCapacity;
        private string tourStatus;

       // List<Tours> tours = new List<Tours>();

        //Setters and Getters
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string StartDate { get => startDate; set => startDate = value; }
        public string FinishDate { get => finishDate; set => finishDate = value; }
        public string DestinationPlace { get => destinationPlace; set => destinationPlace = value; }
        public string DeparturePlace { get => departurePlace; set => departurePlace = value; }
        public string TourCapacity { get => tourCapacity; set => tourCapacity = value; }
        public string TourStatus { get => tourStatus; set => tourStatus = value; }
   

        //Parameterized Constructor
        public Tours(string id, string name, string startDate, string finishDate, string destinationPlace, string departurePlace, string tourCapacity, string tourStatus)
        {
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

            StartDate = startDate;

            try
            {
                // Check if start date is null
                if (string.IsNullOrEmpty(startDate))
                {
                    throw new Exception("Start Date cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            FinishDate = finishDate;

            try
            {
                // Check if finish date is null
                if (string.IsNullOrEmpty(finishDate))
                {
                    throw new Exception("Finish Date cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            DestinationPlace = destinationPlace;

            try
            {
                // Check if destination place is null
                if (string.IsNullOrEmpty(destinationPlace))
                {
                    throw new Exception("Destination Place cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            DeparturePlace = departurePlace;

            try
            {
                // Check if departure place is null
                if (string.IsNullOrEmpty(departurePlace))
                {
                    throw new Exception("Departure Place cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            TourCapacity = tourCapacity;

            try
            {
                // Check if tour capacity is null
                if (string.IsNullOrEmpty(tourCapacity))
                {
                    throw new Exception("Tour Capacity cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            TourStatus = tourStatus;

            try
            {
                // Check if tour status is null
                if (string.IsNullOrEmpty(tourStatus))
                {
                    throw new Exception("Tour status cannot be null");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

       
        }

        //Non-Parameterized Constructor
        public Tours() { }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Start Date: " + StartDate);
            Console.WriteLine("Finish Date: " + FinishDate);
            Console.WriteLine("Destination Place: " + DestinationPlace);
            Console.WriteLine("Departure Place: " + DeparturePlace);
            Console.WriteLine("Tour Capacity: " + TourCapacity);
            Console.WriteLine("Tour Status: " + TourStatus);
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5} {6} {7}", this.Id, this.Name, this.StartDate, this.FinishDate, this.DestinationPlace, this.DeparturePlace, this.TourCapacity, this.TourStatus);
        }
    }
}
