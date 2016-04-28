﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{

    public class Employee
    {
        int employeeID;
        string lastName;
        string firstName;
        string title;
        string address;
        string city;
        string region;
        string postalCode;
        string country;
        string extension;

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        public string PostalCode
        {
            get { return postalCode; }
            set { postalCode = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Extension
        {
            get { return extension; }
            set { extension = value; }
        }

    }
}
