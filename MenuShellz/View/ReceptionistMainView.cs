﻿using System;

namespace MenuShellz.View
{
    class ReceptionistMainView : View
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("(1) List all users");
            Console.WriteLine("(2) Exit");
            
            /*var consoleKeyInfo = Console.ReadKey();

            switch (consoleKeyInfo.Key)
            {
                case ConsoleKey.D1:
                    return "1";
                case ConsoleKey.D2:
                    return "2";
                    default:*/
                    return "";
            }
        }
    }

