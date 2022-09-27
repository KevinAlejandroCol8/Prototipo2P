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
    public partial class Facultades : Form
    {
        string table = "facultades";
        Controlador cn = new Controlador();
        public Facultades()
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

            txtNombre.Text = "";
            txtEstado.Text = "";
            txtIDfacultad.Text = "";
        }

        public void Actualizar()
        {
            /*string idUsuario = txtIDfacultad.Text;
            cn.llenarTablas(listMaestro.Tag.ToString(), listMaestro);*/
            DataTable dt = cn.llenarTbl(table);
            listMaestro.DataSource = dt;
        }

        public void IngresarData()
        {
            DataTable dt = cn.llenarTbl(table);
            listMaestro.DataSource = dt;
        }

        private void listMaestro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtIDfacultad,txtNombre,  txtEstado  };
            cn.ingresar(textbox, table);
            string message = "Registro Guardado";
            Actualizar();
            limpiar();
            MessageBox.Show(message);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkbox();
            TextBox[] textbox = { txtIDfacultad, txtNombre, txtEstado };
            int valor1 = int.Parse(txtBusacar.Text);
            string campo = "codigo_facultad = ";
            cn.actualizar(textbox, table, campo, valor1);
            IngresarData();
        }

        private void listMaestro_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

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
                    string condicion = "codigo_facultad = ";
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

        private void Facultades_Load(object sender, EventArgs e)
        {
            IngresarData();
            txtEstado.Visible = false;
            txtEliminar.Visible = false;
        }
    }
}
