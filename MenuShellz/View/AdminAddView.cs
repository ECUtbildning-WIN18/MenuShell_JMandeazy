using System;

namespace MenuShellz.View
{
    class AdminAddView : View
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public override string Display()
        {
            string result;

            do
            {
                base.Display();

                Console.WriteLine("Create a new user account:\n");

                Console.Write("\n<Username>: ");
                UserName = Console.ReadLine();
                Console.Write("\n<Password>: ");
                Password = Console.ReadLine();
                Console.Write("\n<Role>: ");
                Role = Console.ReadLine();
                Console.WriteLine("Is this correct (Y)es or (N)o?");
                result = Console.ReadLine();

            } while (result.ToUpper() != "Y");
            return result;
        }

    }
}
