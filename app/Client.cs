using System;

namespace Firma_de_avocatura
{
    class Client
    {
        public string Nume
        {
            set; get;
        }
        public string Caz
        {
            set;get;
        }
        public Client()
        {
            Console.Write("Numele si prenumele clientului este: ");
            Nume = Console.ReadLine();
            Console.Write("Cazul clientului este de: ");
            Caz = Console.ReadLine();
        }
        public override string ToString()
        {
            return Nume + " | " +  Caz;
        }
    }
}