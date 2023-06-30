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
    public partial class dat_jefe_carrera : Form
    {
        public dat_jefe_carrera()
        {
            InitializeComponent();
        }

        private void dat_jefe_carrera_Load(object sender, EventArgs e)
        {
            string query = "select * from carrera";
            DataTable depto = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < depto.Rows.Count; i++)
            {
                lista_deptos.Items.Add(depto.Rows[i]["nombre_carrera"]);
            }
        }

        private void lista_deptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_deptos.Text;
            string[] param = { "@name", name };
            string query = "select carrera.Codigo_carrera from carrera where carrera.nombre_carrera=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT c.nombre_carrera, p.Nombre_profesor AS Jefe_carrera, jc.bono FROM Carrera c INNER JOIN Jefescarrera jc ON c.Codigo_carrera = jc.CarreraCodigo_carrera INNER JOIN Profesor p ON jc.ProfesorRut_profesor = p.Rut_profesor WHERE c.Codigo_carrera=" + code;
            data.DataSource = cone.SelectQuery(query);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
