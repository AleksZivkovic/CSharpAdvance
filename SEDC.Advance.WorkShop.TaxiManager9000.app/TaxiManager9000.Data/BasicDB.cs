using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Models;

namespace TaxiManager9000.Data
{
    public static class BasicDB
    {
        public static List<Car> Car { get; set; } = new List<Car>() { };
        public static List<User> User { get; set; } = new List<User>() { };    
        public static List<Driver> Driver { get; set; } = new List<Driver>() { };

        static BasicDB()
        {
           //Car car = new List<Car>();
           //User user = new List<User>();
           //Driver = new List<Driver>();

            Car Car1 = new Car(1, "Avensis", "SK-007-JB", new DateTime(2022,5,5));
            User User1 = new User(1, "Stefan Ivanovski", "password123");
            Driver Driver1 = new Driver(1, "Stefan", "Ivanovski");

            Car Car2 = new Car(2, "Golf", "SK-000-AS", new DateTime(2022, 6, 6));
            User User2 = new User(2, "Aneta Stankovska", "password456");
            Driver Driver2 = new Driver(2, "Aneta", "Stankovska");

            Car Car3 = new Car(3, "BMW", "SK-111-AZ", new DateTime(2022, 7, 7));
            User User3 = new User(3, "Aneta Stankovska", "password789");
            Driver Driver3 = new Driver(3, "Aleksandar", "Zivkovic");
        }
        

        
    }
    



}

