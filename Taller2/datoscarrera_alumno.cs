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
    public partial class datoscarrera_alumno : Form
    {
        public datoscarrera_alumno()
        {
            InitializeComponent();
        }

        private void rut_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void ver_datos_bt_Click(object sender, EventArgs e)
        {
            string rut_ingresado = rut_in.Text;
            int result = 0;
            bool verificacion = Int32.TryParse(rut_ingresado, out result);
            if ( rut_ingresado.Equals("") || verificacion==false )
            {
                MessageBox.Show("Digite nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ConnectMySQL cone = ConnectMySQL.Instance;
                string query = "select * from carrera c inner join estudiante e on c.Codigo_carrera=e.CarreraCodigo_carrera where e.Rut_estudiante="+rut_ingresado;
                data.DataSource = cone.SelectQuery(query);
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void datoscarrera_alumno_Load(object sender, EventArgs e)
        {

        }
    }
}
