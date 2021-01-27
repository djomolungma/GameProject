using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesManager
    {        
        public void Sell(Customer customer, Product product)
        {
            Console.WriteLine($"Products { product.Name} with price:{product.Price} was solt to {customer.FirstName}");
        }

        public void SellWithCampain(Customer customer, Product product, Campaing campaing)
        {
            Console.WriteLine($"Products { product.Name} with campain price:{campaing.Price} was solt to {customer.FirstName} with campaing {campaing.CampainingName}");
        }
    }
}
