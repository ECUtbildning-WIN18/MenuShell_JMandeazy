﻿using System;

namespace MenuShellz.View
{
    class LoginView : View
    {     
        public string Username { get; set; }
        public string Password { get; set; }

        public override string Display()
        {
            string key = "";

            do
            {
                base.Display();   
                Console.WriteLine("Please enter your account information:\n");
                Console.Write("<Username>: ");
                Username = Console.ReadLine();
                Console.Write("<Password>: ");
                Password = Console.ReadLine();
                Console.Write("\nIs this correct? (Y)es (N)o: ");
                key = Console.ReadLine();
            } while (key.ToUpper() != "Y");
            return key;    
        }
    }
}
