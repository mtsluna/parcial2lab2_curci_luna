using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.modelo
{
    class Camisa: Prenda
    {
        public Camisa(): base()
        {

        }

        public bool esMangaCorta { get; internal set; }

        public override double calcularPrecio()
        {
            double precioUnitario = this.precioBase;
            precioUnitario -= ((this.esMangaCorta) ? this.precioBase * 10 / 100 : 0);
            precioUnitario += this.calcularCalidad();
            return precioUnitario;
        }
    }
}
