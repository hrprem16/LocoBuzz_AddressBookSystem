using System;
using System.Diagnostics.Metrics;
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
                Console.WriteLine("7.Search Contacts by state");
                Console.WriteLine("8.View Person by city");
                Console.WriteLine("9.View Person by state");
                Console.WriteLine("10.Show contact person count by City");
                Console.WriteLine("11.Show contact person count by State");
                Console.WriteLine("12.Sort the Contacts by person by fname/city/state/Zipcode");
                Console.WriteLine("13.Exit");
                

                int input1 = Convert.ToInt32(Console.ReadLine());
                
                switch (input1)
                {
                    case 1:
                        ad1.addContact(hs);
                        count++;
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
                        Console.WriteLine("Enter the city :");
                        String inputcity = Console.ReadLine();
                        ad1.searchByCity(addressbook,inputcity);
                      
                        break;
                    case 7:
                        Console.WriteLine("Enter the state :");
                        String inputstate = Console.ReadLine();
                        ad1.searchByState(addressbook, inputstate);
                        break;
                    case 8:
                        Console.WriteLine("Enter person and city that you want to check");
                        string inputFname = Console.ReadLine();
                        string inputCity = Console.ReadLine();
                        ad1.viewPersonByCity(inputFname, inputCity, addressbook);
                        break;
                    case 9:
                        Console.WriteLine("Enter person and state that you want to check");
                        string InputFname = Console.ReadLine();
                        string InputState = Console.ReadLine();
                        ad1.viewPersonByState(InputFname,InputState,addressbook);
                        break;
                    case 10:
                        Console.WriteLine("Enter city name to get no of contact person ");
                        string Inputcity= Console.ReadLine();
                        ad1.getContactByCity(Inputcity, addressbook);

                        break;
                    case 11:
                        Console.WriteLine("Enter the State to get the no of contact person ");
                        string Inputstate = Console.ReadLine();
                        ad1.getContactByState(Inputstate, addressbook);
                        break;
                    case 12:
                        Console.WriteLine("Enter the option given below to sort contacts");
                        Console.WriteLine("1. Sort By First Name");
                        Console.WriteLine("2. Sort By City");
                        Console.WriteLine("3. Sort By State");
                        Console.WriteLine("4. Sort By Zipcode");
                        int inputoption=Convert.ToInt32(Console.ReadLine());

                        switch (inputoption)
                        {
                            case 1:
                                ad1.SortByPersonName(addressbook);
                                break;
                            case 2:
                                ad1.SortByPersonCity(addressbook);
                                break;
                            case 3:
                                ad1.SortByPersonState(addressbook);
                                break;
                            case 4:
                                ad1.SortByPersonZip(addressbook);
                                break;
                            default:
                                Console.WriteLine("Invalid Input");
                                break;
                            

                        }
                        
                       
                        break;


                    case 13:
                        isrunning = false;
                        break;

                }

            }

        }
    }
}