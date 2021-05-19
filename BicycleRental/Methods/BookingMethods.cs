using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BicycleRental.Methods
{
   public class BookingMethods
    {
        public void CreateBooking() 

        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Booking booking = new Booking();

           
            Console.WriteLine("Please, enter the Rental Date of a booking.");
            string RentalDate = Console.ReadLine();
            Console.WriteLine("Please, enter the Price of a booking.");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the CustomerId of a booking.");
            int CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the Extension Date of a booking.");
            string ExtensionDate = Console.ReadLine();

            bool x = true;

            while (x == true)
            {
                Console.WriteLine("Press 1 to add bicycle and press 2 to exit." );
                var input = Console.ReadLine();
                switch(input)

                { 
                    case "1":
                        Console.WriteLine("Please, choose a bicycleId to add a bicycle");

                        var bicycleId = Convert.ToInt32(Console.ReadLine());

                        var listofbicycles = bicycleRentalDBContext.Bicycles.Where(b => b.Id == bicycleId).ToList();

                        booking.Bicycles = listofbicycles;
                        break;

                   case "2":

                    x = false;
                    
                   break;
                }
            }


            booking.CustomerId = CustomerId;
            booking.RentalDate = RentalDate;
            booking.Price = Price;
            booking.ExtensionDate = ExtensionDate;


            Console.WriteLine("Well done! A new booking with its properties has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Add(booking);
            try
            {
                bicycleRentalDBContext.SaveChanges();

            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}");
            }

            Console.ReadKey();

     }

        public void UpdateBooking()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter BookingId.");
            var bookingId = Convert.ToInt32(Console.ReadLine());
            var booking = bicycleRentalDBContext.Bookings.Find(bookingId);

         
            Console.WriteLine("Please, enter the new Rental Date for a booking. Current Rental Date is:" + " " + booking.RentalDate);
            string RentalDate2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Price for a booking. Current Price is:" + " " + booking.Price);
            int Price2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the new CustomerId for a booking. Current CustomerId is:" + " " + booking.CustomerId);
            int CustomerId2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the new Extension Date for a booking. Current Extension Date is:" + " " + booking.ExtensionDate);
            string ExtensionDate2 = Console.ReadLine();

            booking.RentalDate = RentalDate2;
            booking.Price = Price2;
            booking.CustomerId = CustomerId2;
            booking.ExtensionDate = ExtensionDate2;


            Console.WriteLine("Well done! The updated Booking has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Update(booking);
            try
            {
                bicycleRentalDBContext.SaveChanges();

            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}");
            }

            Console.ReadKey();
        }
        public async Task<Booking> ReadBooking()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter BookingId.");
            var bookingId = Convert.ToInt32(Console.ReadLine());
            var booking = await bicycleRentalDBContext.Bookings.Include(x => x.Customer).Include(x => x.Bicycles).FirstOrDefaultAsync(x => x.Id == bookingId);

            if (booking == null)
            {

                Console.WriteLine("BookingId was not found.");

            }

            if (booking != null)
            {
                Console.WriteLine("RentalDate is:" + " " + booking.RentalDate);
                Console.WriteLine("Price is:" + " " + booking.Price);
                Console.WriteLine("CustomerId is:" + " " + booking.CustomerId);
                Console.WriteLine("ExtensionDate is:" + " " + booking.ExtensionDate);
            }

            foreach (var bicycle in booking.Bicycles)
            {
                
                Console.WriteLine(bicycle.Condition);
                Console.WriteLine(bicycle.Availability);
                Console.WriteLine(bicycle.Model);
                Console.WriteLine(bicycle.Price);
            }

            Console.ReadKey();
            return booking;

        }
        public void DeleteBooking()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext(); 

            Console.WriteLine("Please, enter BookingId.");
            var bookingId = Convert.ToInt32(Console.ReadLine());
            var booking = bicycleRentalDBContext.Bookings.Find(bookingId);

            try
            {

                bicycleRentalDBContext.Remove(booking);
                bicycleRentalDBContext.SaveChanges();
            }
            catch (DbUpdateConcurrencyException exception)

            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); //Save info about the error in the variable
            }

            Console.WriteLine("Oops, the Booking has been deleted now. Hope that's what you wanted :P. Press enter if you want to return to the main menu.");
            Console.ReadKey();
        }
       

    }
}
