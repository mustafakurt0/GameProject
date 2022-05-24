using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;

namespace GameProject.Concrete
{
    internal class CustomerManager :  ICustomerService
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Add(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPersoN(customer))
            {
                Console.WriteLine("Added to db : " + customer.FirstName);
            }
            else
            {
                throw new Exception("db'ye eklenirken hata oluştu");
            }
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Customer Updated");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }
    }
}
