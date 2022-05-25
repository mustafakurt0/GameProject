using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class SaleManager : ISaleService
    {
        public void Sell(Customer customer, Game game, Campaign campaign)
        {
            Console.WriteLine("Kampanya uygulandı : " + campaign.Name);
            Console.WriteLine("Satış işlemleri devam ediyor...");
            Console.WriteLine("Oyun : " + game.Name);
            Console.WriteLine("Müşteri : " + customer.FirstName );
            Console.WriteLine("Satış başarıyla gerçekleşti");
        }

        public void Sell(Customer customer, Game game)
        {
            Console.WriteLine("Satış işlemleri devam ediyor...");
            Console.WriteLine("Oyun : " + game.Name);
            Console.WriteLine("Müşteri : " + customer.FirstName);
            Console.WriteLine("Satış başarıyla gerçekleşti");
            
        }
    }
}
