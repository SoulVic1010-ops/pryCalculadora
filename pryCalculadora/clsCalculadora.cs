using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCalculadora
{
    internal class clsCalculadora
    {
        //Atributos de entrada
        private float numero1;
        private float numero2;
        //Atributo de salida
        private float Resultado;

        //Esta es la segunda opc 2
        //Uso de propiedades set y get
        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }


        //Esto puede darle solucion atraves del constructor (opc 1)
        //Usar el constructor
        //public clsCalculadora(float N1, float N2)
        //{
        //this.Numero1 = N1;
        //this.Numero2 = N2;
        //}
        //Funciones o métodos
        public float Sumar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }
        public float Restar()
        {
            Resultado = Numero1 - Numero2;
            return Resultado;
        }
        public float Multiplicar ()
        {
            Resultado = Numero1 * Numero2;
            return Resultado;
        }
        public float Dividir()
        {
            Resultado = Numero1 / Numero2;
            return Resultado;
        }
    }
}
