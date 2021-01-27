using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampainingManager : ICampainingManager
    {
        public void Add(Campaing campaing)
        {
            Console.WriteLine("Campaign added : " + campaing.CampainingName);
        }

        public void Delete(Campaing campaing)
        {
            Console.WriteLine("Campaign deleted : " + campaing.CampainingName);
        }

        public void Update(Campaing campaing)
        {
            Console.WriteLine("Campaign updated : " + campaing.CampainingName);
        }
    }
}
