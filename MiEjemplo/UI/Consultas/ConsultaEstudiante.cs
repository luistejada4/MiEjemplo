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

namespace MiEjemplo.UI.Consultas
{
    public partial class ConsultaEstudiante : Form
    {
        public ConsultaEstudiante()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Estudiantes> estudiantes = new List<Estudiantes>();
            var db = new DAL.MiEjemploDB();
            estudiantes = db.Estudiantes.ToList();
            dataGridView1.DataSource = estudiantes;

        }
    }
}
