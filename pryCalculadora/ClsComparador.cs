using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class ClsComparador : clsCalculadora
    {

		public string CompararNumero()
		{
			if (Numero1 > 5)
				return "El número es mayor que 5";

			if (Numero1 < 5)
				return "El número es menor que 5";

			return "El número es igual a 5";
		}
	}
}
