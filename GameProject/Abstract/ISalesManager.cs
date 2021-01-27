using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface ISalesManager
    {
        void SellWithCampain(Customer customer, Product product, Campaing campaing);        
        void Sell(Customer customer, Product product);


    }
}
