using System;
using System.Threading;

namespace MenuShellz.View
{
    class AdminDeleteView : View        
    {
        public override string Display()
        {
            base.Display();
            Console.WriteLine("Which user would you like to delete?");
            Thread.Sleep(1000);
            return "";
        }
    }
}
