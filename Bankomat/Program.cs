using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Bankomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Utente> accounts = new List<Utente>();
            Conto cont = new Conto(1000);

            
            accounts.Add(new Utente("abc", "1234"));

            
            accounts.Add(new Utente("abcd", "12345"));

            
            accounts.Add(new Utente("abcde", "123456"));
            Menù.SchermataIniziale();
            do
            {
                Console.WriteLine("Username: ");
                var username = Console.ReadLine();
                Console.WriteLine("Password: ");
                var password = Console.ReadLine();
                foreach(var UtenteCorrente in accounts)
                {
                    if(username == UtenteCorrente.Username && password == UtenteCorrente.Password)
                    {
                        cont.MenuConto();
                    }
                    else
                    {
                        Console.WriteLine("errore");
                      
                    }
                }


            }while(true);

            

        }
    }
}
