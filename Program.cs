namespace JatekBolt
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Felhasznalo adam = new Felhasznalo("Ádám", 20000);
			jatekBolt.FelhasznaloHozzaadas(adam);
			Jatek witcher = jatekBolt.KeresJatek("The Witcher 3");
			adam.Vasarlas(witcher);
		}

	}
}
