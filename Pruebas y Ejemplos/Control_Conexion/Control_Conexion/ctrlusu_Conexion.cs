using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Control_Conexion
{
    public partial class ctrlusu_Conexion : UserControl
    {
        public ctrlusu_Conexion()
        {
            InitializeComponent();
        }

        /*VARIABLES Y PROPIEDADES*/
        private SqlConnection sqlConexion;

        private string base_datos;
        public string BASEDEDATOS
        {
            get { return base_datos; }
            set { base_datos = value; }
        }

        private string servidor;
        public string SERVIDOR
        {
            get { return servidor; }
            set { servidor = value; }
        }
        string str_conexion;
        
        /****************/
        
        /*EVENTOS*/
        public delegate void del_Conexion (SqlConnection cnx);
        public event del_Conexion Conexion_Exitosa;
        public event del_Conexion Conexion_Fallida;
        /*********/

        private void btn_Conexion_Click(object sender, EventArgs e)
        {
            if (tbx_Usuario.Text != "" && tbx_Contraseña.Text != "")
            {//usuario o contraseña vacios
                if (servidor != "" && base_datos != "")
                {
                    try
                    {
                        if (Conectar_Usu(tbx_Usuario.Text, tbx_Contraseña.Text))
                        {

                            if (Conexion_Exitosa != null)
                            {
                                Conexion_Exitosa(sqlConexion);
                            }
                        }
                        else
                        {
                            if (Conexion_Fallida != null)
                            {
                                Conexion_Fallida(sqlConexion);
                            }
                        }

                    }
                        //esto es mas como para mí, lo del mensaje de la excepcion
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor llena las PROPIEDADES!");
                }
            }
            else
            {
                MessageBox.Show("Por Favor llene los campos");
            }
            
        }

        public bool Conectar_Usu(string nombre, string contraseña)
        {
            sqlConexion = new SqlConnection();
            sqlConexion.ConnectionString = "Data Source= " + servidor + ";Initial Catalog= " + base_datos + ";Integrated Security=True";
            string comando_texto = "dbo.sp_Conectar_Grupo '" + nombre + "' , '" + contraseña + "'";
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexion;
            sqlComando.CommandType = System.Data.CommandType.Text;
            sqlComando.CommandText = comando_texto;

            //ACA PRUEBO SI ANDA Y SI TRAE ALGUNA FILA!
            try
            {
                sqlConexion.Open();
                SqlDataReader sqlReader = sqlComando.ExecuteReader();
                return sqlReader.HasRows;
            }
            catch (Exception ex)
            {
                string error = ex.Message;
                return false;
            }
        }

        
    }
}
