using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public abstract class Lector
    {
        protected double precioVenta;
        protected double costoFabrica;
        protected string nombreProducto;

        public Lector(string letra)
        {
            letra = letra;
        }

        public abstract string imprimirDatos();
    }


    public class Teclado : Lector
    {
        public Teclado(string letra)
            : base(letra)
        {

        }

        public override string imprimirDatos()
        {
            return "print";
        }
    }
}
