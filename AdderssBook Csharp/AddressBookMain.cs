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
                Console.WriteLine("1.ADD 2.DISPLAY 3.EDIT 4.DELETE");
                String opt = Console.ReadLine();
                int option = Convert.ToInt32(opt);

                if (option == 1)
                    book.add();
                
                else if (option == 2)
                    book.display();

                else if (option == 3)
                {
                    Console.WriteLine("Enter name");
                    String name = Console.ReadLine();
                    book.edit(name);
                }

                else if(option == 4)
                {
                    Console.WriteLine("enter name");
                    String name = Console.ReadLine();
                    book.delete(name);

                }
                else
                    check = false;
            }

        }
    }
}
