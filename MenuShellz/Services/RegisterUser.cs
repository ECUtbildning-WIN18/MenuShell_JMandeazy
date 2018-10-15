using MenuShellz.Domain;
using System.Collections.Generic;

namespace MenuShellz.View
{
    class RegisterUser
    {
        public void AddNewUser(string userName, string passWord, string role, List<User> users)
        {
            users.Add(new User(userName, passWord, role));
        }
    }     
        
}
