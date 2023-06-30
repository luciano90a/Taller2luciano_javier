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
    public partial class curso_menor_cant : Form
    {
        public curso_menor_cant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Cursos.Codigo_curso, Cursos.Nombre_curso, COUNT(Cursosestudiantes.EstudianteRut_estudiante) AS Cantidad_estudiantes FROM Cursos INNER JOIN Cursosestudiantes ON Cursos.Codigo_curso = Cursosestudiantes.CursosCodigo_curso GROUP BY Cursos.Codigo_curso, Cursos.Nombre_curso ORDER BY COUNT(Cursosestudiantes.EstudianteRut_estudiante) ASC LIMIT 1";
            ConnectMySQL cone = ConnectMySQL.Instance;
            data.DataSource = cone.SelectQuery(query);
        }
    }
}
