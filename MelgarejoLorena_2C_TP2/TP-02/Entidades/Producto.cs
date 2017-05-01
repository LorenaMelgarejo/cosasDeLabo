using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades_2017;
using Entidades_2017_1;//agregue un using 

namespace Entidades_2017_1
{
    /// <summary>
    /// La clase Producto será abstracta, evitando que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Producto //public sealed class Producto lo cambie por abstract
    {
        public enum EMarca
        {
            Serenisima, Campagnola, Arcor, Ilolay, Sancor, Pepsico
        }
        EMarca _marca;
        string _codigoDeBarras;
        ConsoleColor _colorPrimarioEmpaque;

        public Producto (EMarca marca, string codigoDeBarras, ConsoleColor colorPrimarioEmpaque)// falto constructor
        {
            this._marca = marca;
            this._codigoDeBarras = codigoDeBarras;
            this._colorPrimarioEmpaque = colorPrimarioEmpaque;
        }

        /// <summary>
        /// ReadOnly: Retornará la cantidad de ruedas del vehículo
        /// </summary>
        public abstract short CantidadCalorias { get; set; } // falto public 

        /// <summary>
        /// Publica todos los datos del Producto.
        /// </summary>
        /// <returns></returns>
        public virtual string Mostrar()// falto public y cambie sealed x virtual
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("marca: " + this._marca);
            sb.AppendLine("codigo de barra: " + this._codigoDeBarras);
            sb.AppendLine("color: " + this._colorPrimarioEmpaque);

            return sb.ToString();
        }

         public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CODIGO DE BARRAS: " + p._codigoDeBarras);//sb.AppendLine("CODIGO DE BARRAS: {0}\r\n", p._codigoDeBarras);
            sb.AppendLine("MARCA          : " + p._marca.ToString());//sb.AppendLine("MARCA          : {0}\r\n", p._marca.ToString());
            sb.AppendLine("COLOR EMPAQUE  :  "+ p._colorPrimarioEmpaque.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();// falto es ToString
        }

        /// <summary>
        /// Dos productos son iguales si comparten el mismo código de barras
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto v1, Producto v2)
        {
            if (v1._codigoDeBarras == v2._codigoDeBarras)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Dos productos son distintos si su código de barras es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto v1, Producto v2)
        {
            return !(v1 == v2);
        }
    }
}
