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
    public partial class frmEmitirPredica : Form
    {
        public frmEmitirPredica()
        {
            InitializeComponent();
        }
        clsMensaje_Predica oMensaje;
        private void btnCrearMensaje_Click(object sender, EventArgs e)
        {
            bool x = true;
            if (tbTitulo.Text == "")
            {
                tbTitulo.BackColor = Color.Red;
                x = false;
            }

            if (tbVersiculos.Text == "")
            {
                tbVersiculos.BackColor = Color.Red;
                x = false;
            }

            if (rtbMensaje.Text == "")
            {
                rtbMensaje.BackColor = Color.Red;
                x = false;
            }

            if (x)
            {
                string res = "";
                oMensaje = new clsMensaje_Predica();
                oMensaje.Titulo = tbTitulo.Text;
                oMensaje.Versiculos = tbVersiculos.Text;
                oMensaje.Texto_mensaje = rtbMensaje.Text;
                oMensaje.Fecha_emitido = DateTime.Today.Date;
                res = oMensaje.AgregarMensaje();
                if (res == "")
                {
                    MessageBox.Show("Prédica correctamente enviada");
                    btnCrearMensaje.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Llene los correspondientes campos");
            }
       

            
            
        }

        private void tbTitulo_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                (sender as TextBox).BackColor = Color.White;
            }
            if (sender is RichTextBox)
            {
                (sender as RichTextBox).BackColor = Color.White;
            }
        }
    }
}
