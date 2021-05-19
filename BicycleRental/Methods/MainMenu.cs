using System;



namespace BicycleRental.Methods
{
    class MainMenu
    {
        public void StartMenu() 
        {
            Console.WriteLine("Welcome to Bicycle Rental Database! Choose the option you prefer.");
            Console.WriteLine("Press 1 to create value.");
            Console.WriteLine("Press 2 to update value.");
            Console.WriteLine("Press 3 to read value.");
            Console.WriteLine("Press 4 to delete value.");

            string process = Console.ReadLine();

            switch (process)
            {
                case "1":
                    CreateMenu();
                    StartMenu(); 
                    break;



                case "2":
                    UpdateMenu();
                    StartMenu(); 
                    break; 
                    

                case "3":
                    ReadMenu(); //Jumping back into a larger method circle
                    StartMenu(); 
                    break;


                case "4":

                    DeleteMenu();
                    StartMenu();
                    break;

                    default:        //Case 5 
                    StartMenu();
                    break;

            }
        }
        public void CreateMenu()
        {
        
            BicycleMethods bicycleMethods = new BicycleMethods();
            Console.WriteLine("Press 1 to create Bicycle." );

            BookingMethods bookingMethods = new BookingMethods();
            Console.WriteLine("Press 2 to create Booking.");

            CustomerMethods customerMethods = new CustomerMethods();
            Console.WriteLine("Press 3 to create Customer.");

            BicycleBrandMethods bicycleBrandMethods = new BicycleBrandMethods();
            Console.WriteLine("Press 4 to create BicycleBrand.");

            RentalCenterMethods rentalCenterMethods = new RentalCenterMethods(); 
            Console.WriteLine("Press 5 to create RentalCenter."); 


            var input  = Console.ReadLine();
            
            switch (input)


            {
                case "1":

                    bicycleMethods.CreateBicycle();
                    StartMenu();
                    break;

                case "2":

                    bookingMethods.CreateBooking();
                    StartMenu();
                    break;

                case "3":

                    customerMethods.CreateCustomer();
                        StartMenu();
                        break;

                case "4":

                    bicycleBrandMethods.CreateBicycleBrand();
                    StartMenu();
                    break;

                case "5":

                    rentalCenterMethods.CreateRentalCenter();
                    StartMenu();
                    break;
            }
        }

        public void UpdateMenu()
        {
        
            BicycleMethods bicyclemethods = new BicycleMethods();
            Console.WriteLine("Press 1 to update Bicycle.");

            CustomerMethods customerMethods = new CustomerMethods();
            Console.WriteLine("Press 2 to update Customer.");

            BookingMethods bookingMethods = new BookingMethods();
            Console.WriteLine("Press 3 to update Booking.");

            BicycleBrandMethods bicycleBrandMethods = new BicycleBrandMethods();
            Console.WriteLine("Press 4 to update BicycleBrand.");

            RentalCenterMethods rentalCenterMethods = new RentalCenterMethods();
            Console.WriteLine("Press 5 to update RentalCenter.");


            var input = Console.ReadLine();

            switch (input)


            {
                case "1":

                    bicyclemethods.UpdateBicycle();
                    StartMenu();
                    break;

                case "2":
                    customerMethods.UpdateCustomer();
                    StartMenu();
                    break;

                case "3":
                    bookingMethods.UpdateBooking();
                    StartMenu();
                    break;

                case "4":
                    bicycleBrandMethods.UpdateBicycleBrand();
                    StartMenu();
                    break;

                case "5":
                    rentalCenterMethods.UpdateRentalCenter();
                    StartMenu();
                    break;

            }
        }

        public void DeleteMenu()
        {
        
            BicycleMethods bicyclemethods = new BicycleMethods();
            Console.WriteLine("Press 1 to delete Bicycle.");

            CustomerMethods customerMethods = new CustomerMethods(); 
            Console.WriteLine("Press 2 to delete Customer.");

            BookingMethods bookingMethods = new BookingMethods();
            Console.WriteLine("Press 3 to delete Booking.");

            BicycleBrandMethods bicycleBrandMethods = new BicycleBrandMethods();
            Console.WriteLine("Press 4 to delete BicycleBrand.");

            RentalCenterMethods rentalCenterMethods = new RentalCenterMethods();
            Console.WriteLine("Press 5 to delete RentalCenter.");

            var input = Console.ReadLine();

            switch (input)


            {
                case "1":

                    bicyclemethods.DeleteBicycle();
                    StartMenu();
                    break;

                case "2":
                    customerMethods.DeleteCustomer();
                    StartMenu();
                    break;

                case "3":
                    bookingMethods.DeleteBooking();
                    StartMenu();
                    break;

                case "4":
                    bicycleBrandMethods.DeleteBicycleBrand();
                    StartMenu();
                    break;

                case "5":
                    rentalCenterMethods.DeleteRentalCenter();
                    StartMenu();
                    break;

            }

        }

        public void ReadMenu()
        {
        
            BicycleMethods bicyclemethods = new BicycleMethods();
            Console.WriteLine("Press 1 to read Bicycle."); // A list of bicycles?

            CustomerMethods customerMethods = new CustomerMethods(); 
            Console.WriteLine("Press 2 to read Customer.");

            BookingMethods bookingMethods = new BookingMethods();
            Console.WriteLine("Press 3 to read Booking.");

            BicycleBrandMethods bicycleBrandMethods = new BicycleBrandMethods();
            Console.WriteLine("Press 4 to read BicycleBrand.");

            RentalCenterMethods rentalCenterMethods = new RentalCenterMethods();
            Console.WriteLine("Press 5 to read RentalCenter.");


            var input = Console.ReadLine();

            switch (input)


            {
                case "1":
                    bicyclemethods.ReadBicycle();
                    StartMenu();
                    break;

                case "2":
                    customerMethods.ReadCustomer();
                    StartMenu();
                    break;

                case "3":
                    bookingMethods.ReadBooking();
                    StartMenu();
                    break;

                case "4":
                    bicycleBrandMethods.ReadBicycleBrand();
                    StartMenu();
                    break;

                case "5":
                    rentalCenterMethods.ReadRentalCenter();
                    StartMenu();
                    break;


            }
        }



    }
}
