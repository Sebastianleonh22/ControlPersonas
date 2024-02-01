using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPersonas
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();

            dateTimePicker1.Value = DateTime.Today; // Establece la fecha actual
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = " ";
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {  
            persona.Dpi = txtbxDpi.Text;
            persona.Nombre = txtbxNombre.Text;
            persona.Apellido = txtbxApellido.Text;
            persona.FechaNacimiento1 = dateTimePicker1.Value;

            txtbxDpi.Text = string.Empty;
            txtbxNombre.Text = string.Empty;
            txtbxApellido.Text = string.Empty;

            button1.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = persona.Dpi;
            label6.Text = persona.Nombre.Substring(0,1).ToUpper() + persona.Nombre.Substring(1).ToLower();
            label7.Text = persona.Apellido.Substring(0, 1).ToUpper() + persona.Apellido.Substring(1).ToLower();
            label8.Text = persona.FechaNacimiento1.ToShortDateString();

            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            label12.Visible = true;
  

        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
