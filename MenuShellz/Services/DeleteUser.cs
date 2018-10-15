using MenuShellz.Domain;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MenuShellz.View
{
    class DeleteUser
    {
        public void RemoveUser(List<User> users)
        {
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($" ({ i + 1}) {users[i].UserName}");
            }

            Console.WriteLine("Select the number you would like to remove.");
            int removal = int.Parse(Console.ReadLine());
            Thread.Sleep(500);
            users.RemoveAt(removal - 1);

        }
    }
}
