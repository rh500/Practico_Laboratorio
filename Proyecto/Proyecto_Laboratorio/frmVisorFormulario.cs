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
    public partial class frmVisorFormulario : Form
    {
        public int id_mensaje;
        public frmVisorFormulario()
        {
            InitializeComponent();
        }

        private void frmVisorFormulario_Load(object sender, EventArgs e)
        {
            //crFormulario crystalFormulario = new crFormulario();
            //crystalFormulario.SetParameterValue("@codigo_grupo", clsUtilidades.codigoGrupo);
            //crystalFormulario.SetParameterValue("@id_mensaje", id_mensaje);
            //crvVisorFormulario.ReportSource = crystalFormulario;
        }
    }
}
