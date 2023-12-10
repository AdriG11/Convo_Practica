using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace Convo_Practica
{
    public partial class Form2 : Form

    {
        public static List<Docente> Datos_Docentes = new List<Docente>();
        public static List<Estudiante> Datos_Estudiante = new List<Estudiante>();
        public static List<Matricula> Datos_Matricula = new List<Matricula>();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGuarEst_Click(object sender, EventArgs e)
        {
            Datos_Estudiante.Add(new Estudiante
            {
                Nombre_Estudiante = txtNomEst.Text,
                Apellido = txtApeEst.Text,
                Fecha_Nacimiento = int.Parse(txtFecEst.Text),
                Direccion = txtDirDoc.Text,
                Numero_celular = int.Parse(txtTelEst.Text),
                Codigo_Estudiantil = txtCodEst.Text,


            });

        }

        private void btnMosEst_Click(object sender, EventArgs e)
        {
            dgvEstudiante.DataSource = null;
            dgvEstudiante.DataSource = Datos_Estudiante;
        }

        private void btnLimpEst_Click(object sender, EventArgs e)
        {
            txtNomEst.Clear();
            txtApeEst.Clear();
            txtFecEst.Clear();
            txtTelEst.Clear();
            txtCodEst.Clear();
            txtDirEst.Clear();
        }

        private void btnGuardarDoc_Click(object sender, EventArgs e)
        {
            Datos_Docentes.Add(new Docente
            {
                Nombre = txtNomDoc.Text,
                Apellido = txtApeDoc.Text,
                Direccion = txtDirDoc.Text,
                Fecha_Nacimiento = int.Parse(txtFecDoc.Text),
                Telefono = int.Parse(txtTelfDoc.Text),
                Codigo_Docente = txtCodDoc.Text,
            });
        }

        private void btnMostrarDoc_Click(object sender, EventArgs e)
        {
            dgvDocente.DataSource = null;
            dgvDocente.DataSource = Datos_Docentes;
        }

        private void btnLimpiarDoc_Click(object sender, EventArgs e)
        {
            txtNomDoc.Clear();
            txtApeDoc.Clear();
            txtFecDoc.Clear();
            txtTelfDoc.Clear();
            txtCodDoc.Clear();
            txtDirDoc.Clear();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            Datos_Matricula.Add(new Matricula
            {
                Nombre_Estudiante = txtNomb.Text,
                Nombre_Docente = txtNomb1.Text,
                CDEstudiante = txtCodigo1.Text,
                CDDocente = txtCodigo2.Text,
                Asignatura = txtAsignatura.Text,
                Nota = int.Parse(txtNota.Text),

            });
        }

        private void btnMostraMatricula_Click(object sender, EventArgs e)
        {
            dgvMatricula.DataSource = null;
            dgvMatricula.DataSource = Datos_Matricula;
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            var busqueda = Datos_Matricula
                .OfType<Matricula>()
                .GroupBy(nota => nota.Nota)
                .OrderByDescending(mayor => mayor.Count() >= 60)
                .FirstOrDefault();




            if (busqueda != null)
            {
                var CantMayor = busqueda.Count();

                txtResult1.Text = CantMayor.ToString();

            }

            var busqueda2 = Datos_Matricula
                .OfType<Matricula>()
                .GroupBy(nota => nota.Nota)
                .OrderByDescending(mayor => mayor.Count() <= 60)
                .FirstOrDefault();




            if (busqueda2 != null)
            {
                var CantMenor = busqueda2.Count();

                txtResult2.Text = CantMenor.ToString();

            }



        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNomb.Clear();
            txtNomb1.Clear();
            txtNota.Clear();
            txtAsignatura.Clear();
            txtCodigo1.Clear();
            txtCodigo2.Clear();
        }
    }
}
