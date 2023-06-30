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
    public partial class carrera_menos_diez : Form
    {
        public carrera_menos_diez()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = " SELECT Carrera.nombre_carrera, Profesor.Nombre_profesor AS Jefe_carrera, COUNT(Estudiante.Rut_estudiante) AS Cantidad_estudiantes FROM Carrera INNER JOIN Jefescarrera ON Carrera.Codigo_carrera = Jefescarrera.CarreraCodigo_carrera INNER JOIN Profesor ON Jefescarrera.ProfesorRut_profesor = Profesor.Rut_profesor INNER JOIN Estudiante ON Carrera.Codigo_carrera = Estudiante.CarreraCodigo_carrera GROUP BY Carrera.Codigo_carrera HAVING COUNT(Estudiante.Rut_estudiante) < 10";
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource=cone.SelectQuery(query);
        }
    }
}
