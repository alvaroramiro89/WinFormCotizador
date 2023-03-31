namespace WinFormCotizador.Modelo
{
    public class Pantalon : Prenda
    {
        public bool Chupin { get; set; }

        public Pantalon(decimal precioUnitario, int cantidad, bool chupin)
            : base(precioUnitario, cantidad)
        {
            Chupin = chupin;
        }

        public override decimal CalcularPrecioFinal()
        {
            // Calcular precio final base
            decimal precioFinal = base.CalcularPrecioFinal();

            // Aplicar descuento si es corte chupin
            if (Chupin)
            {
                precioFinal *= 0.9m; // 10% de descuento
            }

            return precioFinal;
        }
    }

}
