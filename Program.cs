namespace JatekBolt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Jatekbolt jatekBolt = new Jatekbolt();
			Felhasznalo adam = new Felhasznalo("Ádám", 20000);
			jatekBolt.FelhasznaloHozzaadas(adam);
			Jatek witcher = jatekBolt.KeresJatek("The Witcher 3");
			adam.Vasarlas(witcher);
			adam.Feltoltes(10000);
			Jatek cyberpunk = jatekBolt.KeresJatek("Cyberpunk 2077");
			adam.Vasarlas(cyberpunk);
		}

	}
}
