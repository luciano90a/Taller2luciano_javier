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
    public partial class depto_profesor_t : Form
    {
        public depto_profesor_t()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = " SELECT Departamento.Nombre_departamento, COUNT(Profesor.Rut_profesor) AS Cantidad_profesores FROM Departamento INNER JOIN Profesor ON Departamento.Codigo_departamento = Profesor.DepartamentoCodigo_departamento GROUP BY Departamento.Codigo_departamento";
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource=cone.SelectQuery(query);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
