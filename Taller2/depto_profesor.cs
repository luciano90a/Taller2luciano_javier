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
    public partial class depto_profesor : Form
    {
        public depto_profesor()
        {
            InitializeComponent();
        }

        private void depto_profesor_Load(object sender, EventArgs e)
        {
            string query = "select * from profesor";
            DataTable profesor = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < profesor.Rows.Count; i++)
            {
                lista_profesor.Items.Add(profesor.Rows[i]["Nombre_profesor"]);
            }
        }

        private void lista_deptos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_profesor.Text;
            string[] param = { "@name" , name };
            string query = " select profesor.Rut_profesor from profesor where profesor.Nombre_profesor=@name";
            ConnectMySQL cone = ConnectMySQL.Instance;
            string code= cone.SelectQueryScalar(query, param);
            out_text1.Text = code;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            string query = " SELECT Profesor.Nombre_profesor, Departamento.Nombre_departamento FROM Profesor INNER JOIN Departamento ON Profesor.DepartamentoCodigo_departamento = Departamento.Codigo_departamento WHERE Profesor.Rut_profesor="+code;
            ConnectMySQL cone= ConnectMySQL.Instance;
            data.DataSource = cone.SelectQuery(query);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
