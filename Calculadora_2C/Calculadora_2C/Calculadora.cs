using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_2C
{
     class Calculadora
    {
        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double rta = 0;
            switch (operador)
            {
                case "+":
                    {
                        rta = numero1.getNumero() + numero2.getNumero();

                        break;
                    }

                case "-":
                    {
                        rta = numero1.getNumero() - numero2.getNumero();
                        break;
                    }

                case "*":
                    {
                        rta = numero1.getNumero() * numero2.getNumero();
                        break;
                    }
                case "/":
                    {

                        if (numero2.getNumero() == 0)
                        {
                            rta = 0;
                            break;
                        }
                        else
                        {
                            rta = numero1.getNumero() / numero2.getNumero();
                            break;
                        }
                    }//case /
            }

                    return rta;
            }

            public string validarOperador(string operador)
            {
            while (operador == "+" && operador == "-" && operador == "*" && operador == "/")
            {
                return operador;
            }
            return "+";
            }
        }


        
     }  
        
                 
  
    

