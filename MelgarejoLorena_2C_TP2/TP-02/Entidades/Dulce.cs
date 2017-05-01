using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2017_1;

namespace Entidades_2017_1
{
    public class Dulce : Producto // agrego la clase de donde hereda
    {
        public Dulce (EMarca marca, string codigoDeBarras, ConsoleColor colorPrimarioEmpaque )
            : base(marca, codigoDeBarras, colorPrimarioEmpaque)
        {
        }
        /// <summary>
        /// Los dulces tienen 80 calorías
        /// </summary>
        /// public override short CantidadCalorias { get; set; }
        public override short CantidadCalorias
        {
            get
            {
                return 80;
            }

            set { CantidadCalorias = value; }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("DULCE");
            sb.AppendLine(base.Mostrar());
            //sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
           // sb.AppendLine("");
            sb.AppendLine("---------------------");
            sb.AppendLine("");
            sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
            sb.AppendLine("---------------------");

            return sb.ToString();// falto el ToString
        }
    }
}
