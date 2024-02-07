using System;
namespace Address_Book_System
{
	class AddressBook
	{
		List<Contact> Contacts = new List<Contact>();

        //Add Contact in Cotancts list
        public void addContact()
		{
            Console.WriteLine("Enter the first name: ");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter the last name: ");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter the address: ");
            string add = Console.ReadLine();
            Console.WriteLine("Enter the city: ");
            string city = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            string state = Console.ReadLine();
            Console.WriteLine("Enter the Phone: ");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter the zipcode: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the email: ");
            string email = Console.ReadLine();

            // Create instance of Contact 
            Contact newContact = new Contact(fname, lname, add, city, state, zipcode, email, phone);

            Contacts.Add(newContact);

        }
    }
}

