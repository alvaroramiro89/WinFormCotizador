namespace WinFormCotizador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.checkBoxEstandard = new System.Windows.Forms.CheckBox();
            this.radioButtonCamisa = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalon = new System.Windows.Forms.RadioButton();
            this.textBoxPrecioUnitario = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.textBoxPrecioFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNombreTienda = new System.Windows.Forms.Label();
            this.labelDireccionTienda = new System.Windows.Forms.Label();
            this.labelNombreVendedor = new System.Windows.Forms.Label();
            this.labelIdVendedor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButtonStandard = new System.Windows.Forms.RadioButton();
            this.linkLabelHistorial = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(489, 109);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(135, 19);
            this.checkBoxCuelloMao.TabIndex = 0;
            this.checkBoxCuelloMao.Text = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(630, 107);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(123, 19);
            this.checkBoxMangaCorta.TabIndex = 1;
            this.checkBoxMangaCorta.Text = "checkMangaCorta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(489, 151);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(96, 19);
            this.checkBoxChupin.TabIndex = 2;
            this.checkBoxChupin.Text = "checkChupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstandard
            // 
            this.checkBoxEstandard.AutoSize = true;
            this.checkBoxEstandard.Location = new System.Drawing.Point(630, 151);
            this.checkBoxEstandard.Name = "checkBoxEstandard";
            this.checkBoxEstandard.Size = new System.Drawing.Size(97, 19);
            this.checkBoxEstandard.TabIndex = 3;
            this.checkBoxEstandard.Text = "checkNormal";
            this.checkBoxEstandard.UseVisualStyleBackColor = true;
            // 
            // radioButtonCamisa
            // 
            this.radioButtonCamisa.AutoSize = true;
            this.radioButtonCamisa.Location = new System.Drawing.Point(340, 106);
            this.radioButtonCamisa.Name = "radioButtonCamisa";
            this.radioButtonCamisa.Size = new System.Drawing.Size(64, 19);
            this.radioButtonCamisa.TabIndex = 4;
            this.radioButtonCamisa.TabStop = true;
            this.radioButtonCamisa.Text = "Camisa";
            this.radioButtonCamisa.UseVisualStyleBackColor = true;
            this.radioButtonCamisa.CheckedChanged += new System.EventHandler(this.RadioButtonCamisa_CheckedChanged);
            // 
            // radioButtonPantalon
            // 
            this.radioButtonPantalon.AutoSize = true;
            this.radioButtonPantalon.Location = new System.Drawing.Point(340, 150);
            this.radioButtonPantalon.Name = "radioButtonPantalon";
            this.radioButtonPantalon.Size = new System.Drawing.Size(72, 19);
            this.radioButtonPantalon.TabIndex = 5;
            this.radioButtonPantalon.TabStop = true;
            this.radioButtonPantalon.Text = "Pantalon";
            this.radioButtonPantalon.UseVisualStyleBackColor = true;
            this.radioButtonPantalon.CheckedChanged += new System.EventHandler(this.RadioButtonPantalon_CheckedChanged);
            // 
            // textBoxPrecioUnitario
            // 
            this.textBoxPrecioUnitario.Location = new System.Drawing.Point(340, 291);
            this.textBoxPrecioUnitario.Name = "textBoxPrecioUnitario";
            this.textBoxPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.textBoxPrecioUnitario.TabIndex = 6;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(554, 291);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 23);
            this.textBoxCantidad.TabIndex = 7;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(97, 357);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(164, 59);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular Cotización";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // textBoxPrecioFinal
            // 
            this.textBoxPrecioFinal.Location = new System.Drawing.Point(340, 376);
            this.textBoxPrecioFinal.Name = "textBoxPrecioFinal";
            this.textBoxPrecioFinal.Size = new System.Drawing.Size(191, 23);
            this.textBoxPrecioFinal.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "$/Unidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(554, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Cotización";
            // 
            // labelNombreTienda
            // 
            this.labelNombreTienda.AutoSize = true;
            this.labelNombreTienda.Location = new System.Drawing.Point(31, 9);
            this.labelNombreTienda.Name = "labelNombreTienda";
            this.labelNombreTienda.Size = new System.Drawing.Size(89, 15);
            this.labelNombreTienda.TabIndex = 13;
            this.labelNombreTienda.Text = "Nombre Tienda";
            // 
            // labelDireccionTienda
            // 
            this.labelDireccionTienda.AutoSize = true;
            this.labelDireccionTienda.Location = new System.Drawing.Point(220, 9);
            this.labelDireccionTienda.Name = "labelDireccionTienda";
            this.labelDireccionTienda.Size = new System.Drawing.Size(95, 15);
            this.labelDireccionTienda.TabIndex = 14;
            this.labelDireccionTienda.Text = "Dirección Tienda";
            // 
            // labelNombreVendedor
            // 
            this.labelNombreVendedor.AutoSize = true;
            this.labelNombreVendedor.Location = new System.Drawing.Point(31, 44);
            this.labelNombreVendedor.Name = "labelNombreVendedor";
            this.labelNombreVendedor.Size = new System.Drawing.Size(104, 15);
            this.labelNombreVendedor.TabIndex = 15;
            this.labelNombreVendedor.Text = "Nombre Vendedor";
            // 
            // labelIdVendedor
            // 
            this.labelIdVendedor.AutoSize = true;
            this.labelIdVendedor.Location = new System.Drawing.Point(220, 44);
            this.labelIdVendedor.Name = "labelIdVendedor";
            this.labelIdVendedor.Size = new System.Drawing.Size(71, 15);
            this.labelIdVendedor.TabIndex = 16;
            this.labelIdVendedor.Text = "ID Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButtonStandard);
            this.groupBox1.Location = new System.Drawing.Point(31, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calidad de prenda";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(26, 58);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Premium";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButtonStandard
            // 
            this.radioButtonStandard.AutoSize = true;
            this.radioButtonStandard.Location = new System.Drawing.Point(26, 33);
            this.radioButtonStandard.Name = "radioButtonStandard";
            this.radioButtonStandard.Size = new System.Drawing.Size(72, 19);
            this.radioButtonStandard.TabIndex = 0;
            this.radioButtonStandard.TabStop = true;
            this.radioButtonStandard.Text = "Standard";
            this.radioButtonStandard.UseVisualStyleBackColor = true;
            // 
            // linkLabelHistorial
            // 
            this.linkLabelHistorial.AutoSize = true;
            this.linkLabelHistorial.Location = new System.Drawing.Point(567, 56);
            this.linkLabelHistorial.Name = "linkLabelHistorial";
            this.linkLabelHistorial.Size = new System.Drawing.Size(121, 15);
            this.linkLabelHistorial.TabIndex = 18;
            this.linkLabelHistorial.TabStop = true;
            this.linkLabelHistorial.Text = "Historial Cotizaciones";
            this.linkLabelHistorial.Click += new System.EventHandler(this.linkLabelHistorial_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabelHistorial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelIdVendedor);
            this.Controls.Add(this.labelNombreVendedor);
            this.Controls.Add(this.labelDireccionTienda);
            this.Controls.Add(this.labelNombreTienda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrecioFinal);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.textBoxPrecioUnitario);
            this.Controls.Add(this.radioButtonPantalon);
            this.Controls.Add(this.radioButtonCamisa);
            this.Controls.Add(this.checkBoxEstandard);
            this.Controls.Add(this.checkBoxChupin);
            this.Controls.Add(this.checkBoxMangaCorta);
            this.Controls.Add(this.checkBoxCuelloMao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox checkBoxCuelloMao;
        private CheckBox checkBoxMangaCorta;
        private CheckBox checkBoxChupin;
        private CheckBox checkBoxEstandard;
        private RadioButton radioButtonCamisa;
        private RadioButton radioButtonPantalon;
        private TextBox textBoxPrecioUnitario;
        private TextBox textBoxCantidad;
        private Button buttonCalcular;
        private TextBox textBoxPrecioFinal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelNombreTienda;
        private Label labelDireccionTienda;
        private Label labelNombreVendedor;
        public Label labelIdVendedor;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButtonStandard;
        private LinkLabelLinkClickedEventHandler linkLabel1_LinkClicked;
        private LinkLabel linkLabelHistorial;
    }
}