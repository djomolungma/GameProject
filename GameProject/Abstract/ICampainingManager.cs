using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface ICampainingManager
    {
        void Add(Campaing campaining);
        void Update(Campaing campaining);
        void Delete(Campaing campaining);
    }
}
