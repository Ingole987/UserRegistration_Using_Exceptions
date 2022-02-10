using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration_Using_Exception
{
    class MyException : Exception
    {
        public MyException(String message) : base(message)
        {

        }

        public static void code()
        {
            
            Console.WriteLine("Choose what to Enter:");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. First Name.\n2. Last Name.\n3. EmailId.\n4. PhoneNumber.");
            Console.WriteLine("-------------------------");

            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter your First Name:");
                        Pattern name = new Pattern();
                        bool result = name.ValidateFirstName(Console.ReadLine());
                        Console.WriteLine(result);
                        if (result == false)
                        {
                            throw new MyException("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.WriteLine("Enter your Last Name:");
                        Pattern lastname = new Pattern();
                        bool resultlastname = lastname.ValidateLastName(Console.ReadLine());
                        Console.WriteLine(resultlastname);
                        if (resultlastname == false)
                        {
                            throw new MyException("Must contain characters only. Having first letter capital with minimum 3 characters.\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.WriteLine("Enter your Email Id:");
                        Pattern emailid = new Pattern();
                        bool resultemailid = emailid.ValidateEmail(Console.ReadLine());
                        Console.WriteLine(resultemailid);
                        if (resultemailid == false)
                        {
                            throw new MyException("Must contain Alphabet and Numeric Combination only.\nEnding with proper domain address e.g. '@gmail.com'\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("Enter your Phone Number:");
                        Pattern mobilenumber = new Pattern();
                        bool resultmobilenumber = mobilenumber.ValidateMobileNumber(Console.ReadLine());
                        Console.WriteLine(resultmobilenumber);
                        if (resultmobilenumber == false)
                        {
                            throw new MyException("Must contain integers only. Starting with '91' and space and having exact 10 digits as Phone Number.\n====================");
                        }
                    }
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
                    catch (MyException e)
                    {
                        Console.WriteLine("====================\nInvalid Input\n====================");
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
        }
    }
}
