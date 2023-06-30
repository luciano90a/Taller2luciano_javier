using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Taller2.Taller2;

namespace Taller2
{
    public partial class est_det_curso : Form
    {
        public est_det_curso()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_cursos.Text;
            string[] param = { "@name", name };
            string query = " select cursos.Codigo_curso from cursos where cursos.Nombre_curso=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            string query = "SELECT Estudiante.Rut_estudiante, Estudiante.Nombre_estudiante, Profesor.Nombre_profesor FROM Estudiante INNER JOIN Cursosestudiantes ON Estudiante.Rut_estudiante = Cursosestudiantes.EstudianteRut_estudiante INNER JOIN Cursos ON Cursosestudiantes.CursosCodigo_curso = Cursos.Codigo_curso INNER JOIN Profesor ON Cursos.ProfesorRut_profesor = Profesor.Rut_profesor WHERE Cursos.Codigo_curso="+code;
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource= cone.SelectQuery(query);
        }

        private void est_det_curso_Load(object sender, EventArgs e)
        {
            string query = "select * from cursos";
            DataTable cursos = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < cursos.Rows.Count; i++)
            {
                lista_cursos.Items.Add(cursos.Rows[i]["Nombre_curso"]);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
