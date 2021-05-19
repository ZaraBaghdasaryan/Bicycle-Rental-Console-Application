using System;
using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;

namespace BicycleRental.Methods
{
    public class RentalCenterMethods
    {
        public void CreateRentalCenter()

        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            RentalCenter rentalCenter = new RentalCenter();

            Console.WriteLine("Please, enter the Name for a RentalCenter.");
            string Name = Console.ReadLine(); 
            Console.WriteLine("Please, enter the Address for a RentalCenter.");
            string Address = Console.ReadLine();
            Console.WriteLine("Please, enter the Phone Number for a RentalCenter.");
            int PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the Email for a RentalCenter.");
            string Email = Console.ReadLine();
            Console.WriteLine("Please, enter the BicycleId for a RentalCenter.");
            int BicycleId = Convert.ToInt32(Console.ReadLine()); 


            rentalCenter.Name = Name;
            rentalCenter.Address = Address;
            rentalCenter.PhoneNumber = PhoneNumber;
            rentalCenter.Email = Email;
            rentalCenter.BicycleId = BicycleId;


            Console.WriteLine("Well done! A new RentalCenter with its properties has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Add(rentalCenter);
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

        public void UpdateRentalCenter()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter RentalCenterId.");
            var rentalCenterId = Convert.ToInt32(Console.ReadLine());
            var rentalCenter = bicycleRentalDBContext.RentalCenters.Find(rentalCenterId);

            Console.WriteLine("Please, enter the new Name for a RentalCenter. Current Name is:" + " " + rentalCenter.Name);
            string Name2 = Console.ReadLine(); 
            Console.WriteLine("Please, enter the new Address for a RentalCenter. Current Address is:" + " " + rentalCenter.Address);
            string Address2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Phone Number for a RentalCenter. Current Phone Number is:" + " " + rentalCenter.PhoneNumber);
            int PhoneNumber2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the new Email for a RentalCenter. Current Email is:" + " " + rentalCenter.Email);
            string Email2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new BicycleId for a RentalCenter. Current BicycleId is:" + " " + rentalCenter.BicycleId);
            int BicycleId2 = Convert.ToInt32(Console.ReadLine());


            rentalCenter.Name = Name2;
            rentalCenter.Address = Address2;
            rentalCenter.PhoneNumber = PhoneNumber2;
            rentalCenter.Email = Email2;
            rentalCenter.BicycleId = BicycleId2;


            Console.WriteLine("Well done! The updated RentalCenter with its properties has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Update(rentalCenter);
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

        public void DeleteRentalCenter()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();
            Console.WriteLine("Please, enter RentalCenterId.");
            var rentalCenterId = Convert.ToInt32(Console.ReadLine());
            var rentalCenter = bicycleRentalDBContext.RentalCenters.Find(rentalCenterId);

            try
            {

                bicycleRentalDBContext.Remove(rentalCenter);
                bicycleRentalDBContext.SaveChanges();
            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); 
            }

            Console.WriteLine("Oops, the RentalCenter has been deleted now. Hope that's what you wanted :P. Press enter if you want to return to the main menu.");
            Console.ReadKey();

        }

        public void ReadRentalCenter()
        {

            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter RentalCenterId.");
            var rentalCenterId = Convert.ToInt32(Console.ReadLine());
            var rentalCenter = bicycleRentalDBContext.RentalCenters.Find(rentalCenterId);
           
            if (rentalCenter == null)
            {

                Console.WriteLine("BicycleId was not found.");

            }

            if (rentalCenter != null)
            {
                Console.WriteLine("Name is:" + " " + rentalCenter.Name);
                Console.WriteLine("Address is:" + " " + rentalCenter.Address);
                Console.WriteLine("Phone Number is:" + " " + rentalCenter.PhoneNumber);
                Console.WriteLine("Email is:" + " " + rentalCenter.Email);
                Console.WriteLine("BicycleId is:" + " " + rentalCenter.BicycleId);
    
            }

            Console.ReadKey();
        }
    }
}
