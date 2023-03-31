using WinFormCotizador;
using WinFormCotizador.Modelo;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WinFormCotizador
{
    public partial class Form1 : Form
    {
        public Tienda tienda1 = new Tienda("Perkins Brothers. INC", "Av. Siempre Viva 123");
        public Vendedor vendedor1 = new Vendedor(3006, "Pepe Aldunate");
        private List<string> historialCotizaciones = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelNombreTienda.Text = tienda1.NombreTienda;
            labelDireccionTienda.Text = $"{tienda1.DireccionTienda}";
            labelNombreVendedor.Text = $"{vendedor1.NombreVendedor}";
            labelIdVendedor.Text = $"{vendedor1.IdVendedor}";
        }

        private void RadioButtonCamisa_CheckedChanged(object sender, EventArgs e)
        {
            // Si se seleccionó la opción de camisa, habilitar las checkbox de cuello mao y manga corta
            checkBoxCuelloMao.Enabled = true;
            checkBoxMangaCorta.Enabled = true;

            // Deshabilitar las checkbox de corte chupin y estandard
            checkBoxChupin.Enabled = false;
            checkBoxEstandard.Enabled = false;

        }

        private void RadioButtonPantalon_CheckedChanged(object sender, EventArgs e)
        {
            // Si se seleccionó la opción de pantalón, habilitar las checkbox de corte chupin y estandard
            checkBoxChupin.Enabled = true;
            checkBoxEstandard.Enabled = true;

            // Deshabilitar las checkbox de cuello mao y manga corta
            checkBoxCuelloMao.Enabled = false;
            checkBoxMangaCorta.Enabled = false;
        }

        public void buttonCalcular_Click(object sender, EventArgs e)
        {
            // Atributos
            decimal precioUnitario = decimal.Parse(textBoxPrecioUnitario.Text);
            int cantidad = int.Parse(textBoxCantidad.Text);

            // Crear objeto de prenda
            Prenda prenda;

            // Crear objeto de camisa o pantalon según corresponda
            if (radioButtonCamisa.Checked)
            {
                bool cuelloMao = checkBoxCuelloMao.Checked;
                bool mangaCorta = checkBoxMangaCorta.Checked;
                prenda = new Camisa(precioUnitario, cantidad, cuelloMao, mangaCorta);
            }
            else
            {
                bool corteChupin = checkBoxChupin.Checked;
                prenda = new Pantalon(precioUnitario, cantidad, corteChupin);
            }

            // Calcular precio final
            decimal descuento = 0;
            if (radioButtonStandard.Checked)
            {
                descuento = prenda.CalcularPrecioFinal() * 0.3m;
            }

            // Calcular precio final
            decimal precioFinal = prenda.CalcularPrecioFinal() - descuento;

            textBoxPrecioFinal.Text = $"{precioFinal:C2}";

            // Almacenar la cotización en el historial
            string cotizacion = $"Precio unitario: {precioUnitario:C2}, Cantidad: {cantidad}, Precio final: {precioFinal:C2}";
            historialCotizaciones.Add(cotizacion);

            // Limitar el historial a las últimas 5 cotizaciones
            if (historialCotizaciones.Count > 5)
            {
                historialCotizaciones.RemoveAt(0);
            }
        }

        private void linkLabelHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Crear un mensaje con el historial de cotizaciones
            string mensaje = "Últimas cotizaciones:\n\n";

            foreach (string cotizacion in historialCotizaciones)
            {
                mensaje += $"{cotizacion}\n";
            }

            // Mostrar el mensaje con las últimas cotizaciones en un MessageBox
            MessageBox.Show(mensaje, "Historial de cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void linkLabelHistorial_LinkClicked(object sender, EventArgs e)
        {
            // Crear un mensaje con el historial de cotizaciones
            string mensaje = "Últimas cotizaciones:\n\n";

            foreach (string cotizacion in historialCotizaciones)
            {
                mensaje += $"{cotizacion}\n";
            }

            // Mostrar el mensaje con las últimas cotizaciones en un MessageBox
            MessageBox.Show(mensaje, "Historial de cotizaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


