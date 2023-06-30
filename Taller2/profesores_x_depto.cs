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
    public partial class profesores_x_depto : Form
    {
        public profesores_x_depto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code_depto = out_text1.Text;
            string query = "SELECT p.Nombre_profesor, p.Fecha_contratacion, YEAR(CURDATE()) - YEAR(p.Fecha_contratacion) AS antiguedad FROM Profesor p INNER JOIN Departamento d ON p.DepartamentoCodigo_departamento = d.Codigo_departamento WHERE d.Codigo_departamento =" + code_depto;
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource=cone.SelectQuery(query);
        }

        private void lista_deptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_deptos.Text;
            string[] param = { "@name", name };
            string query = "select d.Codigo_departamento from departamento d where d.Nombre_departamento=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void out_text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void profesores_x_depto_Load(object sender, EventArgs e)
        {
            string query_deptos = "select * from departamento";
            DataTable deptos = ConnectMySQL.Instance.SelectQuery(query_deptos);
            for (int i = 0; i < deptos.Rows.Count; i++)
            {
                lista_deptos.Items.Add(deptos.Rows[i]["Nombre_departamento"]);
            }
        }
    }
}
