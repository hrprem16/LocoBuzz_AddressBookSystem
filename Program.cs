using System;

namespace Address_Book_System
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            AddressBook ad1 = new AddressBook();
            ad1.addContact();
        }
    }
}