using System;
using System.Text.RegularExpressions;

namespace Address_Book_System
{
    class CheckValidation
    {
        public string patternString = @"^[A-Za-z\-\'\s]+$";
        public string patternZipcode = "^\\d{5}$";
        public string patternEmail = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$";
        public string patternMobile = "^(\\+91[\\-\\s]?)?[789]\\d{9}$";

        public string isValidInput(string str)
        {
            bool input = Regex.IsMatch(str, patternString);
            while (!input)
            {
                Console.WriteLine("Invalid Input, Don't use specail characters");
                input = Regex.IsMatch(str, patternString);
                str = Console.ReadLine();
            }

            return str;
        }
        public string isValidZipcode(string str)
        {
            bool input = Regex.IsMatch(str, patternZipcode);
            while (!input)
            {
                Console.WriteLine("Invalid Input, Enter valid Zipcode");
                input = Regex.IsMatch(str, patternZipcode);
                str = Console.ReadLine();
            }
            return str;


        }
        public string isValidEmail(string str)
        {
            bool input = Regex.IsMatch(str, patternEmail);
            while (!input)
            {
                Console.WriteLine("Invalid Input, Enter valid Email");
                input = Regex.IsMatch(str, patternEmail);
                str = Console.ReadLine();
            }
            return str;
        }
        public string isValidNumber(string str)
        {
            bool input = Regex.IsMatch(str, patternMobile);
            while (!input)
            {
                Console.WriteLine("Invalid Input, Enter valid Number");
                input = Regex.IsMatch(str, patternMobile);
                str = Console.ReadLine();
            }
            return str;
        }
    }

}
