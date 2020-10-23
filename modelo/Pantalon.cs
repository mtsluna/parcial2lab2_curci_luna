using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.modelo
{
    class Pantalon: Prenda
    {
        public Pantalon(): base()
        {

        }

        public bool esBermuda { get; internal set; }

        public override double calcularPrecio()
        {
            double precioUnitario = this.precioBase;
            precioUnitario -= ((this.esBermuda) ? this.precioBase * 20 / 100 : 0);
            precioUnitario += this.calcularCalidad();
            return precioUnitario;
        }
    }
}
