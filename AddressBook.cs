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
            Console.WriteLine("Contact Added Successfully!");

        }
        // Display the Contact
        public void display()
        {

            foreach (var contact in Contacts)
            {
                Console.WriteLine($"Name : {contact.FirstName} {contact.LastName}");
                Console.WriteLine($"Address : {contact.Address},{contact.City},{contact.Zipcode}");
                Console.WriteLine($"Contact : {contact.Number}");
                Console.WriteLine($"Email : {contact.Email}");
            }
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
    }
}

