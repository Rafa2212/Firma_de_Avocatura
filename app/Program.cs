using System;

namespace Firma_de_avocatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma f = new Firma();
            int optiune = 0;
            do
            {
                Console.WriteLine("1 - Adaugare avocat");
                Console.WriteLine("2 - Adaugare client la avocat");
                Console.WriteLine("3 - Afisare avocati");
                Console.WriteLine("4 - Afisare clienti");
                Console.WriteLine("5 - Stergere clienti");
                Console.WriteLine("0 - Exit");
                Console.Write("Alegeti: ");
                Console.WriteLine();
                optiune = Convert.ToInt32(Console.ReadLine());
                switch (optiune)
                {
                    case 1: f.AdaugareAvocat(); break;
                    case 2: f.AdaugareClientLaAvocat(); break;
                    case 3: f.AfisareAvocati(); break;
                    case 4: f.AfisareClienti(); break;
                    case 5: f.StergereClientLaAvocat(); break;
                }
            } while (optiune != 0);
        }
    }
}
