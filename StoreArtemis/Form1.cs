using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreArtemis
{
    public partial class ShopArtemis : Form
    {
		// Atributos estaticos
		private static List<Prenda> prendas;
		private static int CantidadDePrendas { get; set; }

		// Constructores

		// Constructor estatico
		static ShopArtemis()
		{
			prendas = new List<Prenda>();
			CantidadDePrendas = 0;
		}

        public ShopArtemis()
        {
            InitializeComponent();
        }

		// Easter Egg
        private void pictureBox1_Click(object sender, EventArgs e)
        {
			MessageBox.Show("Te ganaste un bitcoin");
        }

		// Agregar a lista
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
			{
				Prenda prenda = new Prenda();

				prenda.TipoPrenda = txtTipoPrenda.Text;
				prenda.Color = txtColor.Text;
				prenda.Marca = txtMarca.Text;
				prenda.Talla = int.Parse(txtTalla.Text);
				prenda.Precio = double.Parse(txtPrecio.Text);
				prendas.Add(prenda);
				actualizarCantidadDePrendas();
			} catch
			{
				MessageBox.Show("Dato invalido");
			}
        }

		// Aumentar la cantidad y actualizarla en la vista
		private void actualizarCantidadDePrendas()
		{
			CantidadDePrendas++;
			lblPrendasTotales.Text = $"Prendas totales: {CantidadDePrendas}";
		}

        private void ShopArtemis_Load(object sender, EventArgs e)
        {

        }

        private void lblPrendasTotales_Click(object sender, EventArgs e)
        {

        }
    }
}
