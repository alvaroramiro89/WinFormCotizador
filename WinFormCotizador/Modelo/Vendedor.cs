using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormCotizador.Modelo
{
    
    public class Vendedor
    {
        public string nombreVendedor;
        public float idVendedor;

      
        public int IdVendedor { get; set; }
        public string NombreVendedor { get; set; }

        
      
        public Vendedor(int idVendedor, string nombreVendedor)
        {
            IdVendedor = idVendedor;
            NombreVendedor = nombreVendedor;
        }
    }
}
