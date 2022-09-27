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
    public partial class Carrera : Form
    {

        string table = "carreras";
        Controlador cn = new Controlador();

        public Carrera()
        {
            InitializeComponent();
        }

        public void checkbox()
        {
            if (checkBox1.Checked)
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
        }

        public void limpiar()
        {

            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtEstado.Text = "";
        }

        public void Actualizar()
        {
            //string idUsuario = txtCodigoMestro.Text;
            //cn.llenarListApliUsuariosstring(listMaestro.Tag.ToString(), listMaestro, idUsuario);
        }

        public void IngresarData()
        {
            DataTable dt = cn.llenarTbl(table);
            listMaestro.DataSource = dt;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = {txtNombre, txtDireccion ,txtEstado }; 
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Actualizar();
            limpiar();
            MessageBox.Show(message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtNombre, txtDireccion, txtEstado };
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "codigo_carrera = ";
            cn.actualizar(textbox, table, campo, valor1);
            IngresarData();
        }

        private void listMaestro_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
                    string condicion = "codigo_maestro = ";
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

        private void Carrera_Load(object sender, EventArgs e)
        {
            IngresarData();
            txtEliminar.Visible = false;
            txtEstado.Visible = false;
        }
    }
}
