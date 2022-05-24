using System;
using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;

namespace GameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1 ,
                FirstName = "Mustafa",
                LastName = "Kurt",
                DateTime = new DateTime(2001,08,07),
                NationalityId = "111111111"
            };

            EDevletServiceAdapter eDevletServiceAdapter = new EDevletServiceAdapter();
            CustomerManager customerManager = new CustomerManager(eDevletServiceAdapter);
            
            //customerManager.Add(customer);

            Game witcher3 = new Game
            {
                Id = 1,
                Name = "Witcher 3",
                CompanyName = "CD Projekt RED",
                Price = 150
            };

            Game rdr2 = new Game
            {
                Id =  2,
                Name = "Red Dead Redemption 2",
                CompanyName = "Rockstar Games",
                Price = 200
            };

            Game gta5 = new Game
            {
                Id = 3,
                Name = "Grand Theft Auto V",
                CompanyName = "Rockstar Games",
                Price = 170
            };

            Campaign campaign = new Campaign
            {
                Id = 1,
                Name = "Yılbaşı İndirimi"
            };

            SaleManager saleManager = new SaleManager();

            saleManager.Sell(customer ,gta5);
            Console.WriteLine("****************************************");
            saleManager.Sell(customer,witcher3 ,campaign);



        }
    }
}
