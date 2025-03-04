using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace JatekBolt
{
	internal class Jatekbolt
	{
		public List<Jatek> Jatekok { get; private set; }
		public List<Felhasznalo> Felhasznalok { get; private set; }
		
		public Jatekbolt()
		{
			Jatekok = new List<Jatek>();
			Felhasznalok = new List<Felhasznalo>();
		}

		public void JatekHozzaadas(Jatek jatek)
		{
			Jatekok.Add(jatek);
            Console.WriteLine("Játék sikeresen hozzáadva!");
        }

		public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
		{
			Felhasznalok.Add(felhasznalo);
			Console.WriteLine("Felhasználó sikeresen hozzáadva!");
		}

		public Jatek KeresJatek(string cim)
		{
			foreach (var jatek in Jatekok)
			{
				if (jatek.cim == cim)
				{
					return jatek;
				}
			}
			return null;
		}

		public Felhasznalo KeresFelhasznalo(string nev)
		{
			foreach (var felhasznalo in Felhasznalok)
			{
				if (felhasznalo.Nev == nev)
				{
					return felhasznalo;
				}
			}
			return null;
		}
	}

	
}
