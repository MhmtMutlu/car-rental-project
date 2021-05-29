using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // CarManagerTest();

            // UserManagerTest();

            RentalManagerTest();
        }

        private static void RentalManagerTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success == true)
            {
                foreach (var rental in rentalManager.GetAll().Data)
                {
                    Console.WriteLine(rental.Id + " - " + rental.CustomerId + " - " + rental.CarId + " - " + rental.RentDate + " - " + rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UserManagerTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success == true)
            {
                foreach (var user in userManager.GetAll().Data)
                {
                    Console.WriteLine(user.Id + " - " + user.FirstName + "  " + user.LastName + " - " + user.Email);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(car.CarName + " - " + car.ColorName + " - " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
