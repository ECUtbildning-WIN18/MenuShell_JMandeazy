using MenuShellz.Domain;
using System;
using System.Collections.Generic;

namespace MenuShellz.View
{
    class PrintUser : View
    {
        public void ListAllUsers(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }
            string x =Console.ReadLine();  
            Console.WriteLine("Press any key to go back to the receptionist menu");     
        }
    }
}
