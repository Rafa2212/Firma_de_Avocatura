using System;
using System.Collections.Generic;
using System.Text;

namespace Firma_de_avocatura
{
	class Firma
	{
		private List<Avocat> avocati = new List<Avocat>();
		public void AdaugareAvocat()
        {
			avocati.Add(new Avocat());
		}
		public void AfisareAvocati()
        {
			foreach (var n in avocati)
			{
				Console.WriteLine(n);
			}
		}
		public void AdaugareClientLaAvocat()
		{
			string x;
			Console.Write("La care avocat adaugam?");
			x = Console.ReadLine();  //x este string nu e necesar convert
			Avocat i = avocati.Find(m => m.Nume == x); //cauta dupa nume
			i.AdaugareClient();
			//foreach (Avocati i in avocati)
			//{
   //             if (i.Nume== x)
   //                 i.AdaugareClient();
			//}
		}

		public void StergereClientLaAvocat()
		{
			string x;
			Console.Write("Numele si prenumele clientului care se sterge?");
			x = Console.ReadLine(); 
			
			foreach (Avocat i in avocati)
			{
				Client c = i.CautareClient(x);
				if(c!=null)
                {
					i.StergereClient(c);
                }
			}
		}
		public void AfisareClienti()
		{
			string x;
			Console.Write("De la ce avocat afisam?");
			x = Console.ReadLine();
			Avocat i = avocati.Find(m => m.Nume == x); //cauta dupa nume
			i.AfisareAvocat();
			//foreach (Avocat i in avocati)													   
			//{													   
			//	if (Equals(Convert.ToString(i), x))													  
			//		Console.WriteLine(Convert.ToInt32(i));													   
			//}
		}
	}
}