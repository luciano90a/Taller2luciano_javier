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
    public partial class curso_x_estudiante : Form
    {
        public curso_x_estudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT c.Nombre_curso as nombre_curso_estudiante FROM Cursosestudiantes ce INNER JOIN Cursos c ON ce.CursosCodigo_curso = c.Codigo_curso WHERE ce.EstudianteRut_estudiante ="+code;
            data.DataSource = cone.SelectQuery(query);
        }

        private void lista_estudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_estudiante.Text;
            string[] param = { "@name", name };
            string query = "select e.Rut_estudiante from estudiante e where e.Nombre_estudiante=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void curso_x_estudiante_Load(object sender, EventArgs e)
        {
            string query = "select * from estudiante";
            DataTable estudiante = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < estudiante.Rows.Count; i++)
            {
                lista_estudiante.Items.Add(estudiante.Rows[i]["Nombre_estudiante"]);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
