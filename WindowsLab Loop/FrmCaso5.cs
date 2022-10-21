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
    public partial class FrmCaso5 : Form
    {
        string[] provincias = new string[4];
        double[] temperaturaMensual = new double[12];
        double[] mediasTrimestrales = new double[4]; 

        public FrmCaso5()
        {
            InitializeComponent();
        }

        private void btnIngresarProvincias_Click(object sender, EventArgs e)
        {
            cargarProvincias();
        }

        private void btnTemperaturasMedias_Click(object sender, EventArgs e)
        {
            cargarTemperaturasMedias();  
        }

        private void btnCalcularMediaTrimestral_Click(object sender, EventArgs e)
        {
            calcularMediasTrimestrales();
        }

        private void btnMostrarMayorProvinciaTemp_Click(object sender, EventArgs e)
        {
            mostrarProvinciaMayorMedia();
        }

        private void btnMostrarMesesxTemp_Click(object sender, EventArgs e)
        {
            mostrarProvinciasConTemperaturas();
        }

        private void btnMuestraMediasTrim_Click(object sender, EventArgs e)
        {
            mostrarProvinciasConMedias();
        }

        #region ABM

        private void cargarProvincias()
        {
            for (int i = 0; i < provincias.Length; i++)
            {
                provincias[i] = Interaction.InputBox("Ingrese el nombre de la Provincia");
            }
        }

        private void cargarTemperaturasMedias()
        {
            for (int i = 0; i < temperaturaMensual.Length; i++)
            {
                if (i<3)
                {
                    temperaturaMensual[i] = double.Parse(Interaction.InputBox("Ingresar temperatura mensual", provincias[0]));
                }
                else if (i < 6)
                {
                    temperaturaMensual[i] = double.Parse(Interaction.InputBox("Ingresar temperatura mensual", provincias[1]));
                }
                else if (i < 9)
                {
                    temperaturaMensual[i] = double.Parse(Interaction.InputBox("Ingresar temperatura mensual", provincias[2]));
                }
                else
                {
                    temperaturaMensual[i] = double.Parse(Interaction.InputBox("Ingresar temperatura mensual", provincias[3]));
                }

            }
        }

        #endregion

        #region calculos

        private void calcularMediasTrimestrales()
        {
            for (int i = 0; i < temperaturaMensual.Length; i++)
            {
                if (i < 3)
                {
                    mediasTrimestrales[0] = mediasTrimestrales[0] + temperaturaMensual[i];
                }
                else if (i < 6)
                {
                    mediasTrimestrales[1] = mediasTrimestrales[1] + temperaturaMensual[i];
                }
                else if (i < 9)
                {
                    mediasTrimestrales[2] = mediasTrimestrales[2] + temperaturaMensual[i];
                }
                else
                {
                    mediasTrimestrales[3] = mediasTrimestrales[3] + temperaturaMensual[i];
                }
            }
            for (int i = 0; i < mediasTrimestrales.Length; i++)
            {
                mediasTrimestrales[i] /= 3;
            }
        }

        private int encontrarMayorMedia()
        {
            double mayorMedia = 0;
            int resultado = 0;
            int cont = 0;

            foreach (var mediaTrim in mediasTrimestrales)
            {
                if (mediaTrim > mayorMedia)
                {
                    mayorMedia = mediaTrim;
                    resultado = cont;
                }
                cont++;
            }
            return resultado;
        }


        #endregion

        #region metodos mostrar

        private void mostrarProvinciasConMedias()
        {
            int cont = 0;
            foreach (var provincia in provincias)
            {
                lstMediasTrimestrales.Items.Add(provincia);
                lstMediasTrimestrales.Items.Add(mediasTrimestrales[cont]);
                lstMediasTrimestrales.Items.Add("\n");
                cont++;
            }
        }

        private void mostrarProvinciasConTemperaturas()
        {
            for (int i = 0; i < 4; i++)
            {
                if(i == 0)
                {
                    lstMesesxTemp.Items.Add(provincias[i]);
                    for (int cont = 0; cont < 3; cont++)
                    {
                        lstMesesxTemp.Items.Add(temperaturaMensual[cont]);
                    }
                }
                else if (i == 1)
                {
                    lstMesesxTemp.Items.Add("\n");
                    lstMesesxTemp.Items.Add(provincias[i]);
                    for (int cont = 3; cont < 6; cont++)
                    {
                        lstMesesxTemp.Items.Add(temperaturaMensual[cont]);
                    }
                }
                else if (i == 2)
                {
                    lstMesesxTemp.Items.Add("\n");
                    lstMesesxTemp.Items.Add(provincias[i]);
                    for (int cont = 6; cont < 9; cont++)
                    {
                        lstMesesxTemp.Items.Add(temperaturaMensual[cont]);
                    }
                }
                else
                {
                    lstMesesxTemp.Items.Add("\n");
                    lstMesesxTemp.Items.Add(provincias[i]);
                    for (int cont = 9; cont < 12; cont++)
                    {
                        lstMesesxTemp.Items.Add(temperaturaMensual[cont]);
                    }
                }
            }
        }

        private void mostrarProvinciaMayorMedia()
        {
            int resultado = encontrarMayorMedia();
            MessageBox.Show("La provincia con mayor promedio de temperatura trimestral es " + provincias[resultado] + " y la temperatura es " + mediasTrimestrales[resultado]);
        }

        #endregion


    }
}
