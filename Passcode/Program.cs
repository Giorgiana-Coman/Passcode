using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Passcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var password = "";
            while (password != "secret")
            {
                Console.WriteLine("Your password : ");
                password = Console.ReadLine();

                if (password != "secret")

                    Console.WriteLine("Wrong password");
            }
            Console.WriteLine("You are authenticate");
        }


    }
}
