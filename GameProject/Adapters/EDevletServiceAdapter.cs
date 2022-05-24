using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Entities;

namespace GameProject.Adapters
{
    internal class EDevletServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPersoN(Customer customer)
        {
            Console.WriteLine("E-Devlet Kontrol İşlemi Devam Ediyor");
            return true;
        }
    }
}
