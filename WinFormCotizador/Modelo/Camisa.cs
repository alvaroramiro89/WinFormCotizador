namespace WinFormCotizador.Modelo
{


    public class Camisa : Prenda
    {
        public bool CuelloMao { get; set; }
        public bool MangaCorta { get; set; }
        
        public Camisa(decimal precioUnitario, int cantidad, bool cuelloMao, bool mangaCorta)
            : base(precioUnitario, cantidad)
        {
            CuelloMao = cuelloMao;
            MangaCorta = mangaCorta;
        }
        public override decimal CalcularPrecioFinal()
        {
            decimal precioFinal = base.CalcularPrecioFinal();

            // Aplicar incremento/descuento según las opciones seleccionadas
            if (CuelloMao)
            {
                precioFinal *= 1.1m; // Incrementar en un 10%
            }
            if (MangaCorta)
            {
                precioFinal *= 0.8m; // Aplicar un 20% de descuento
            }

            return precioFinal;
            

        }


    }
}
