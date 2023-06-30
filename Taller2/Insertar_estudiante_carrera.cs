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
    public partial class Insertar_estudiante_carrera : Form
    {
        private List<string> rut_alumno = new List<string>();
        public Insertar_estudiante_carrera()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargar_alumno()
        {
            string query = "select * from estudiante";
            DataTable alumnos = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < alumnos.Rows.Count; i++)
            {
                object rutEstudiante = alumnos.Rows[i]["Rut_estudiante"];
                string alumno = rutEstudiante != DBNull.Value ? rutEstudiante.ToString() : string.Empty;
                if (alumno == null)
                {
                    continue;
                }
                else
                {
                    rut_alumno.Add(alumno);
                }
            }
            
        }

        private void Insertar_estudiante_carrera_Load(object sender, EventArgs e)
        {
            
            string query = "select * from carrera";
            DataTable depto = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < depto.Rows.Count; i++)
            {
                lista_carreras.Items.Add(depto.Rows[i]["nombre_carrera"]);
            }
            cargar_alumno();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rut_ingresado = rut_in.Text;
            string nombre_ingresado = input_nombre.Text;
            string year_ingreaso = year_in.Text;
            string carrera = lista_carreras.Text;
            string out_text = out_text1.Text;
            int result = 0;
            int result_2 = 0;
            bool verificacion = Int32.TryParse(rut_ingresado, out result);
            bool verificacion_year = Int32.TryParse(year_ingreaso, out result_2);
            if (carrera.Equals("") || nombre_ingresado.Equals("") || rut_ingresado.Equals("")
                || verificacion == false || verificacion_year.Equals("") 
                || verificacion_year == false || rut_alumno.Contains(rut_ingresado))
            {
                MessageBox.Show("Digite nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MySqlParameter[] parameters =
           {
                new MySqlParameter("@Rut", rut_ingresado),
                new MySqlParameter("@Name", nombre_ingresado),
                new MySqlParameter("@year", year_ingreaso),
                new MySqlParameter("@carrera", out_text )
            };
                ConnectMySQL cone = ConnectMySQL.Instance;
                string query = "  INSERT INTO Estudiante (Rut_estudiante, Nombre_estudiante, Year_ingreso, CarreraCodigo_carrera ) VALUES   (@rut,@name,@year,@carrera)";
                cone.ExecuteQuery(query, parameters);
                MessageBox.Show("INGRESADO CORRECTAMENTE :D", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar_alumno();
            }
        }

        private void lista_carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_carreras.Text;
            string[] param = { "@name", name };
            string query = "select carrera.Codigo_carrera from carrera where carrera.nombre_carrera=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }
    }
}
