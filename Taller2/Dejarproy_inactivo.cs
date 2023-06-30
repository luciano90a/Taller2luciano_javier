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
    public partial class Dejarproy_inactivo : Form
    {
        public Dejarproy_inactivo()
        {
            InitializeComponent();
        }

        private void Dejarproy_inactivo_Load(object sender, EventArgs e)
        {
            string query_proyectos = "select * from proyecto";
            DataTable proyectos = ConnectMySQL.Instance.SelectQuery(query_proyectos);
            for (int i = 0; i < proyectos.Rows.Count; i++)
            {
                lista_proyectos.Items.Add(proyectos.Rows[i]["Nombre_proyecto"]);
            }
        }

        private void lista_proyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_proyectos.Text;
            string[] param = { "@name", name };
            string query = "select p.Codigo_proyecto from proyecto p where p.Nombre_proyecto=@name";
            string query2 = "select p.ProfesorRut_profesor from proyecto p where p.Nombre_proyecto=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            string code2=ConnectMySQL.Instance.SelectQueryScalar(query2, param);
            out_text1.Text = code;
            out_text2.Text = code2;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlParameter[] param = {
                new MySqlParameter("@codigo",out_text1.Text)
                };
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = "UPDATE proyecto SET ProfesorRut_profesor = NULL WHERE Codigo_proyecto = @codigo";
            cone.ExecuteQuery(query, param);
            out_text2.Text = "null";
        }
        public bool verificar_null()
        {
            bool a = false;
            return a;
        }
    }
}
