using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;


namespace CapaVista
{
    public partial class AsignacionCursoMaestro : Form
    {
        string table = "asignacioncursosmastros";
        Controlador cn = new Controlador();
        public AsignacionCursoMaestro()
        {
            InitializeComponent();
        }

        public void checkbox()
        {
        }

        public void limpiar()
        {

            txtIdAsignacion.Text = "";
            txtCarrera.Text = "";
            txtIdAsignacion.Text = "";
            txtIdAsignacion.Text = "";
            txtMaestro.Text = "";
            txtSede.Text = "";
        }

        public void Actualizar()
        {
            /*string idUsuario = txtIdAsignacion.Text;
            cn.llenarListApliUsuariosstring(ListAsignacion.Tag.ToString(), ListAsignacion, idUsuario);*/
            DataTable dt = cn.llenarTbl(table);
            ListAsignacion.DataSource = dt;
        }

        public void IngresarData()
        {
            DataTable dt = cn.llenarTbl(table);
            ListAsignacion.DataSource = dt;
        }


        private void ListUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = ListCarrera.CurrentCell.Value.ToString();
                txtCarrera.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtIdAsignacion, txtCarrera, txtSede, txtAula, txtCurso, txtMaestro };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Actualizar();
            limpiar();
            MessageBox.Show(message);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListaSede.VirtualMode = false;
            ListaAula.Visible = false;
            listMaestro.Visible = false;
            ListCurso.Visible = false;
            ListCarrera.Visible = true;
        }

        private void AsignacionCursoMaestro_Load(object sender, EventArgs e)
        {
            DataTable dt = cn.llenarTbl("carreras");
            ListCarrera.DataSource = dt;
            //2
            DataTable dt2 = cn.llenarTbl("sedes");
            ListaSede.DataSource = dt2;
            //Size = new Size(657, 588);
            //3
            DataTable dt3 = cn.llenarTbl("aulas");
            ListaAula.DataSource = dt3;
            //Size = new Size(657, 588);
            //4
            DataTable dt4 = cn.llenarTbl("maestros");
            listMaestro.DataSource = dt4;
            //Size = new Size(657, 588);
            //5
            DataTable dt5 = cn.llenarTbl("cursos");
            ListCurso.DataSource = dt5;
            //Size = new Size(657, 588);
            IngresarData();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            ListCarrera.Visible = false;
            ListaAula.Visible = false;
            listMaestro.Visible = false;
            ListCurso.Visible = false;
            ListaSede.Visible = true;

        }

        private void ListaSede_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = ListaSede.CurrentCell.Value.ToString();
                txtSede.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListCarrera.Visible = false;
            ListaSede.VirtualMode = false;
            listMaestro.Visible = false;
            ListCurso.Visible = false;

            ListaAula.Visible = true;
        }

        private void ListaAula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = ListaAula.CurrentCell.Value.ToString();
                ListaAula.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListCarrera.Visible = false;
            ListaSede.VirtualMode = false;
            ListaAula.Visible = false;
            listMaestro.Visible = false;
            ListCurso.Visible = true;
        }

        private void ListCurso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = ListCurso.CurrentCell.Value.ToString();
                txtCurso.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        private void listMaestro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = listMaestro.CurrentCell.Value.ToString();
                txtCurso.Text = dato;
            }
            catch (Exception ex)
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListCarrera.Visible = false;
            ListaSede.VirtualMode = false;
            ListaAula.Visible = false;
            ListCurso.Visible = false;
            listMaestro.Visible = true;
        }

        private void ListaAula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListAsignacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string dato;
                dato = listMaestro.CurrentCell.Value.ToString();
                txtEliminar.Text = dato;


                string message = "Deseas Eliminar el Registro?";
                string title = "Eliminar Registro";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    //int campo = int.Parse(txtBusacar.Text);
                    string condicion = "codigo_asignacion = ";
                    cn.eliminar(table, condicion, Int32.Parse(dato));
                    IngresarData();
                    //this.Close();
                }
                else
                {
                    limpiar();
                    //this.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
