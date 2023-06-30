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
    public partial class ultimos_proy : Form
    {
        public ultimos_proy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = " SELECT Proyecto.Codigo_proyecto, Proyecto.Nombre_proyecto, Profesor.Rut_profesor, Profesor.Nombre_profesor FROM Proyecto INNER JOIN Profesor ON Proyecto.ProfesorRut_profesor = Profesor.Rut_profesor WHERE YEAR(Proyecto.Fecha_inicio) >= YEAR(CURDATE()) - 3 ";
            data.DataSource=cone.SelectQuery(query);
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
