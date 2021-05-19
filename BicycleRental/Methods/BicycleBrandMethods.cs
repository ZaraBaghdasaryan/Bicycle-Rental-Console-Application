using BicycleRental.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace BicycleRental.Methods
{
    public class BicycleBrandMethods
    {
        public void CreateBicycleBrand()

        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            BicycleBrand bicycleBrand = new BicycleBrand();

            Console.WriteLine("Please, enter the Name for a BicycleBrand.");
            string Name = Console.ReadLine();
            Console.WriteLine("Please, enter the Location for a BicycleBrand.");
            string Location = Console.ReadLine();
            Console.WriteLine("Please, enter the Address for a BicycleBrand.");
            string Address = Console.ReadLine();
            Console.WriteLine("Please, enter the BicycleId for a BicycleBrand.");
            int BicycleId = Convert.ToInt32(Console.ReadLine());


            bicycleBrand.Name = Name;
            bicycleBrand.Location = Location;
            bicycleBrand.Address = Address;
          


            Console.WriteLine("Well done! A new BicycleBrand with its properties has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Add(bicycleBrand);
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

        public void UpdateBicycleBrand()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter BicycleBrandId.");
            var bicycleBrandId = Convert.ToInt32(Console.ReadLine());
            var bicycleBrand = bicycleRentalDBContext.BicycleBrands.Find(bicycleBrandId);

            Console.WriteLine("Please, enter the new Name for a BicycleBrand. Current Name is:" + " " + bicycleBrand.Name);
            string Name2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Location for a BicycleBrand. Current Location is:" + " " + bicycleBrand.Location);
            string Location2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new Address for a BicycleBrand. Current Address is:" + " " + bicycleBrand.Address);
            string Address2 = Console.ReadLine();


            bicycleBrand.Name = Name2;
            bicycleBrand.Location = Location2;
            bicycleBrand.Address = Address2;


            Console.WriteLine("Well done! The updated BicycleBrand has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Update(bicycleBrand);

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

        public void DeleteBicycleBrand()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext(); 
            Console.WriteLine("Please, enter BicycleBrandId.");
            var bicycleBrandId = Convert.ToInt32(Console.ReadLine());
            var bicycleBrand = bicycleRentalDBContext.BicycleBrands.Find(bicycleBrandId);

            try 
            {
                bicycleRentalDBContext.Remove(bicycleBrand);
                bicycleRentalDBContext.SaveChanges();
            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); //Save info about the error in the variable
            }

            Console.WriteLine("Oops, the BicycleBrand has been deleted now. Hope that's what you wanted :P. Press enter if you want to return to the main menu.");
            Console.ReadKey();

        }

        public void ReadBicycleBrand()
        {

            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter BicycleBrandId to find the right BicycleBrand.");
            var bicycleBrandId = Convert.ToInt32(Console.ReadLine());
            var bicycleBrand = bicycleRentalDBContext.BicycleBrands.Find(bicycleBrandId);

            if (bicycleBrand == null)
            {

                Console.WriteLine("BicycleBrandId was not found.");

            }

            if (bicycleBrand != null)

            {
                Console.WriteLine("Name is:" + " " + bicycleBrand.Name);
                Console.WriteLine("Location is:" + " " + bicycleBrand.Location);
                Console.WriteLine("Address is:" + " " + bicycleBrand.Address);
            }

            Console.ReadKey();

        }
    }
}

