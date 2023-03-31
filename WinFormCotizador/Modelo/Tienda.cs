using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCotizador.Modelo
{
  
    

    public class Tienda
    {
        public string nombreTienda;
        public string direccionTienda;
        public string NombreTienda { get; set; }
        public string DireccionTienda { get; set; }
        
        public Tienda(string nombreTienda, string direccionTienda)
        {
            NombreTienda = nombreTienda;
            DireccionTienda = direccionTienda;
        }
        

    }

    
}
