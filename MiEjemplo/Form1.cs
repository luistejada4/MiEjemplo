using MiEjemplo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.MiEjemploDB db = new DAL.MiEjemploDB();
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudiantesID = 0;
            estudiante.Nombres = "Luis German";
            estudiante.Deudas = 200;
            db.Estudiantes.Add(estudiante);
            db.SaveChanges();

            UI.Consultas.ConsultaEstudiante consulta = new UI.Consultas.ConsultaEstudiante();
            consulta.Show();


            
        }
    }
}
