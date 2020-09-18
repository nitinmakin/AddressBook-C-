using System;
using System.Collections.Generic;
using System.Text;

namespace AdderssBook_Csharp
{
    class Person
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String phoneNo;
        private String zipCode;

        public Person(string firstName, string lastName, string address, 
            string city, string state, string phoneNo, string zipCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.PhoneNo = phoneNo;
            this.ZipCode = zipCode;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }
        public override string ToString()
        {
            return "[firstName=" + FirstName + ", lastName=" + LastName + ", address=" + Address + ", city=" + City
                 + ", state=" + State + ", zipCode=" + ZipCode + ", PhoneNo=" + PhoneNo + "]" + "\n";
        }

       
    }
}
