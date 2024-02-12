using System;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Address_Book_System
{
	class AddressBook
	{
        List<Contact> Contacts;
        CheckValidation validation = new CheckValidation();

        public AddressBook(string name, SortedDictionary<string, List<Contact>> addressbook)
        {
            Contacts = new List<Contact>();
            addressbook[name] = Contacts;
        }
        

        //Add Contact in Cotancts list
        public void addContact(HashSet<string> hs)
		{
            Console.WriteLine("1. Read data by user ");
            Console.WriteLine("2. Import data from file");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                string fname;
                do
                {
                    Console.WriteLine("Enter the first name: ");

                    fname = validation.isValidInput(Console.ReadLine());
                    if (!hs.Contains(fname))
                    {
                        hs.Add(fname);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("This name is already present , Enter again");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                while (true);
                Console.WriteLine("Enter the last name: ");
                string lname = validation.isValidInput(Console.ReadLine());
                Console.WriteLine("Enter the address: ");
                string add = validation.isValidInput(Console.ReadLine());
                Console.WriteLine("Enter the city: ");
                string city = validation.isValidInput(Console.ReadLine());
                Console.WriteLine("Enter the state: ");
                string state = validation.isValidInput(Console.ReadLine());
                Console.WriteLine("Enter the Zipcode: ");
                string zipcode = validation.isValidZipcode(Console.ReadLine());
                
                Console.WriteLine("Enter the email: ");
                string email = validation.isValidEmail(Console.ReadLine());
                Console.WriteLine("Enter the Phone: ");
                string phone = validation.isValidNumber(Console.ReadLine());

                // Create instance of Contact 
                Contact newContact = new Contact(fname, lname, add, city, state, zipcode, email, phone);
                Contacts.Add(newContact);

                Console.WriteLine("Contact added successfully!");
            }
            //Import data from file
            else if (input == 2)
            {
                string path = @"/Users/prince/Desktop/Locobuzz Training/AddressBook/ImportFile.txt";
                string [] addrarry=File.ReadAllLines(path);
                

                foreach(string i in addrarry)
                {
                   string [] abc= i.Split(','); // Store the information of a person in abc sting array
                    Contact newContact = new Contact(abc[0], abc[1], abc[2], abc[3], abc[4], abc[5], abc[6], abc[7]);
                    Contacts.Add(newContact);
                    Console.WriteLine("Imported Information of a person successfully");
                }
            }
        }

        // Display the Contact
        public void display(SortedDictionary<String,List<Contact>> addressBook)
        {
            Console.WriteLine("1. Display the Contacts in Console");
            Console.WriteLine("2. Export the contacts in file");

            int a = Convert.ToInt32(Console.ReadLine());
            do
            {
                if (a == 1)
                {
                    foreach (List<Contact> adddr in addressBook.Values)
                    {
                        foreach (Contact contact in adddr)
                        {

                            Console.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                            Console.WriteLine($"Address : {contact.Address},{contact.City}");
                            Console.WriteLine($"Zipcode : {contact.Zipcode}");
                            Console.WriteLine($"Mobile No : {contact.Number}");
                            Console.WriteLine($"Email : {contact.Email}");


                        }

                    }
                    break;
                }
                else if (a == 2)
                {
                    string path = @"/Users/prince/Desktop/Locobuzz Training/AddressBook/Contact.txt";
                    using (StreamWriter writer = new StreamWriter(path))
                    {
                        foreach (String addr in addressBook.Keys)
                        {
                            List<Contact> adddr = addressBook[addr]; 
                            writer.WriteLine($"Address Book : {addr}");
                            foreach (Contact contact in adddr)
                            {

                                writer.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                                writer.WriteLine($"Address : {contact.Address},{contact.City},{contact.Zipcode}");
                                writer.WriteLine($"Contact : {contact.Number}");
                                writer.WriteLine($"Email : {contact.Email}");
                            }


                        }
                        Console.WriteLine("Exported Information Successfully");
                        Thread.Sleep(1000);// Stop the console for a bit
                    }

                    break;


                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            while (true);
        }

        public void editContact(string fname)
        {
            foreach(Contact con in Contacts)
            {
                if (con.FirstName == fname)
                {
                    Console.WriteLine("1.Edit First name :");
                    Console.WriteLine("2.Edit Last name :");
                    Console.WriteLine("3.Edit Address :");
                    Console.WriteLine("4.Edit City :");
                    Console.WriteLine("5.Edit State :");
                    Console.WriteLine("6.Edit Zipcode :");
                    Console.WriteLine("7.Edit Email  :");
                    Console.WriteLine("8.Edit Number  :");

                    int input = Convert.ToInt32(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            string Fname = Console.ReadLine();
                            con.FirstName = Fname;
                            break;
                        case 2:
                            string lname = Console.ReadLine();
                            con.LastName = lname;
                            break;
                        case 3:
                            string addr = Console.ReadLine();
                            con.Address = addr;
                            break;
                        case 4:
                            string city = Console.ReadLine();
                            con.City = city;
                            break;
                        case 5:
                            string state = Console.ReadLine();
                            con.State = state;
                            break;
                        case 6:
                            string zipcode = Console.ReadLine();
                            con.Zipcode = zipcode;
                            break;
                        case 7:
                            string email = Console.ReadLine();
                            con.State = email;
                            break;
                        case 8:
                            string number = Console.ReadLine();
                            con.Number = number;
                            break;
                        default:
                            Console.WriteLine("Invalid Input :");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("User Not Found!");
                }
            }
        }
        public void deleteContact(string fname)
        {
            Contact abc = null;
            foreach(var con in Contacts)
            {
                if (con.FirstName == fname)
                {
                    abc = con;
                }
                
            }
            Contacts.Remove(abc);
        }

        public void searchByCity(SortedDictionary<String, List<Contact>> addressBook, string city)
        {
            foreach(List<Contact> adddr in addressBook.Values)
            {
                foreach(Contact contact in adddr)
                {
                    if (contact.City == city)
                    {

                        Console.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                        Console.WriteLine($"Address : {contact.Address},{contact.City},{contact.Zipcode}");
                        Console.WriteLine($"Contact : {contact.Number}");
                        Console.WriteLine($"Email : {contact.Email}");
                    }
                }
            }
        }

        public void searchByState(SortedDictionary<String, List<Contact>> addressBook, string state)
        {
            foreach (List<Contact> adddr in addressBook.Values)
            {
                foreach (Contact contact in adddr)
                {
                    if (contact.State == state)
                    {

                        Console.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                        Console.WriteLine($"Address : {contact.Address},{contact.City},{contact.Zipcode}");
                        Console.WriteLine($"Contact : {contact.Number}");
                        Console.WriteLine($"Email : {contact.Email}");
                    }
                }
            }
        }

        public void viewPersonByCity(string fname, string city, SortedDictionary<string ,List<Contact>> addressbook)
        {
            foreach (List<Contact> adddr in addressbook.Values)
            {
                foreach (Contact contact in adddr)
                {
                    if(contact.FirstName==fname && contact.City == city)
                    {
                        Console.WriteLine($"Contact of {fname} is present in this {city}");
                    }
                }
            }
        }

        public void viewPersonByState(string fname, string state, SortedDictionary<string, List<Contact>> addressbook)
        {
            foreach (List<Contact> adddr in addressbook.Values)
            {
                foreach (Contact contact in adddr)
                {
                    if (contact.FirstName == fname && contact.State == state)
                    {
                        Console.WriteLine($"Contact of {fname} is present in this {state}");
                    }
                }
            }
        }

        public void getContactByCity(string city, SortedDictionary<string,List<Contact> > addressbook)
        {
            int count = 0;
            foreach(List<Contact> adddr in addressbook.Values)
            {
                foreach(Contact contact in adddr)
                {
                    if (contact.City == city)
                    {
                        count++;
                    }
                   
                }
                Console.WriteLine($"No of Contact in city {city} is {count}");
            }
        }

        public void getContactByState(string state, SortedDictionary<string, List<Contact>> addressbook)
        {
            int count = 0;
            foreach (List<Contact> adddr in addressbook.Values)
            {
                foreach (Contact contact in adddr)
                {
                    if (contact.State ==state )
                    {
                        count++;
                    }

                }
                Console.WriteLine($"No of Contact in state {state} is {count}");
            }

        }

        public void SortByPersonName(SortedDictionary<string, List<Contact>> addressbook)
        {
            foreach(List<Contact> addr in addressbook.Values)
            {
                 addr.OrderBy(n => n.FirstName).ToList();
            }
        }

        public void SortByPersonCity(SortedDictionary<string, List<Contact>> addressbook)
        {
            foreach (List<Contact> addr in addressbook.Values)
            {
                addr.OrderBy(n => n.City).ToList();
            }
        }
        public void SortByPersonState(SortedDictionary<string, List<Contact>> addressbook)
        {
            foreach (List<Contact> addr in addressbook.Values)
            {
                addr.OrderBy(n => n.State).ToList();
            }
        }
        public void SortByPersonZip(SortedDictionary<string, List<Contact>> addressbook)
        {
            foreach (List<Contact> addr in addressbook.Values)
            {
                addr.OrderBy(n => n.Zipcode).ToList();
            }
        }
    }
}

