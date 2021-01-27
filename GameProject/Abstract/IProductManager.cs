using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IProductManager
    {
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
    }
}
