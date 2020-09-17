using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdderssBook_Csharp
{
    class AddressBookImpl : IAddressBook
    {
        Person person = null;
        List<Person> list = new List<Person>();
        public void add()
        {
            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();

            Console.WriteLine("Enter last name");
            String lastName = Console.ReadLine();

            Console.WriteLine("Enter address");
            String address = Console.ReadLine();

            Console.WriteLine("Enter city");
            String city = Console.ReadLine();

            Console.WriteLine("Enter state");
            String state = Console.ReadLine();

            Console.WriteLine("Enter phoneNo");
            String phoneNo = Console.ReadLine();

            Console.WriteLine("Enter Zip Code");
            String zipCode = Console.ReadLine();

            person = new Person(firstName, lastName, address, city, state, phoneNo, zipCode);
            list.Add(person);

        }

        public void display()
        {
            foreach (Person item in list)
            {
                Console.WriteLine(item);
            }
        }

        public void edit(String firstName)
        {

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {
                    Person person = list[i];
                    Console.WriteLine(person);

                    Console.WriteLine("enter new address");
                    String address = Console.ReadLine();
                    person.setAddress(address);

                    Console.WriteLine("enter new city");
                    String city = Console.ReadLine();
                    person.setCity(city);

                    Console.WriteLine("enter new state");
                    String state = Console.ReadLine();
                    person.setState(state);

                    Console.WriteLine("enter new phoneNo");
                    String phoneNo = Console.ReadLine();
                    person.setMobileNo(phoneNo);

                    Console.WriteLine("enter new zipCode");
                    String zipCode = Console.ReadLine();
                    person.setzipcode(zipCode);
                }
            }
        }
    }
}
