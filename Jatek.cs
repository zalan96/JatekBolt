using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JatekBolt
{
	internal class Jatek
	{
		public string kategoria { get; private set; }
		public string cim { get; private set; }
		public int ar { get; private set; }

		public Jatek(string kategoria, string cim, int ar)
		{
			this.kategoria = kategoria;
			this.cim = cim;
			this.ar = ar;
		}
	}
}
