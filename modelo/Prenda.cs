using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.modelo
{
    abstract class Prenda
    {
        public Prenda()
        {

        }

        public int cantidad { get; internal set; }
        public String calidad { get; internal set; }
        public double precioBase { get; internal set; }

        public abstract double calcularPrecio();

        public double calcularCalidad()
        {
            double precioCalidad = this.precioBase;
            precioCalidad = (this.calidad.Equals("Standard") ? 0 : this.precioBase * 30 / 100);
            return precioCalidad;
        }

    }
}
