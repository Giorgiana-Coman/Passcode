﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
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

                //On Branch1 create at least 1 commit and push those changes 

                //change 2


                //commit 3

                if (password != "secret")

                    Console.WriteLine("Wrong password");
            }
            Console.WriteLine("You are authenticate");
        }

        //Merge Branch1  into the Main branch 

    }
}
