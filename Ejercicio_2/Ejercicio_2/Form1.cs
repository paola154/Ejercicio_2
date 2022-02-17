using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        // Hice uso de ArrayList para que el usuario tenga acceso a agregar cuantos estudiantes desee.
        // y evitando en lugar de pedir el tamaño para cada arreglo.
        ArrayList Estudiantes;
        ArrayList Edades;

        public Form1()
        {
            InitializeComponent();
            // Inicializo los dos arreglos a usar 
            Estudiantes = new ArrayList();
            Edades = new ArrayList();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            // Aquí el usuario podra ingresar los nombres de los estudiantes y su edad. 
            Estudiantes.Add (NombreEstudiantetextBox.Text.ToString());
            Edades.Add(EdadtextBox.Text);

            // Se usa la instruccion .clear para limpiar el campo y poder agregar otro nuevo 
            NombreEstudiantetextBox.Clear();
            EdadtextBox.Clear();    
        }

        private void Mostrarbutton_Click(object sender, EventArgs e)
        {
            // Con estas instrucciones podremos mostrar los datos antes ingresados en un listBox
            // Haciendo uso de un for.
            for(int i =0; i < Estudiantes.Count;i++)
            {
                listBox1.Items.Add("El alumno: " + Estudiantes[i] + "Tiene " + Edades[i] + " Años de edad");
            }
        }
    }
}
