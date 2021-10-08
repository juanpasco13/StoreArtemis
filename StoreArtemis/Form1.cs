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
			Prenda prenda = new Prenda();

			prenda.TipoPrenda = txtTipoPrenda.Text;
			prenda.Color = txtColor.Text;
			prenda.Marca = txtMarca.Text;
			prenda.Talla = txtTalla.Text;
			prenda.Precio = txtPrecio.Text;

			prendas.Add(prenda);
			StoreArtemis.actualizarCantidadDePrendas();
        }

		// Aumentar la cantidad y actualizarla en la vista
		private static void actualizarCantidadDePrendas()
		{
			CantidadDePrendas++;
			lblPrendasTotales.Text = $"Prendas totales: {CantidadDePrendas}";
		}
    }
}
