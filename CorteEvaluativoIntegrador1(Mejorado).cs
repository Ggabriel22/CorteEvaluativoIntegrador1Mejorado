using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
   
    private void btnRegist_Click(object sender, EventArgs e)
        {
            string Nombre = Convert.ToString(txtNombre.Text);


          

            string nombre = "¡Bienvenido ala App!";

            txtBienvenid.Text = nombre.ToString();
        }

        
    }

}

