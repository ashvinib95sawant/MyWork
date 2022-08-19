using System;
using System.Collections.Generic;
using System.Text;

namespace MyWork
{
    class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException()
        {

        }
        public InvalidPasswordException(string msg) : base(msg)
        {

        }
    }
    class studd
    {
        string username;
        string password;

        public string Username
        {
            set { this.username = value; }
            get { return username; }
        }
        public string Password
        {
            set
            {
                if (value.Length <= 5)
                    throw new InvalidPasswordException("password length should be greater than 5");
                else
                    this.password = value;
            }
            get { return password; }

        }

        static void Main(string[] args)
        {
            studd s1 = new studd();
            s1.Username = "tiya";
            try
            {
                s1.Password = "abcd";
            }
            catch (InvalidPasswordException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Main ends");
        }
    }
}
