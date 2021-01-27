using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
    public class Campaing : IEntity
    {
        public int Id { get; set; }
        public string CampainingName { get; set; }
        public int Price { get; set; }
    }
}
