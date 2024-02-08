using System;
namespace Address_Book_System
{
    class Contact
    {
        // class Properties
        private string firstname;
        private string lastname;
        private string address;
        private string city;
        private string state;
        private string zipcode;
        private string email;
        private string number;

        //Constructor

        public Contact(string fn, string ln, string add, string c, string s, string z, string e, string n)
        {
            this.FirstName = fn;
            this.LastName = ln;
            this.Address = add;
            this.City = c;
            this.State = s;
            this.Zipcode = z;
            this.Email = e;
            this.Number=n;
        }
        //Getter and Setter 
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastname;

            }
            set
            {
                lastname = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }
        public string Zipcode
        {
            get
            {
                return zipcode;
            }
            set
            {
                zipcode = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }




    }
}

