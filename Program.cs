using System;
using System.Net;

namespace Address_Book_System
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");
            SortedDictionary<string, List<Contact> > addressbook = new SortedDictionary<string, List<Contact> >();
            HashSet <string> hs= new HashSet<string>(); 
            Console.WriteLine("Enter the name of the Address Book");
            string name = Console.ReadLine();
            AddressBook ad1 = new AddressBook(name,addressbook);
            int count = 0;
            bool isrunning = true;
            while (isrunning)
            {
                Console.WriteLine("Enter the option to perform");
                Console.WriteLine("1.Add Contact");
                Console.WriteLine("2.Display Contact");
                Console.WriteLine("3.Edit Contact");
                Console.WriteLine("4.Delete Contact");
                Console.WriteLine("5.Add Address Book");
                Console.WriteLine("6.Search Contacts by city");
                Console.WriteLine("7.Exit");

                int input1 = Convert.ToInt32(Console.ReadLine());
                
                switch (input1)
                {
                    case 1:
                        ad1.addContact(hs);
                        count++;
                        Console.WriteLine(count);
                        break;
                    case 2:
                        ad1.display(addressbook);
                        break;
                    case 3:
                        Console.WriteLine("Enter the  first name of the person you want to edit ");
                        string name1 = Console.ReadLine();
                        ad1.editContact(name1);
                        break;
                    case 4:
                        Console.WriteLine("Enter the  first name of the person you want to delete ");
                        string nam = Console.ReadLine();
                        ad1.deleteContact(nam);
                        break;
                    case 5:
                        if (count > 0)
                        {
                            Console.WriteLine("Enter the name of the Address Book");
                            name = Console.ReadLine();
                            ad1 = new AddressBook(name, addressbook);

                        }
                        else
                        {
                            Console.WriteLine("Atleast enter one contact");
                        }
                        break;
                    case 6:
                        String inputcity = Console.ReadLine();
                        ad1.searchByCity(addressbook,inputcity);
                      
                        break;
                    case 7:
                        isrunning = false;
                        break;

                }

            }

        }
    }
}