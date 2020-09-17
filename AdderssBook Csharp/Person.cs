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

        public String getFirstName()
        {
            return firstName;
        }

        public void setFirstName(String firstName)
        {
            this.firstName = firstName;
        }

        public String getLastName()
        {
            return lastName;
        }

        public void setLastName(String lastName)
        {
            this.lastName = lastName;
        }

        public String getAddress()
        {
            return address;
        }

        public void setAddress(String address)
        {
            this.address = address;
        }

        public String getCity()
        {
            return city;
        }

        public void setCity(String city)
        {
            this.city = city;
        }

        public String getState()
        {
            return state;
        }

        public void setState(String state)
        {
            this.state = state;
        }

        public String getZipcode()
        {
            return zipCode;
        }

        public void setzipcode(String zipCode)
        {
            this.zipCode = zipCode;
        }

        public String getMobileNo()
        {
            return phoneNo;
        }

        public void setMobileNo(String phoneNo)
        {
            this.phoneNo = phoneNo;
        }


        public override string ToString()
        {
            return "[firstName=" + firstName + ", lastName=" + lastName + ", address=" + address + ", city=" + city
                 + ", state=" + state + ", zipCode=" + zipCode + ", PhoneNo=" + phoneNo + "]" + "\n";
        }
    }
}
