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

        public Person(string firstName, string lastName, string address, string city, string state, string phoneNo, string zipCode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.phoneNo = phoneNo;
            this.zipCode = zipCode;
        }



        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string Adderss { get => address; set => address = value; }
        public string City { get => City; set => City = value; }
        public string State { get => state; set => state = value; }
        public string PnoneNo { get => phoneNo; set => phoneNo = value; }
        public string ZipCode { get => zipCode; set => zipCode = value; }


        public override string ToString()
        {
            return "[firstName=" + firstName + ", lastName=" + lastName + ", address=" + address + ", city=" + city
                 + ", state=" + state + ", zipCode=" + zipCode + ", PhoneNo=" + phoneNo + "]" + "\n";
        }
    }
}
