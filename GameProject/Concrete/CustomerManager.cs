using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerManager : ICustomerManager
    {
        private ICustomerCheckManager _customerCheckManager;

        public CustomerManager(ICustomerCheckManager customerCheckManager)
        {
            _customerCheckManager = customerCheckManager;
        }
        public void Add(Customer customer)
        {
            if (_customerCheckManager.CheckIfRealPerson(customer))
            {
                Console.WriteLine($"Customer added : { customer.FirstName}  { customer.LastName}");
            }
            else
                throw new Exception("Not a valid person");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine($"Customer deleted : { customer.FirstName}  { customer.LastName}");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine($"Customer updated : { customer.FirstName}  { customer.LastName}");
        }
    }
}
