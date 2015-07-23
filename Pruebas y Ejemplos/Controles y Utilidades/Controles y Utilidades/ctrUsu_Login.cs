using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Controles_y_Utilidades
{
    public partial class ctrUsu_Login : UserControl
    {
        public ctrUsu_Login()
        {
            InitializeComponent();
        }

        private void ctrUsu_Login_Load(object sender, EventArgs e)
        {
            tb_Usuario.Focus();
        }


        /*VARIABLES Y PROPIEDADES*/
        private SqlConnection sqlConexion;
        private string basedatos;
        public string BASEDATOS
        {
            get { return basedatos; }
            set { basedatos = value; }
        }
        private string servidor;
        public string SERVIDOR
        {
            get { return servidor; }
            set { servidor = value; }
        }
        /************************/

        /*EVENTOS*/
        public delegate void delConexion(object cnx,string usu);
        public event delConexion Conexion_Exitosa;
        public event delConexion Conexion_Fallida;
        /************************/
        private void btn_Conectar_Click(object sender, EventArgs e)
        {
            if (tb_Usuario.Text != "" && tb_Contraseña.Text != "")
            {
                if ((servidor != "" && basedatos != "") && (servidor != null && basedatos != null))
                {
                    try
                    {
                        if (Conectar_Usu(tb_Usuario.Text, tb_Contraseña.Text) == "")
                        {
                            if (Conexion_Exitosa != null)
                                Conexion_Exitosa(sqlConexion,tb_Usuario.Text);
                        }
                        else
                        {
                            if (Conexion_Fallida != null)
                            {
                                Conexion_Fallida(sqlConexion,"null");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por Favor llena las PROPIEDADES");
                }
            }
            else
            {
                MessageBox.Show("Por Favor llena los campos");
            }
        }

        public string Conectar_Usu(string nombre, string contraseña)
        {
            string res = "null";
            sqlConexion = new SqlConnection();
            sqlConexion.ConnectionString = "Data Source= " + servidor + ";Initial Catalog= " + basedatos + ";Persist Security Info=True;User ID=sa;Password='250792'";
            string comando_texto = "dbo.sp_Conectar_Grupo '" + nombre + "' , '" + contraseña + "'";
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexion;
            sqlComando.CommandType = CommandType.Text;
            sqlComando.CommandText = comando_texto;

            try
            {
                sqlConexion.Open();
                SqlDataReader sqlreader = sqlComando.ExecuteReader();
                if (sqlreader.HasRows)
                {
                    res = "";
                    sqlreader.Close();
                    return res;
                }
            }
            catch(SqlException ex)
            {
                res = ex.Message;
                return res;
            }
            
            return res;
        }

       

    }
}
