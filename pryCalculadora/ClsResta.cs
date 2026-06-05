using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class ClsResta : clsCalculadora
    {
		public float Restar()
		{
			Resultado = Numero1 - Numero2;
			return Resultado;
		}
	}
}
