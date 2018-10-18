using MenuShellz.Domain;
using System.Collections.Generic;

namespace MenuShellz.Services
{
    interface IAuthenticationServices
    {
            User Authenticate(string userName, string passWord, List<User> _users);
    }
}
