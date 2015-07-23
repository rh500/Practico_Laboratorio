using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Mi_Biblioteca;
using System.Data.SqlClient;

namespace Proyecto_Laboratorio
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void ctrUsu_Login1_Conexion_Exitosa(object cnx, string usu)
        {
            clsUtilidades.sqlConexion = (cnx as SqlConnection);
            MessageBox.Show("Conexion Exitosa '" + usu+"'");
            if (usu == "admin")
            {
                
                frmAdministradorPrincipal formAdministrador = new frmAdministradorPrincipal();
                formAdministrador.ShowDialog();
                
            }
            else
            {
                clsGrupo oGrupo = new clsGrupo();
                clsUtilidades.codigoGrupo = oGrupo.buscarGrupo(usu);
                frmGrupoPrincipal formGrupo = new frmGrupoPrincipal();
                formGrupo.ShowDialog();
            }
        }

        private void ctrUsu_Login1_Conexion_Fallida(object cnx, string usu)
        {
            MessageBox.Show("Error en la Conexion");
        }

      
        


        

    }
}
