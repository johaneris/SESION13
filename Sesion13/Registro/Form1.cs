using Registro.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> persons;
        public Form1()
        {
            InitializeComponent();

            persons = new List<Persona>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();

            person.FirstName = tbNombre.Text;
            person.LastName = tbApellido.Text;
            person.Birthdate = dtpFechaNacimiento.Value;
            person.Edad = Convert.ToInt16(tbEdad.Text);
            persons.Add(person);
            ShowPerson();
            Cleartb();

        }

        private void ShowPerson()
        {
            dgvResultados.DataSource = null;
            dgvResultados.DataSource = persons;

        }

        private void Cleartb()
        {
            tbNombre.Clear();
            tbApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            tbNombre.Focus();
        }
    }
}
