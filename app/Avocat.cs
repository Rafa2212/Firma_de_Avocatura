using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_de_avocatura
{
	class Avocat
	{
        private List<Client> clienti = new List<Client>();
        public string Nume
        {
            set; get;
        }
        public string Specializare
        {
            set; get;
        }
        public Avocat()
        {
            Console.Write("Numele si prenumele avocatului este: ");
            Nume = Console.ReadLine();
            Console.Write("Specializarea avocatului este: ");
            Specializare = Console.ReadLine();
        }
        public void AdaugareClient()
        {
            clienti.Add(new Client());
        }

        public Client CautareClient(string numeClient)
        {
            Client aux = clienti.Find(m => m.Nume == numeClient);
            return aux;
        }

        public void StergereClient(Client c)
        {
            clienti.Remove(c);
        }
        public override string ToString()
        {
            return Nume + " | " + Specializare;
        }
        
        public void AfisareAvocat()
        {
            Console.WriteLine(ToString());
            foreach (Client x in clienti)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}