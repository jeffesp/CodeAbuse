﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbuse.Factories
{
    class BadFactories
    {
        public class CustomRepository
        {
            public void Save(Customer customer)
            {
                if (!customer.ValidatePhoneNumber())
                {
                    throw new ArgumentException();
                }
            }
        }

        public class Customer
        {
            private string _phoneNumber;
            public bool ValidatePhoneNumber()
            {
                //if PhoneNumber is not valid
                return false;
            }
        }
    }
}
