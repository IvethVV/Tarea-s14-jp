using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1. Datos
            string[] nombresConsulta = { "Ana Torres", "Luis Ramos", "María Díaz" };
            double[] notasConsulta = { 18, 14, 11 };

            // 2. Leer cuadro de texto
            string buscado = txtBuscado.Text.Trim().ToLower();

            if (buscado == "")
            {
                lblResultado.Text = "Escribe un nombre para buscar.";
                return;
            }

            int posicion = -1;

            // 3. Buscar
            for (int i = 0; i < nombresConsulta.Length; i++)
            {
                string nombreActual = nombresConsulta[i].Trim().ToLower();

                if (nombreActual.Contains(buscado))
                {
                    posicion = i;
                    break;
                }
            }

            // 4. Mostrar resultado (con el $ corregido afuera de las comillas)
            if (posicion != -1)
            {
                lblResultado.Text = $"Resultado: - Nota: {notasConsulta[posicion]:F2}";
            }
            else
            {
                lblResultado.Text = "Estudiante no encontrado.";
            }
        }
    }
}
