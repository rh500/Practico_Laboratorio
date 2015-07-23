using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mi_Biblioteca;

namespace Proyecto_Laboratorio
{
    public partial class frmLlenarFormulario : Form
    {
        public frmLlenarFormulario()
        {
            InitializeComponent();
        }

        clsFormulario oFormulario;
        clsMensaje_Predica oMensaje;
        private void frmLlenarFormulario_Load(object sender, EventArgs e)
        {
            oMensaje = new clsMensaje_Predica();
            oMensaje.MensajeReciente();
            rtbTitulo.Text = oMensaje.Titulo;
            rtbVersiculos.Text = oMensaje.Versiculos;
            rtbMensaje.Text = oMensaje.Texto_mensaje;
            cbxOfrenda.SelectedIndex = 0;
            cbxTipo.SelectedIndex = 1;
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            frmVisorFormulario formVisorFormulario;
            bool x = true;
            string res = "";

            if (cbxTipo.SelectedItem == null)
            {
                cbxTipo.BackColor = Color.Red;
                x = false;
            }
            if (tbDiaCelula.Text == "")
            {
                tbDiaCelula.BackColor = Color.Red;
                x = false;
            }

            if (cbxOfrenda.SelectedIndex == 2)
            {
                if (tbMonto.Text == "")
                {
                    x = false;
                }
            }
            if (!dtpFechaLlenado.Checked)
            {
                x = false;
            }

            if (tbDireccion.Text == "")
            {
                tbDireccion.BackColor = Color.Red;
                x = false;
            }
            if (cbxOfrenda.SelectedItem.ToString() == "Si")
            {
                if (tbMonto.Text == "")
                {
                    tbMonto.BackColor = Color.Red;
                    x = false;
                }
            }
            else
            {
                tbMonto.Text = "0";
            }
           
            //LLENAR EL FORMULARIO
            if (x)
            {
                oFormulario = new clsFormulario();
                oFormulario.Fecha_llenado = dtpFechaLlenado.Value.Date;
                oFormulario.Tipo = cbxTipo.SelectedItem.ToString();
                oFormulario.Dia_celula = tbDiaCelula.Text;
                oFormulario.Direccion = tbDireccion.Text;
                oFormulario.Monto = Convert.ToDouble(tbMonto.Text);
                if (rtbMensajeConsideracion.Text != "")
                {
                    oFormulario.Mensaje_consideracion = rtbMensajeConsideracion.Text;
                }
                oFormulario.Codigo_grupo = clsUtilidades.codigoGrupo;
                oFormulario.ID_mensaje = oMensaje.ID_mensaje;
                res = oFormulario.agregarFormulario();
                if (res == "")
                {
                    MessageBox.Show("Formulario correctamente enviado");
                    btnEnviar.Enabled = false;
                    if (MessageBox.Show("Desea visualizar el formulario?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        formVisorFormulario = new frmVisorFormulario();
                        formVisorFormulario.id_mensaje = oMensaje.ID_mensaje;
                        formVisorFormulario.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor llene los campos correspondientes");
            }
            
        }

        private void cbxOfrenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Combobox de Ofrenda
            if (cbxOfrenda.SelectedIndex == 1)
            {
                lblMonto.Visible = true;
                tbMonto.Visible = true;
            }
            else
            {
                lblMonto.Visible = false;
                tbMonto.Visible = false;
            }
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tbDiaCelula_Enter(object sender, EventArgs e)
        {
           (sender as TextBox).BackColor = Color.White;
        }
    }
}
