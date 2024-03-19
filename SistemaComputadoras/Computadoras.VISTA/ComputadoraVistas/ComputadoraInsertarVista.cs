using Computadora.BSS;
using Computadora.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computadoras.VISTA.ComputadoraVistas
{
    public partial class ComputadoraInsertarVista : Form
    {
        public ComputadoraInsertarVista()
        {
            InitializeComponent();
        }
        public static int IdComputadoraSeleccionada = 0;
        ComputadoraBss bss = new ComputadoraBss();
        private void Guardar_btn_Click(object sender, EventArgs e)
        {
            ComputadorasPC computadoras = new ComputadorasPC();
            computadoras.Nombre = Nombre_txt.Text;
            computadoras.Descripcion = Descripcion_txt.Text;
            computadoras.Precio = Convert.ToInt32(Precio_txt.Text);
            computadoras.FechaFabricacion = dateTimePicker1.Value;

            bss.InsertarComputadoraBss(computadoras);
            MessageBox.Show("Se guardo exitosamente");
        }

        private void ComputadoraInsertarVista_Load(object sender, EventArgs e)
        {

        }

        private void Seleccionar_Btn_Click(object sender, EventArgs e)
        {
            ComputadoraListarVista fr = new ComputadoraListarVista();
            if (fr.ShowDialog() == DialogResult.OK) { }
            {
                ComputadorasPC computadora = bss.ObtenerComputadorabss(IdComputadoraSeleccionada);
                textBox1.Text = computadora.Nombre + " " + computadora.Descripcion;
            }

        }
    }
}
