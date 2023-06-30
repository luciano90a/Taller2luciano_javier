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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Taller2
{
    public partial class prof_dirigir_proy : Form
    {
        public prof_dirigir_proy()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }
        private void prof_dirigir_dep_Load(object sender, EventArgs e)
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
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string code_proy = out_text1.Text;
            string query = " SELECT pr.Nombre_profesor,pr.Rut_profesor FROM Proyecto p INNER JOIN Profesor pr ON p.ProfesorRut_profesor = pr.Rut_profesor WHERE p.Codigo_proyecto =" + code_proy;
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource = cone.SelectQuery(query);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
