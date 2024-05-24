using P18.Data.DataAcces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P18
{
    public partial class Form1 : Form
    {
        private PersonajesDB personaje;//Declarar una instancia de PersonajesDB

        private void labelID_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // Lista de razas
        private string[] razasDragonBall = {
            "Android",
            "Bio-Android",
            "Humana",
            "Humano",
            "Majin",
            "Namekuseijin",
            "Saiyajin",
            "Saiyajin/Humano",
            "Saiyajin/Saiyajin"
        };
        public Form1()
        {
            InitializeComponent();
            personaje = new PersonajesDB();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Llenar el ComboBox con las razas
            comboBoxRaza.Items.AddRange(razasDragonBall);
            // Suscribir el evento SelectedIndexChanged al ComboBox
            comboBoxRaza.SelectedIndexChanged += comboBoxRaza_SelectedIndexChanged;

        }
        private void comboBoxRaza_SelectedIndexChanged(object sender, EventArgs e)//Para que lo seleccionado en el combo box se asigne en el textBox
        {
            // Obtener el valor seleccionado en el ComboBox
            string razaSeleccionada = comboBoxRaza.SelectedItem.ToString();

            // Establecer el valor en el TextBox
            textBoxRaza.Text = razaSeleccionada;
        }
        //Metodo para comprobar si la conexion fue o no exitosa
        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if (personaje.ProbarConexion())
            {
                MessageBox.Show("Si se pudo");

            }
            else
            {
                MessageBox.Show("Nel pastel");
            }
        }


        //Cargar todos los datos a traves del metodo LeerPersonajes
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
        }

        //Para insertar nuevos personajes
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            {
                //Obtener los datos del formulario
                string nombre = textBoxNombre.Text;
                string raza = textBoxRaza.Text;
                string historia= textBoxHistoria.Text;
                DateTime fecha_creacion = /*DateTime.Now;*/dateTimePickerFecha_Creacion.Value;
                int nivelPoder = (int)numericUpDownNiveldePoder.Value;
                //insertar el personaje en la base de datos
                int respuesta = personaje.CrearPersonaje(nombre, raza, nivelPoder,historia,fecha_creacion);
                if (respuesta > 0)
                {
                    MessageBox.Show("Se creo correctamente");
                    dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                    textBoxNombre.Clear();
                    textBoxRaza.Clear();
                    textBoxHistoria.Clear();
                    numericUpDownNiveldePoder.ResetText();
                }
                else
                {
                    MessageBox.Show("Hubo un error al crear persona");
                }
            }
        }


        //Buscar por identificacion y palabra clave en la historia
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))//Verificar si el textBox de la id esta vacio 
            {
                //Si no esta vacia la id
                int id = int.Parse(textBoxID.Text);
                dataGridViewPersonajes.DataSource = personaje.BuscarPersonajes(id);
                textBoxID.Clear();
            }
            else if (!string.IsNullOrWhiteSpace(textBoxHistoria.Text))//verificar si el textBox de la historia esta vacio 
            {
                //si no lo esta entra aqui
                string historia = textBoxHistoria.Text;
                dataGridViewPersonajes.DataSource = personaje.BuscarPersonajes(historia);
                textBoxHistoria.Clear();
            }
            else// si ambos estan vacios entra aqui
            {
                MessageBox.Show("Ingresa la identificacion o una palabra clave de la historia del personaje");
                textBoxID.Focus();
            }
        }

        //Para poder buscar a traves de la fecha de creacion, por medio de dos fechas
        private void button1BuscarPorFecha_Click(object sender, EventArgs e)
        {
            DateTime firstdate = dateTimePickerFecha_Creacion.Value;
            DateTime seconddate = dateTimePickerBuscarEntreFechas.Value;
            dataGridViewPersonajes.DataSource = personaje.Buscarfecha(firstdate, seconddate);
        }

        //Actualizar los datos de un personaje de la tabla
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxID.Text);
            string nombre = textBoxNombre.Text;
            string raza = textBoxRaza.Text;
            string historia = textBoxHistoria.Text;
            int nivelPoder = (int)numericUpDownNiveldePoder.Value;

            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                MessageBox.Show("Se creo correctamente");
                textBoxNombre.Clear();
                textBoxRaza.Clear();
                numericUpDownNiveldePoder.ResetText();
                textBoxHistoria.Clear();
                textBoxID.Clear();
                personaje.ActualizarPersonaje(id, nombre, raza, nivelPoder, historia);
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
            }
            else
            {
                MessageBox.Show("Ingrese la identificacion del personaje");

            }

        }

        //Para eliminar a un personaje por medio de la id
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                int id = int.Parse(textBoxID.Text);
                personaje.EliminarPersonaje(id);
                MessageBox.Show("Se elimino el personaje correctamente");
                dataGridViewPersonajes.DataSource = personaje.LeerPersonajes();
                textBoxID.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese la identificacion del personaje");
            }
        }


    }
}
