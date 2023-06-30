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
    public partial class est_det_proy : Form
    {
        public est_det_proy()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            string query = " SELECT e.Nombre_estudiante, e.Rut_estudiante FROM Estudiantesproyecto ep INNER JOIN Estudiante e ON ep.EstudianteRut_estudiante = e.Rut_estudiante WHERE ep.ProyectoCodigo_proyecto ="+out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            dataGridView1.DataSource = cone.SelectQuery(query);
        }

        private void Lista_proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = Lista_proyectos.Text;
            string[] param = { "@name", name };
            string query = "select p.Codigo_proyecto from proyecto p where p.Nombre_proyecto=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void est_det_proy_Load(object sender, EventArgs e)
        {
            string query_carreras = "select * from proyecto";
            DataTable carrera = ConnectMySQL.Instance.SelectQuery(query_carreras);
            for (int i = 0; i < carrera.Rows.Count; i++)
            {
                Lista_proyectos.Items.Add(carrera.Rows[i]["Nombre_proyecto"]);
            }
        }
    }
}
