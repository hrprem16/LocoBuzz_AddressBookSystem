using System;

namespace Address_Book_System
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            AddressBook ad1 = new AddressBook();
            bool isrunning = true;
            while (isrunning)
            {
                Console.WriteLine("Enter the option to perform");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contact");
                Console.WriteLine("3.Edit Contact");
                Console.WriteLine("4.Delete Contact");
                Console.WriteLine("5.Exit");


                int input1 = Convert.ToInt32(Console.ReadLine());
                switch (input1)
                {
                    case 1:
                        ad1.addContact();
                        break;
                    case 2:
                        ad1.display();
                        break;
                    case 3:
                        Console.WriteLine("Enter the  first name of the person you want to edit ");
                        string name = Console.ReadLine();
                        ad1.editContact(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter the  first name of the person you want to delete ");
                        string nam = Console.ReadLine();
                        ad1.deleteContact(nam);
                        break;
                    case 5:
                        isrunning = false;
                        break;

                }

            }

        }
    }
}