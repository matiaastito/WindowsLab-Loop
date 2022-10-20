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
    public partial class FrmCaso1 : Form
    {
        private int[] notas = new int[3];
        private string[] nomAlumno = new string[4];
        
        public FrmCaso1()
        {
            InitializeComponent();
        }

        private void btnIngresoAlumnos_Click(object sender, EventArgs e)
        {
            cargaAlumnos();
            cargaNotas(nomAlumno);
        }

        private void cargaAlumnos()
        {
            for (int i = 0; i < nomAlumno.Length; i++)
            {
                nomAlumno[i] = Interaction.InputBox("Ingrese el nombre del" + (i+1) + "° alumno");
            }
        }

        private void cargaNotas(string[] alumnos)
        {
            foreach (string alumnario in alumnos)
            {
                for (int i = 0; i < notas.Length; i++)
                {
                    notas[i] = int.Parse(Interaction.InputBox("Ingresa la " + (i + 1) + "° nota del alumno " + alumnario)); 
                }

                mostrarMayorNota(alumnario, notas);
                mostrarPromedio(alumnario, notas);
                
            }
        }

        private void mostrarPromedio(string alumno, int[] notas)
        {
            vectorPromedio.Items.Clear();
            vectorPromedio.Items.Add("Promedio");
            vectorPromedio.Items.Add(alumno);
            double promedio = 0;
            int suma = 0;
            int cont = 0;
            foreach (int nota in notas)
            {
                cont++;
                suma += nota;
            }
            promedio = (double) suma / (double) cont;
            vectorPromedio.Items.Add(promedio);
            informarCondicion(promedio);


        }

        private void informarCondicion(double promedio)
        {
            if (promedio < 4)
            {
                MessageBox.Show("Debe ir a recuperatorio");
            }
            else if(promedio <= 7)
            {
                MessageBox.Show("Bien");
            }
            else
            {
                MessageBox.Show("Muy bien");
            }
        }
        
        private void mostrarMayorNota(string alumno, int[] notas)
        {
            lstVector.Items.Clear();
            lstVector.Items.Add("Mayor nota");
            lstVector.Items.Add(alumno);
            int mayorNota = notas[0];
            foreach (int nota in notas)
            {
                if(nota > mayorNota)
                mayorNota = nota;
            }
            lstVector.Items.Add(mayorNota);
        }

    }
}
