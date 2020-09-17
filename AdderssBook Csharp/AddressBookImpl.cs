using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace AdderssBook_Csharp
{
    class AddressBookImpl : IAddressBook , IComparer<Person>
    {
        Person person = null;
        List<Person> list = new List<Person>();

        public object Comparator { get; private set; }

        public void add()
        {
            Console.WriteLine("Enter first name");
            String firstName = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {
                    Console.WriteLine("you are entering a dublicate person details");
                    return;
                }

            }

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

       

        public void delete(string firstName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {
                    list.Remove(person);
                }
            }
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
                     
            int check = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].getFirstName().Equals(firstName))
                {
                    while(check == 0) 
                    {
                        Person person = list[i];                                                
                        Console.WriteLine(person);
                        Console.WriteLine("1.address 2.city 3.state 4.phoneNo 5.zip  6.save & exit");
                        String opt = Console.ReadLine();
                        int option = Convert.ToInt32(opt);
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("enter new address");
                                String address = Console.ReadLine();
                                person.setAddress(address);
                                break;

                            case 2:
                                Console.WriteLine("enter new city");
                                String city = Console.ReadLine();
                                person.setCity(city);
                                break;

                            case 3:
                                Console.WriteLine("enter new state");
                                String state = Console.ReadLine();
                                person.setState(state);
                                break;

                            case 4:
                                Console.WriteLine("enter new phoneNo");
                                String phoneNo = Console.ReadLine();
                                person.setMobileNo(phoneNo);
                                break;

                            case 5:
                                Console.WriteLine("enter new zipCode");
                                String zipCode = Console.ReadLine();
                                person.setzipcode(zipCode);
                                break;

                            case 6:
                                check = 1;
                                break;
                                    
                                     
                        }
                }
            }
        }
    }
        public void sortByName()
        {

            list.Sort(this.Compare);
            this.display();
        }
     
        public int Compare( Person x , Person y)
        {
            return x.getFirstName().CompareTo(y.getFirstName());

        }
    }
}
