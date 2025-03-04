using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekBolt
{
	internal class Felhasznalo
	{
		public string Nev { get; private set; }
		public int Egyenleg { get; private set; }
		public List<Jatek> Konyvtar { get; private set; }


		public Felhasznalo(string Nev, int Egyenleg)
		{
			this.Nev = Nev;
			this.Egyenleg = Egyenleg;
			Konyvtar = new List<Jatek>();
		}

		public bool Vasarlas(Jatek jatek)
		{
			if (jatek == null)
			{
				Console.WriteLine("A játék nem található.");
				return false;
			}

			if (!Konyvtar.Contains(jatek) || Egyenleg > jatek.ar)
			{
				Konyvtar.Add(jatek);
				Console.WriteLine($"{jatek} sikeresen megvásárolva!");
				return true;
			}
			else
			{
				Console.WriteLine("A játék nem található.");
				return false;
			}
		}


		public void KonyvtarMegtekintes()
		{
            Console.WriteLine("A játkok listája a könyvtárban:");
            foreach (var jatek in Konyvtar)
			{
				Console.WriteLine(jatek.cim);
			}
		}

		public void Feltoltes(int osszeg)
		{
			Egyenleg += osszeg;
			Console.WriteLine($"Az egyenleg feltöltve: +{osszeg}Ft");
		}
	}
}
