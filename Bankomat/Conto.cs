using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Conto
    {
        public double Saldo { get; set; }
        public double denaro { get; set; }
        public Conto(double saldo)
        {
            Saldo = saldo;
        }


    public void Prelievo(double denaro)
    {
            Console.WriteLine("quanto vuoi prelevare");
            denaro = Double.Parse(Console.ReadLine());
            if (Saldo > denaro )
            {
   
                Saldo -= denaro;
            }
            else
            {
                Console.WriteLine("errore");
            }
    }

    public void Versamento(double denaro)
    {
            Console.WriteLine("quanto vuoi versare");
            denaro = Double.Parse(Console.ReadLine());
            Saldo += denaro;
    }


    public void GeneraSaldo()
    {
            Console.WriteLine($"Il tuo saldo è di {Saldo}");
            //DateTime thisDay = DateTime.Today;
    }

        public void MenuConto()
        {
            Console.WriteLine("- - - - - - - - - - - - - - ");
            Console.WriteLine("Per prelevare premere : 1");
            Console.WriteLine("Per versare premere : 2");
            Console.WriteLine("Per il saldo premere : 3");
            Console.WriteLine("Per uscire: u");
            Console.WriteLine("- - - - - - - - - - - - - - ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Prelievo(denaro); 
                    MenuConto();
                    break;
                case 2:

                    Versamento(denaro); 
                    MenuConto();
                    break;
                case 3:

                    GeneraSaldo();
                    MenuConto();
                    break;
                case 4:
                    Console.WriteLine("uscita");
                    return;
                default:
                    Console.WriteLine("errore");
                    return;
            }
        }

    }
}
   

