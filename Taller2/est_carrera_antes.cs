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
    public partial class est_carrera_antes : Form
    {
        public est_carrera_antes()
        {
            InitializeComponent();
        }

        private void lista_nom_carreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_nom_carreras.Text;
            string[] param = { "@name", name };
            string query = "select Codigo_carrera from carrera c where c.nombre_carrera=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void est_carrera_antes_Load(object sender, EventArgs e)
        {
            string query_carreras = "select * from carrera";
            DataTable carrera = ConnectMySQL.Instance.SelectQuery(query_carreras);
            for (int i = 0; i < carrera.Rows.Count; i++)
            {
                lista_nom_carreras.Items.Add(carrera.Rows[i]["nombre_carrera"]);
            }
        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            string[] parame = { "@code", code };
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT Rut_estudiante, Nombre_estudiante FROM Estudiante WHERE  Year_ingreso < YEAR(CURRENT_DATE) and CarreraCodigo_carrera=@code";
            data.DataSource = cone.SelectQuery(query, parame);
        }
    }
}
