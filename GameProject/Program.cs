using GameProject.Abstract;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName ="Ayhan", LastName = "Ata", BirthDate = new DateTime(1981,1,1), IdentityId = "11111111111" };
            Customer customer2 = new Customer() { Id = 2, FirstName = "Veli", LastName = "Demirel", BirthDate = new DateTime(1982, 1, 1), IdentityId = "22222222222" };
            Customer customer3 = new Customer() { Id = 3, FirstName = "Selami", LastName = "Özden", BirthDate = new DateTime(1983, 1, 1), IdentityId = "33333333333" };

            Product product1 = new Product() { Id = 1, Name = "GTA", Price = 100 };
            Product product2 = new Product() { Id = 2, Name = "FIFA", Price = 100 };
            Product product3 = new Product() { Id = 3, Name = "WOW", Price = 100 };

            Campaing campaing1 = new Campaing() {Id = 1, CampainingName = "Black Friday Campaing", Price = 50 };
            Campaing campaing2 = new Campaing() { Id = 2, CampainingName = "New Year Campaing", Price = 50 };

            ICustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            customerManager.Add(customer1);
            customerManager.Update(customer2);
            customerManager.Delete(customer3);

            CampainingManager campainingManager = new CampainingManager();
            campainingManager.Add(campaing1);
            campainingManager.Delete(campaing1);            

            IProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Update(product2);
            productManager.Delete(product3);

            ISalesManager salesManager = new SalesManager();
            salesManager.Sell(customer1, product1);
            salesManager.SellWithCampain(customer2, product2,campaing1);
        }
    }
}
