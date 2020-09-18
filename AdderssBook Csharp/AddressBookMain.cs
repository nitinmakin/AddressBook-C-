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
                Console.WriteLine("1.ADD 2.DISPLAY 3.EDIT 4.DELETE  5.SORT  9.EXIT");
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
                    case 9:
                        check = false;
                        break;
                }

            }
        }
    }
}



