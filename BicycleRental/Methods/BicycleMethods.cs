using BicycleRental.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace BicycleRental.Methods
{
    public class BicycleMethods
    {
        public void CreateBicycle()

        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Bicycle bicycle = new Bicycle();

            Console.WriteLine("Please, enter the Model of a bicycle.");
            string Model = Console.ReadLine();
            Console.WriteLine("Please, enter the Price of a bicycle.");
            int Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the Condition of a bicycle: Good/Very Good etc.");
            string Condition = Console.ReadLine();
            Console.WriteLine("Please, enter the Availability of a bicycle: Available/Not Available.");
            string Availability = Console.ReadLine();
            Console.WriteLine("Please, enter the Make Year of a bicycle.");
            int MakeYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the BicycleBrandId of a bicycle.");
            int BicycleBrandId = Convert.ToInt32(Console.ReadLine());

            bicycle.Model = Model;
            bicycle.Price = Price;
            bicycle.Condition = Condition;
            bicycle.Availability = Availability;
            bicycle.MakeYear = MakeYear;
            bicycle.BicycleBrandId = BicycleBrandId;

            Console.WriteLine("Well done! A new bicycle with its properties has been added to the database! Press enter if you want to return to the main menu.");

 
            bicycleRentalDBContext.Add(bicycle);
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


        public void UpdateBicycle()
        {
            BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

            Console.WriteLine("Please, enter BicycleId.");
            var bicycleId = Convert.ToInt32(Console.ReadLine());
            var bicycle = bicycleRentalDBContext.Bicycles.Find(bicycleId);

            Console.WriteLine("Please, enter the new model of a bicycle. Current model is:" + " " + bicycle.Model);
            string Model2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new price of a bicycle. Current price is:" + " " + bicycle.Price);
            int Price2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, enter the new condition of a bicycle. Current condition is:" + " " + bicycle.Condition);
            string Condition2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new availability of a bicycle. Current availability is:" + " " + bicycle.Availability);
            string Availability2 = Console.ReadLine();
            Console.WriteLine("Please, enter the new make year of a bicycle. Current make year is:" + " " + bicycle.MakeYear);
            int MakeYear2 = Convert.ToInt32(Console.ReadLine());

            bicycle.Model = Model2;
            bicycle.Price = Price2;
            bicycle.Condition = Condition2;
            bicycle.Availability = Availability2;
            bicycle.MakeYear = MakeYear2;

            Console.WriteLine("Well done! The updated Bicycle has been added to the database! Press enter if you want to return to the main menu.");
            bicycleRentalDBContext.Update(bicycle);
            try
            {
                bicycleRentalDBContext.SaveChanges();

            }

            catch (DbUpdateConcurrencyException exception)
            {
                Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); //Save info about the error in the variable
            }

            Console.ReadKey();
        }

            public void DeleteBicycle()
            {
                BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext(); //Why do we need to create a new variable to represent the database?

                Console.WriteLine("Please, enter BicycleId.");
                var bicycleId = Convert.ToInt32(Console.ReadLine());
                var bicycle = bicycleRentalDBContext.Bicycles.Find(bicycleId);

                try
                {

                 bicycleRentalDBContext.Remove(bicycle);
                 bicycleRentalDBContext.SaveChanges();
                }

                catch (DbUpdateConcurrencyException exception)
                {
                    Console.WriteLine($"Something went wrong. Sorry. Try again later.{exception}"); 
                }


                Console.WriteLine("Oops, the Bicycle has been deleted now. Hope that's what you wanted :P. Press enter if you want to return to the main menu.");
                Console.ReadKey();


            }

            public void ReadBicycle()
            {

                BicycleRentalDBContext bicycleRentalDBContext = new BicycleRentalDBContext();

                Console.WriteLine("Please, enter BicycleId.");
                var bicycleId = Convert.ToInt32(Console.ReadLine());
                var bicycle = bicycleRentalDBContext.Bicycles.Find(bicycleId);

             

                if (bicycle == null)
                {
                
                Console.WriteLine("BicycleId was not found.");

                }

                if (bicycle != null)
                {
                Console.WriteLine("Model is:" + " " + bicycle.Model);
                Console.WriteLine("Price is:" + " " + bicycle.Price);
                Console.WriteLine("Condition is:" + " " + bicycle.Condition);
                Console.WriteLine("Availability is:" + " " + bicycle.Availability);
                Console.WriteLine("Make year is:" + " " + bicycle.MakeYear);

                }
   
                Console.ReadKey();

            }

        }
    }
