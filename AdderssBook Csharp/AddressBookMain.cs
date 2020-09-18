using System;
using System.Collections.Generic;
using System.Text;

namespace AdderssBook_Csharp
{
    class AddressBookMain
    {
        static void Main(String[] args)
        {
            IAddressBook book = new AddressBookImpl();
            Boolean check = true;
            while (check == true)
            {
                Console.WriteLine("1.ADD 2.DISPLAY 3.EDIT 4.DELETE  5.SORT  6.VIEW  9.EXIT");
                String opt = Console.ReadLine();
                int option = Convert.ToInt32(opt);

                switch (option)
                {
                    case 1:
                        book.add();
                        break;
                    case 2:
                        book.display();
                        break;
                    case 3:
                        Console.WriteLine("Enter name");
                        String editName = Console.ReadLine();
                        book.edit(editName);
                        break;
                    case 4:
                        Console.WriteLine("enter name");
                        String deleteName = Console.ReadLine();
                        book.delete(deleteName);
                        break;
                    case 5:
                        book.sortByName();
                        break;
                    case 6:

                        Console.WriteLine("1.VIEW BY CITY   2.VIEW BY STATE");
                        String optn = Console.ReadLine();
                        int num = Convert.ToInt32(optn);

                        if (num == 1)
                        {
                            Console.WriteLine("Enter city");
                            String city = Console.ReadLine();
                            book.viewByCity(city);
                        }
                        else if (num == 2)
                        {
                            Console.WriteLine("Enter State");
                            String state = Console.ReadLine();
                            book.viewByState(state);
                        }

                        else
                            Console.WriteLine("enter valid number");
                        break;

                    case 9:
                        check = false;
                        break;
                }

            }
        }
    }
}



