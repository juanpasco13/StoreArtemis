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

			// Validar numeros

			if (!int.TryParse(txtTalla.Text, out prenda.Talla))
			{
				MessageBox.Show($"El valor {txtTalla.Text} no es un numero.");
				return;
			}

			if (!double.TryParse(txtPrecio.Text, out prenda.Precio))
			{
				MessageBox.Show($"El valor {txtTalla.Text} no es un numero.");
				return;
			}

			// Obtener datos de la vista
			prenda.TipoPrenda = TipoPrendaBox.Items[TipoPrendaBox.SelectedIndex].ToString();
			prenda.Color = ColorBox.Items[ColorBox.SelectedIndex].ToString();
			prenda.Marca = MarcaBox.Items[MarcaBox.SelectedIndex].ToString();

			prendas.Add(prenda);
			actualizarCantidadDePrendas();
			limpiarDatos();
		}

		private void limpiarDatos()
        {
			TipoPrendaBox.SelectedIndex = -1;
			ColorBox.SelectedIndex = -1;
			MarcaBox.SelectedIndex = -1;
			txtTalla.Text = "";
			txtPrecio.Text = "";
		}

		// Aumentar la cantidad y actualizarla en la vista
		private void actualizarCantidadDePrendas()
		{
			CantidadDePrendas++;
			lblPrendasTotales.Text = $"Prendas totales: {CantidadDePrendas}";
		}
    }
}
