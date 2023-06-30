using MySql.Data.MySqlClient;
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
    public partial class Actualizar_bono : Form
    {
        public Actualizar_bono()
        {
            InitializeComponent();
        }

        private void Actualizar_bono_Load(object sender, EventArgs e)
        {
            string query = "select * from departamento";
            DataTable deptos = ConnectMySQL.Instance.SelectQuery(query);
            for ( int i=0;i<deptos.Rows.Count;i++ )
            {
                lista_profesor.Items.Add(deptos.Rows[i]["ProfesorRut_profesor"]);
            }
        }

        private void bono_in_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rut = lista_profesor.Text;
            string[] param = {"@rut",rut }; 
            string query = "select p.Nombre_profesor from profesor p where p.Rut_profesor=@rut";
            ConnectMySQL cone = ConnectMySQL.Instance;
            string nom = cone.SelectQueryScalar(query, param);
            out_text1.Text = nom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bono = bono_in.Text;
            int result = 0;
            bool verificacion = Int32.TryParse(bono, out result);
            if (bono.Equals("") || verificacion == false)
            {
                MessageBox.Show("Digite nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MySqlParameter[] parameters =
                {
                new MySqlParameter("@rut", lista_profesor.Text),
                new MySqlParameter("@bono", bono)
                };
                ConnectMySQL cone = ConnectMySQL.Instance;
                string query = "UPDATE departamento SET bonodirector = @bono WHERE ProfesorRut_profesor = @rut";
                cone.ExecuteQuery(query, parameters);
                MessageBox.Show("BONO ACTUALIZADO CORRECTAMENTE :D", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
