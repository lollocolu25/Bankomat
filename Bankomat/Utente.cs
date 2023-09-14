using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    internal class Utente
    {
            public string Username { get; }
            public string Password { get; }
           

            public Utente(string username, string password)
            {
                Username = username;
                Password = password;
            } 
    }
}
