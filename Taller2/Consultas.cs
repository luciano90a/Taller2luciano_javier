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
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            datoscarrera_alumno datoscarrera = new datoscarrera_alumno();
            datoscarrera.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            est_carrera_actual est_Carrera_Actual = new est_carrera_actual();
            est_Carrera_Actual.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            est_carrera_antes est_Carrera_Antes = new est_carrera_antes();
            est_Carrera_Antes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            est_cada_proy est_Cada_Proy = new est_cada_proy();
            est_Cada_Proy.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            est_cada_proy_anterior _Cada_Proy_Anterior = new est_cada_proy_anterior();
            _Cada_Proy_Anterior.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ultimos_proy ultimos_Proy = new ultimos_proy();
            ultimos_Proy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prof_dirigir_proy prof_Dirigir_Dep = new prof_dirigir_proy();
            prof_Dirigir_Dep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            est_det_proy est_Det_Proy = new est_det_proy();
            est_Det_Proy.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            profesores_x_depto profesores_x_Depto = new profesores_x_depto();
            profesores_x_Depto.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            cursos_x_depto cursos_X_Depto = new cursos_x_depto();
            cursos_X_Depto.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            curso_x_estudiante curso_X_Estudiante = new curso_x_estudiante();
            curso_X_Estudiante.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            est_det_curso est_Det_Curso = new est_det_curso();
            est_Det_Curso.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            depto_profesor depto_Profesor = new depto_profesor();
            depto_Profesor.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            datos_esp datos_Esp = new datos_esp();
            datos_Esp.Show();   
        }

        private void button14_Click(object sender, EventArgs e)
        {
            datos_dir_depto datos_Dir_Depto = new datos_dir_depto();
            datos_Dir_Depto.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            dat_jefe_carrera dat_Jefe_Carrera = new dat_jefe_carrera();
            dat_Jefe_Carrera.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            carrera_menos_diez carrera_Menos_Diez = new carrera_menos_diez();
            carrera_Menos_Diez.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            depto_profesor_t depto_Profesor_T = new depto_profesor_t();
            depto_Profesor_T.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            curso_menor_cant curso_Menor_Cant = new curso_menor_cant();
            curso_Menor_Cant.Show();
        }
    }
}
