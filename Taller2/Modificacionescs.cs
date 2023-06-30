using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Modificacionescs : Form
    {
        public Modificacionescs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void insertar_Click(object sender, EventArgs e)
        {
            Insertar_estudiante_carrera insertar_Estudiante_Carrera = new Insertar_estudiante_carrera();
            insertar_Estudiante_Carrera.Show();
        }

        private void eliminar_dir_Click(object sender, EventArgs e)
        {
            Eliminar_dir_proyecto eliminar_Dir_Proyecto = new Eliminar_dir_proyecto();
            eliminar_Dir_Proyecto.Show();
        }

        private void eliminar_est_p_Click(object sender, EventArgs e)
        {
            Eliminar_participacion_estudiante_proyecto eliminar_Participacion_Estudiante_ = new Eliminar_participacion_estudiante_proyecto();
            eliminar_Participacion_Estudiante_.Show();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            Actualizar_bono actualizar_Bono = new Actualizar_bono();
            actualizar_Bono.Show();

        }

        private void inactivo_Click(object sender, EventArgs e)
        {
            Dejarproy_inactivo dejarproy_Inactivo = new Dejarproy_inactivo();
            dejarproy_Inactivo.Show();
        }

        private void Modificacionescs_Load(object sender, EventArgs e)
        {

        }
    }
}
