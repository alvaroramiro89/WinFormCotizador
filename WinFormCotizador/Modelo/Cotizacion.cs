using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCotizador.Modelo
{
    public class Cotizacion
    {
        List<Cotizacion> historialCotizaciones = new List<Cotizacion>();
        public string prenda;
        public string precioFinal;
        public Prenda Prenda { get; set; }
        public decimal PrecioFinal { get; set; }

        public Cotizacion(Prenda prenda, decimal precioFinal)
        {
            Prenda = prenda;
            PrecioFinal = precioFinal;
        }
    }

}
