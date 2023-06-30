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
    public partial class est_cada_proy_anterior : Form
    {
        public est_cada_proy_anterior()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectMySQL cone = ConnectMySQL.Instance;
            string query = "  SELECT Proyecto.Codigo_proyecto, Proyecto.Nombre_proyecto, Estudiante.Rut_estudiante, Estudiante.Nombre_estudiante FROM Proyecto INNER JOIN Estudiantesproyecto ON Proyecto.Codigo_proyecto = Estudiantesproyecto.ProyectoCodigo_proyecto INNER JOIN Estudiante ON Estudiantesproyecto.EstudianteRut_estudiante = Estudiante.Rut_estudiante WHERE YEAR(Proyecto.Fecha_inicio) < YEAR(CURDATE()) ";
            data.DataSource = cone.SelectQuery(query);
        }
    }
}
