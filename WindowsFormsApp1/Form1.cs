using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.data.dataacces;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private ProgramaDB personajes;
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
            personajes = new ProgramaDB();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1raza.Items.AddRange(razasDragonBall);
        }

        private void prueba_Click(object sender, EventArgs e)
        {
            if (personajes.ProbarConexion()) 
            {
                MessageBox.Show("SI");
            }
            else
            {
                MessageBox.Show("no");
            }
        }

        private void cargar_Click(object sender, EventArgs e)
        {
            DataTable dt = personajes.LeerPersonajes();
            dataGridViewPersonajes.DataSource = dt;
        }

        private void nivelpoder_TextChanged(object sender, EventArgs e)
        {

        }

        private void crear_Click(object sender, EventArgs e)
        {
            string tnombre = nombre.Text;
            string traza = comboBox1raza.Text;
            int tnivelPoder = (int)nivelpoder.Value;
            int respuesta = personajes.CrearPersonaje(tnombre, traza, tnivelPoder);
            if (respuesta > 0)
            {
                MessageBox.Show("creado con exito");
                dataGridViewPersonajes.DataSource = personajes.LeerPersonajes();

            }
            else
            {
                MessageBox.Show("la cagaste en algo");
            }
        }

        private void BuscarPorId()
        {
            int idPersonajeBuscar = int.Parse(id.Text);
            DataTable personajeEncontrado = personajes.BuscarPersonajePorId(idPersonajeBuscar);
            if (personajeEncontrado.Rows.Count > 0)
            {
                string tnombre = personajeEncontrado.Rows[0]["nombre"].ToString();
                string traza = personajeEncontrado.Rows[0]["raza"].ToString();
                int tnivelPoder = int.Parse(personajeEncontrado.Rows[0]["nivel_poder"].ToString());
                nombre.Text = tnombre;
                comboBox1raza.Text = traza;
                nivelpoder.Value = tnivelPoder;
            }
            else
            {
                MessageBox.Show("No hay nada");
            }
        }
        private void buttonbuscar_Click(object sender, EventArgs e)
        {

        }

        private void id_TextChanged(object sender, EventArgs e)
        {

        }

        private void id_Leave(object sender, EventArgs e)
        {
            BuscarPorId();
        }
    }
}

