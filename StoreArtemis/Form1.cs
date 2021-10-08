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

			Prenda prenda = new Prenda();

			prendas.Add(prenda);
			

		}

        public ShopArtemis()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblTypePrenda_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void lblPrendasTotales_Click(object sender, EventArgs e)
        {

        }
    }
}
