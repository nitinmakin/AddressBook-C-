using System;
using System.Collections.Generic;
using System.Text;

namespace AdderssBook_Csharp
{
    public interface IAddressBook
    {
        public void add();
        public void display();
        public void edit(String firstName);
        public void delete(String firstName);
        public void sortByName();
       
    }
}
