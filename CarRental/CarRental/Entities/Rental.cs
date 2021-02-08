using System;
using System.Collections.Generic;
using System.Text;

namespace CarRental.Entities
{
    public class Rental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }
        public Rental(DateTime rentalStart, DateTime rentalFinish, Vehicle vehicle)
        {
            Start = rentalStart;
            Finish = rentalFinish;
            Vehicle = vehicle;
            Invoice = null;
        }



    }
}
