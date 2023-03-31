using System;

namespace WinFormCotizador.Modelo
{
    // Clase base que representa una prenda genérica
    public class Prenda
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }

        // Constructor con nombre, precio unitario y cantidad
        public Prenda(string nombre, decimal precioUnitario, int cantidad)
        {
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }

        // Constructor con precio unitario y cantidad
        public Prenda(decimal precioUnitario, int cantidad)
        {
            PrecioUnitario = precioUnitario;
            Cantidad = cantidad;
        }

        // Método virtual para calcular el precio final
        public virtual decimal CalcularPrecioFinal()
        {
            // Implementación básica del cálculo del precio final
            return PrecioUnitario * Cantidad;
        }
    }
}
