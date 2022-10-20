using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsLab_Loop
{
    public partial class FrmCaso2 : Form
    {
        double[] precios = new double[8];

        public FrmCaso2()
        {
            InitializeComponent();
        }

        private void btnIngresoPrecios_Click(object sender, EventArgs e)
        {
            cargaPrecios();
            mostrarPrecios();
            mostrarSumaPrecios();
        }

        private void cargaPrecios()
        {
            for (int i = 0; i < precios.Length; i++)
            {
                precios[i] = double.Parse(Interaction.InputBox("Ingrese un precio"));
            }
        }

        private void mostrarPrecios()
        {

            lstPrecios.Items.Add("Listado precios");
            foreach (var precio in precios)
            {
                lstPrecios.Items.Add(precio);
            }
        }
        private void mostrarSumaPrecios()
        {
            double suma = 0;
            lstSumaPrecios.Items.Add("Suma total");
            foreach (var precio in precios)
            {
                suma +=precio;
            }
            lstSumaPrecios.Items.Add(suma);
        }
    }
}
