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

            
            if (string.IsNullOrWhiteSpace(txtbxDpi.Text))
            {
                MessageBox.Show("Por favor, ingresa tu DPI antes de continuar.", "EROOR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            if (string.IsNullOrWhiteSpace(txtbxNombre.Text))
            {
                MessageBox.Show("Por favor, ingresa tu nombre antes de continuar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

           
            if (string.IsNullOrWhiteSpace(txtbxApellido.Text))
            {
                MessageBox.Show("Por favor, ingresa tu apellido antes de continuar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Por favor, selecciona tu fecha de nacimiento antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            int añoActual = DateTime.Now.Year;
            int añoSeleccionado = dateTimePicker1.Value.Year;

            if (añoSeleccionado >= añoActual || añoSeleccionado == (añoActual - 1))
            {
                MessageBox.Show("Por favor, selecciona una fecha de nacimiento válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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


            
            if (dateTimePicker1.Value == DateTimePicker.MinimumDateTime)
            {
                MessageBox.Show("Por favor, selecciona tu fecha de nacimiento antes de continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            
            int añoNacimiento = dateTimePicker1.Value.Year;
            int añoActual = DateTime.Now.Year;
            int edad = añoActual - añoNacimiento;

            
            labelEdad.Text = edad.ToString();

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
            label13.Visible = true;
            labelEdad.Visible = true;
  

        }

        private void txtbxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
