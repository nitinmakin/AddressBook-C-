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
    class AddressBookImpl : IAddressBook, IComparer<Person>
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
                if (list[i].FirstName.Equals(firstName))
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
                if (list[i].FirstName.Equals(firstName))
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
                if (list[i].FirstName.Equals(firstName))
                {
                    while (check == 0)
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
                                person.Address = address;
                                break;

                            case 2:
                                Console.WriteLine("enter new city");
                                String city = Console.ReadLine();
                                person.City = city;
                                break;

                            case 3:
                                Console.WriteLine("enter new state");
                                String state = Console.ReadLine();
                                person.State = state;
                                break;

                            case 4:
                                Console.WriteLine("enter new phoneNo");
                                String phoneNo = Console.ReadLine();
                                person.PhoneNo = phoneNo;
                                break;

                            case 5:
                                Console.WriteLine("enter new zipCode");
                                String zipCode = Console.ReadLine();
                                person.ZipCode = zipCode;
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

        public int Compare(Person x, Person y)
        {
             int option;
             Console.WriteLine("Enter input: 1.sort by name   2.sort by city   3.sort by state   4.sort by zip");
             String opt = Console.ReadLine();
             option = Convert.ToInt32(opt);

            if(option ==1)
                return x.FirstName.CompareTo(y.FirstName);

            if (option == 2)
                 return x.City.CompareTo(y.City);

            if (option == 3)
                return x.State.CompareTo(y.State);

            if (option == 4)
                return x.ZipCode.CompareTo(y.ZipCode);

            else return 0;

        }

        public void viewByCity(String city)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].City.Equals(city))
                    Console.WriteLine(list[i]);
            }

        }
        public void viewByState(String State)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].State.Equals(State))
                    Console.WriteLine(list[i]);
            }

        }

        public void searchPersonInCity(String name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(name))
                {
                    Console.WriteLine(list[i].City);
                }
            }

        }

        public void searchPersonInState(String name)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].FirstName.Equals(name))
                {
                    Console.WriteLine(list[i].State);
                }
            }

        }

    }
}









           

        
  