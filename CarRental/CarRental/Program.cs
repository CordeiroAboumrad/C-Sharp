using System;
using System.Globalization;
using CarRental.Entities;
using CarRental.Services;

namespace CarRental
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data:");
            Console.WriteLine("Car Model: ");
            string vehicle = Console.ReadLine();

            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Rental rental = new Rental(start, finish, new Vehicle(vehicle));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.processInvoice(rental);

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(rental.Invoice);
        }
    }
}
