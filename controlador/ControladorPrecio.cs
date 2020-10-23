using Parcial2.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2.controlador
{
    class ControladorPrecio
    {

        public double calcularPrecioCamisas(double precioBase, int cantidad, String calidad, bool esMangaCorta)
        {
            Camisa camisa = new Camisa();
            camisa.precioBase = precioBase;
            camisa.cantidad = cantidad;
            camisa.calidad = calidad;
            camisa.esMangaCorta = esMangaCorta;
            return camisa.calcularPrecio() * camisa.cantidad;
        }

        public double calcularPrecioPantalones(double precioBase, int cantidad, String calidad, bool esBermuda)
        {
            Pantalon pantalon = new Pantalon();
            pantalon.precioBase = precioBase;
            pantalon.cantidad = cantidad;
            pantalon.calidad = calidad;
            pantalon.esBermuda = esBermuda;
            return pantalon.calcularPrecio() * pantalon.cantidad;
        }

    }
}
