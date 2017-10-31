﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DALValidator
    {
        public static Boolean CitizenValidator(Citizens citizen)
        {
            // First condition checks if name is empty
            // Second condition checks to make sure if the name is valid
            // Up to three names, each has to start with uppercase and minimum 2 letters per name
            if(citizen.Name == "" || 
                !Regex.Match(citizen.Name, @"^[A-Z][a-zA-Z]{2,}(?:[A-Z][a-zA-Z]*){0,2}$").Success)
            {
                Console.Write("Invalid Name");
                return false;
            }
            if(citizen.Salary < 0)
            {
                Console.Write("Cannot be a negative number for salary.");
                return false;
            }
            if(citizen.HomeAddress < 0 || citizen.WorkAddress < 0)
            {
                Console.Write("Must be greater than 0");
                return false;
            }
            if(citizen.Age <= 0)
            {
                Console.Write("Age cannot be less than 0");
                return false;
            }
            if(citizen.DaysLeftToLive < 0)
            {
                Console.Write("Days cannot be less than 0");
                return false;
            }
            return true;
        }
    }
}