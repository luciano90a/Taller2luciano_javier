using MySql.Data.MySqlClient;
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
    public partial class Eliminar_participacion_estudiante_proyecto : Form
    {
        public Eliminar_participacion_estudiante_proyecto()
        {
            InitializeComponent();
        }

   
        public void load_alumnos()
        {
           
            alumnos_proy.Items.Clear();
            string query_alumnos_proy = "select * from estudiantesproyecto where estudiantesproyecto.ProyectoCodigo_proyecto="+out_text1.Text;
            DataTable alumnos = ConnectMySQL.Instance.SelectQuery(query_alumnos_proy);
            for (int i = 0; i < alumnos.Rows.Count; i++)
            {
                alumnos_proy.Items.Add(alumnos.Rows[i]["EstudianteRut_estudiante"]);
            }
        }
        private void Eliminar_participacion_estudiante_proyecto_Load(object sender, EventArgs e)
        {
            
            string query_carreras = "select * from proyecto";
            DataTable carrera = ConnectMySQL.Instance.SelectQuery(query_carreras);
            for (int i = 0; i < carrera.Rows.Count; i++)
            {
                lista_proy.Items.Add(carrera.Rows[i]["Nombre_proyecto"]);
            }
        }

        private void lista_proy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string name = lista_proy.Text;
            string[] param = { "@name", name };
            string query = "select p.Codigo_proyecto from proyecto p where p.Nombre_proyecto=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void out_text2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumnos_proy.ResetText();
            out_text2.ResetText();
            string query2 = "select * from estudiantesproyecto where estudiantesproyecto.ProyectoCodigo_proyecto=" + out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource = cone.SelectQuery(query2);
            load_alumnos();
        }

        private void alumnos_proy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (alumnos_proy.Text=="")
            {
                MessageBox.Show("Digite nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = alumnos_proy.Text;
                string[] param = { "@name", name };
                string query = "select e.Nombre_estudiante from estudiante e where e.Rut_estudiante=@name";
                string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
                out_text2.Text = code;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

          if (out_text1.Text=="" || out_text2.Text=="")
            {
                MessageBox.Show("Digite nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                MySqlParameter[] parameters =
                {
                new MySqlParameter("@rut", alumnos_proy.Text),
                new MySqlParameter("@code_proy", out_text1.Text)
                };
                ConnectMySQL cone = ConnectMySQL.Instance;
                string query = "DELETE FROM estudiantesproyecto  WHERE EstudianteRut_estudiante=@rut AND ProyectoCodigo_proyecto=@code_proy";
                MessageBox.Show("ELIMINASTE CORRECTAMENTE :D", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cone.ExecuteQuery(query, parameters);
            }
        }
    }
}
