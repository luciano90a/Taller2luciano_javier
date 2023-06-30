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
    public partial class autenticacion_form : Form
    {
        public autenticacion_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void n_admin_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string n_admin_in = n_admin.Text;
            string c_admin_in = c_admin.Text;
            if ( n_admin_in.Equals("Admin") && c_admin_in.Equals("Admin") )
            {
                MessageBox.Show("INGRESASTE CORRECTAMENTE :D", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Modificacionescs modificacionescs = new Modificacionescs();
                modificacionescs.Show();
            }
            else
            {
                MessageBox.Show("INGRESASTE INCORRECTAMENTE :D", ":D", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void autenticacion_form_Load(object sender, EventArgs e)
        {
           
        }
    }
}
