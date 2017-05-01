using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2017_1; // falto el using 

namespace Entidades_2017_1
{
    public class Snacks :Producto
    {
        public Snacks(EMarca marca, string patente, ConsoleColor color) //falto ordenar 
            : base(marca, patente, color)
        {
        }
        /// <summary>
        /// Los snacks tienen 104 calorías
        /// </summary>
        public override short CantidadCalorias
        {
            get
            {
                return 104;
            }
            set { CantidadCalorias = value; }
        }
        

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SNACKS");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("---------------------");
            sb.AppendLine("CALORIAS : "+ this.CantidadCalorias);
            //sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
