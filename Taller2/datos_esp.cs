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
    public partial class datos_esp : Form
    {
        public datos_esp()
        {
            InitializeComponent();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lista_profesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = lista_profesor.Text;
            string[] param = { "@name", name };
            string query = "select profesor.Rut_profesor from profesor where profesor.Nombre_profesor=@name";
            string code = ConnectMySQL.Instance.SelectQueryScalar(query, param);
            out_text1.Text = code;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string code = out_text1.Text;
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = "SELECT p1.Nombre_profesor AS Profesor, p2.Nombre_profesor AS Esposo FROM Profesor p1 INNER JOIN Profesor p2 ON p1.esposo = p2.Rut_profesor WHERE p1.Rut_profesor="+code;
            data.DataSource = cone.SelectQuery(query);
        }

        private void datos_esp_Load(object sender, EventArgs e)
        {
            string query = "select * from profesor";
            DataTable profesores = ConnectMySQL.Instance.SelectQuery(query);
            for (int i = 0; i < profesores.Rows.Count; i++)
            {
                lista_profesor.Items.Add(profesores.Rows[i]["Nombre_profesor"]);
            }
        }
    }
}
