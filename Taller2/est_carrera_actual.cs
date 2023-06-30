using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Taller2.Taller2;
using MySql.Data.MySqlClient;

namespace Taller2
{
    public partial class est_carrera_actual : Form
    {
        public est_carrera_actual()
        {
            InitializeComponent();
        }

        private void est_carrera_actual_Load(object sender, EventArgs e)
        {
            string query_carreras = "select * from carrera";
            DataTable carrera = ConnectMySQL.Instance.SelectQuery(query_carreras);
            for (int i = 0; i < carrera.Rows.Count; i++)
            {
                listacarreras.Items.Add(carrera.Rows[i]["nombre_carrera"]);
            }
        }

        private void listacarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = listacarreras.Text;
            string [] param = { "@name", name };
            string query = "select Codigo_carrera from carrera c where c.nombre_carrera=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string code = out_text1.Text;
            string[] parame = { "@code", code };
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT Rut_estudiante, Nombre_estudiante FROM Estudiante WHERE  Year_ingreso = YEAR(CURRENT_DATE) and CarreraCodigo_carrera=@code";
            data.DataSource = cone.SelectQuery(query,parame);
        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
