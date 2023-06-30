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
    public partial class datos_dir_depto : Form
    {
        public datos_dir_depto()
        {
            InitializeComponent();
        }

        private void datos_dir_depto_Load(object sender, EventArgs e)
        {
            string query = "select * from departamento";
            DataTable depto = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < depto.Rows.Count; i++)
            {
                lista_deptos.Items.Add(depto.Rows[i]["Nombre_departamento"]);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_deptos.Text;
            string[] param = { "@name", name };
            string query = "select d.Codigo_departamento from departamento d where d.Nombre_departamento=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT d.Nombre_departamento, p.Nombre_profesor AS Director, d.bonodirector FROM Departamento d INNER JOIN Profesor p ON d.ProfesorRut_profesor = p.Rut_profesor WHERE d.Codigo_departamento="+ code;
            data.DataSource = cone.SelectQuery(query);
        }
    }
}
