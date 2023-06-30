using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void Seccion_modificaciones_Click(object sender, EventArgs e)
        {
            autenticacion_form autenticacion_Form = new autenticacion_form();
            autenticacion_Form.Show();
        }

        private void Seccion_consultas_Click(object sender, EventArgs e)
        {
            Consultas consultas = new Consultas();
            consultas.Show();
        }
    }
}
