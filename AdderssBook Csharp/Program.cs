using System;
using System.Diagnostics;

namespace AdderssBook_Csharp
{
    class Program
    {
        private String firstName;
        private String lastName;
        private String address;
        private String city;
        private String state;
        private String phoneNo;
        private String zipCode;

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
