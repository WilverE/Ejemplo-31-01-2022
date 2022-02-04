using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo_31_01_2022
{
    public partial class Form1 : Form
    {
        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ingresarDatos_Click(object sender, EventArgs e)
        {
            persona.Dpi = textBoxDpi.Text;
            persona.Nombre = textBoxNombre.Text.Trim(); 
            persona.Nombre = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(persona.Nombre);
            persona.Apellido = textBoxApellido.Text.Trim();
            persona.Apellido = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(persona.Apellido);
            persona.FechaNacimiento = dateTimePickerFechaNacimiento.Value;

            
        }

        private void mostrarDatos_Click(object sender, EventArgs e)
        {
            labelDpi.Text = persona.Dpi;
            labelNombre.Text = persona.Nombre;
            labelApellido.Text = persona.Apellido;
            labelFechaNacimiento.Text = persona.FechaNacimiento.ToString();
            labelEdad.Text = "la edad es: " +persona.edad().ToString(); 

        }


    }
}
