﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CustomerCheckManager : ICustomerCheckManager
    {
        public bool CheckIfRealPerson(Customer costomer)
        {
            return true;
        }
    }
}
