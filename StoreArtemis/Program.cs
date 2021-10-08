using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreArtemis
{
    static class Program
    {
        // Taller 2
		// Por: Juan David Gaviria Correa, Juan Pablo Garcia
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ShopArtemis());
        }
    }
}
