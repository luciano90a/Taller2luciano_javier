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
    public partial class cursos_x_depto : Form
    {
        public cursos_x_depto()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lista_depto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_depto.Text;
            string[] param = { "@name", name };
            string query = "select d.Codigo_departamento from departamento d where d.Nombre_departamento=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT c.Nombre_curso FROM Cursos c INNER JOIN Departamento d ON c.DepartamentoCodigo_departamento = d.Codigo_departamento WHERE d.Codigo_departamento ="+code;
            data.DataSource = cone.SelectQuery(query);
        }

        private void cursos_x_depto_Load(object sender, EventArgs e)
        {
            string query = "select * from departamento";
            DataTable depto = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < depto.Rows.Count; i++)
            {
                lista_depto.Items.Add(depto.Rows[i]["Nombre_departamento"]);
            }
        }
    }
}
