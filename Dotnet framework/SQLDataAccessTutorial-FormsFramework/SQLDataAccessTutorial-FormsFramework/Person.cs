﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDataAccessTutorial_FormsFramework
{
    public class Person
    {
        public int id {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        public string FullInfo()
        {
            return $"{ FirstName } { LastName } ({ EmailAddress })"; 
        }

    }
}
