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
    public partial class FrmCaso3 : Form
    {
        private string[] operarios = new string[4];
        private double[] sueldos = new double[12];
        private double[] acumuladoSueldos = new double[4];


        public FrmCaso3()
        {
            InitializeComponent();
        }

        private void FrmCaso3_Load(object sender, EventArgs e)
        {

        }

        private void btnCargaOperarios_Click(object sender, EventArgs e)
        {
            cargaOperarios();
        }

        private void btnMuestraOperarios_Click(object sender, EventArgs e)
        {
            muestraOperarios();
        }

        private void btnMuestraTotal_Click(object sender, EventArgs e)
        {
            cargaAcumuladoSueldos();
            muestraTotalxOperario();
        }

        private void btnCargaSueldos_Click(object sender, EventArgs e)
        {
            cargaSueldos();
        }

        private void btnMejorPago_Click(object sender, EventArgs e)
        {
            muestraOperarioMejorPago();
        }

        #region ABM
        private void cargaOperarios()
        {
            for (int i = 0; i < operarios.Length; i++)
            {
                operarios[i] = Interaction.InputBox("Ingrese nombre y apellido del operario", "Carga operarios");
            }
        }

        private void cargaSueldos()
        {
            int cont = 0;
            int operario = 0;
            while (cont < 12)
            {
                for (int i = 0; i < 3; i++)
                {
                    sueldos[cont] = int.Parse(Interaction.InputBox("Ingrese sueldo de " + operarios[operario]));
                    cont++;
                }
                operario++;
            }
        }

        private void cargaAcumuladoSueldos()
        {
            int cont = 0;
            int i = 0;
            double sumaSueldos = 0;
            foreach (var sueldo in sueldos)
            {
                sumaSueldos += sueldo;
                if (cont == 2)
                {
                    acumuladoSueldos[i] = sumaSueldos;
                    i++;
                    cont = 0;
                    sumaSueldos = 0;
                }
                else
                    cont++;
            }
        }
        #endregion

        #region muestra
        private void muestraOperarios()
        {
            foreach (var operario in operarios)
            {
                listOperarios.Items.Add(operario);
            }
        }

        private void muestraTotalxOperario()
        {

            int cont = 0;
            foreach (var operario in operarios)
            {
                listTotalOperario.Items.Add(operario);
                listTotalOperario.Items.Add(acumuladoSueldos[cont]);
                cont++;
            }
        }

        private void muestraOperarioMejorPago()
        {
            int resultado = mejorPago();
            MessageBox.Show("El operario mejor pago es " + operarios[resultado] + " y su sueldo es de $" + acumuladoSueldos[resultado]);
              
        }
        #endregion

        private int mejorPago()
        {
            int mejorOperario = 0;
            double mejorSueldo = acumuladoSueldos[0];
            int cont = 0;
            foreach (var sueldoAcumulado in acumuladoSueldos)
            {
                if (sueldoAcumulado > mejorSueldo)
                {
                    mejorOperario = cont;
                    mejorSueldo = sueldoAcumulado;
                }
                cont++;
            }
            return mejorOperario;
        }
    }

}
