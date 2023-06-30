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
    public partial class Eliminar_dir_proyecto : Form
    {
        public Eliminar_dir_proyecto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eliminar_dir_proyecto_Load(object sender, EventArgs e)
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
            string query2 = "select p.active from proyecto p where p.Nombre_proyecto=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            string code2 = ConnectMySQL.Instance.SelectQueryScalar(query2, param);
            out_text1.Text = code;
            out_text2.Text = code2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int active =0;
            string code_proy = out_text1.Text;
            MySqlParameter[] parameters =
            {
                new MySqlParameter("@active", active),
                new MySqlParameter("@code_proy", code_proy)
            };
            string query = "UPDATE proyecto SET active = @active WHERE proyecto.Codigo_proyecto = @code_proy";
            ConnectMySQL cone = ConnectMySQL.Instance;
            cone.ExecuteQuery(query, parameters);
            string name = lista_proy.Text;
            string[] param = { "@name", name };
            string query2 = "select p.active from proyecto p where p.Nombre_proyecto=@name";
            string code2 = ConnectMySQL.Instance.SelectQueryScalar(query2, param);
            out_text2.Text = code2;
        }
    }
}
