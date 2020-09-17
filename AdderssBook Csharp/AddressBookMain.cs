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
                Console.WriteLine("1.ADD 2.Display 3.edit");
                String option = Console.ReadLine();
                int option1 = Convert.ToInt32(option);

                if (option1 == 1)
                {
                    book.add();
                }

                else if (option1 == 2)
                    book.display();

                else if (option1 == 3)
                {
                    Console.WriteLine("Enter name");
                    String s = Console.ReadLine();
                    book.edit(s);
                }
                else
                    check = false;
            }

        }
    }
}
