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
    public partial class FrmCaso4 : Form
    {
        string[] personasNombre = new string[5];
        int[] personasEdad = new int[5];

        public FrmCaso4()
        {
            InitializeComponent();
        }

        private void btnCargaDatos_Click(object sender, EventArgs e)
        {
            cargaPersonas();
        }

        private void btnMostarMayores_Click(object sender, EventArgs e)
        {
            mostrarMayoresEdad();
        }

        #region ABM
        private void cargaPersonas()
        {
            for (int i = 0; i < personasNombre.Length; i++)
            {
                personasNombre[i] = Interaction.InputBox("Ingrese nombre y apellido", "Carga de personas");
                personasEdad[i] = int.Parse(Interaction.InputBox("Ingrese la edad", "Carga edad"));
            }
        }

        #endregion

        #region muestra

        private void mostrarMayoresEdad()
        {
            int cont = 0;
            foreach (var persona in personasNombre)
            {
                if (personasEdad[cont] >= 18)
                    lstMayoresEdad.Items.Add(persona);
                cont++;
            }
        }

        #endregion
    }
}
