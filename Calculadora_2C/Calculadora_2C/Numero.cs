using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_2C
{
    public class Numero
    {
        private double numero;

        public double getNumero()
        {


            return this.numero;
        }

        public Numero()
        {
            this.numero = 0;
        }

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string numero)
        {
            this.numero = (validarNumero(numero));

        }

        private void setNumero(string numero)
        {

            this.numero = Numero.validarNumero(numero);
        }


        private static double validarNumero(string numeroString)
        {
            double num;
            bool n = double.TryParse(numeroString, out num);

            if (n)
            {
                Console.WriteLine("numero double");
                return double.Parse(numeroString);
            }
            else
            {
                Console.WriteLine("no es un numero de tipo double");
                return 0;
            }




        }
    }
}
