using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maestros b = new Maestros();
            b.MdiParent = this;
            b.Show();
        }

        private void aplicacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facultades b = new Facultades();
            b.MdiParent = this;
            b.Show();
        }

        private void módulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Carrera b = new Carrera();
            b.MdiParent = this;
            b.Show();
        }

        private void asignacionesDeAplicacionesAUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignacionCursoMaestro b = new AsignacionCursoMaestro();
            b.MdiParent = this;
            b.Show();
        }
    }
}
