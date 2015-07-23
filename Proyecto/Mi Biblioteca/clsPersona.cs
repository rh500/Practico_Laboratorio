using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Mi_Biblioteca
{
    public class clsPersona
    {
        //private SqlConnection sqlConexion;
        private clsBaseDatos oBase;

        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private int codigo_grupo;

        public int Codigo_grupo
        {
            get { return codigo_grupo; }
            set { codigo_grupo = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private DateTime fecha_nacimiento;

        public DateTime Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int es_pareja;

        public int Es_pareja
        {
            get { return es_pareja; }
            set { es_pareja = value; }
        }
        private int eliminado;

        public int Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public clsPersona()
        {
            oBase = new clsBaseDatos();
        }

        public DataTable listarPersonas()
        {
            DataTable dtPersonas = new DataTable("personas");
            dtPersonas = oBase.Consultar("sp_ListarPersonas", null);
            return dtPersonas;
        }

        public string agregarPersona()
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[8];
            parametros[0] = new SqlParameter("@dni", SqlDbType.VarChar,8);
            parametros[1] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametros[2] = new SqlParameter("@nombre", SqlDbType.VarChar, 20);
            parametros[3] = new SqlParameter("@apellido", SqlDbType.VarChar, 20);
            parametros[4] = new SqlParameter("@telefono", SqlDbType.VarChar, 30);
            parametros[5] = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
            parametros[6] = new SqlParameter("@direccion", SqlDbType.VarChar, 30);
            parametros[7] = new SqlParameter("@es_pareja", SqlDbType.Int);
            parametros[0].Value = dni;
            parametros[1].Value = codigo_grupo;
            parametros[2].Value = nombre;
            parametros[3].Value = apellido;
            parametros[4].Value = telefono;
            parametros[5].Value = fecha_nacimiento;
            parametros[6].Value = direccion;
            parametros[7].Value = es_pareja;
            res = oBase.Actualizar("sp_Agregar_Persona", parametros);
            return res;
        }

        public string modificarPersona(string dni)
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[8];
            parametros[0] = new SqlParameter("@dni", SqlDbType.VarChar,8);
            parametros[1] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametros[2] = new SqlParameter("@nombre", SqlDbType.VarChar, 20);
            parametros[3] = new SqlParameter("@apellido", SqlDbType.VarChar, 20);
            parametros[4] = new SqlParameter("@telefono", SqlDbType.VarChar, 30);
            parametros[5] = new SqlParameter("@fecha_nacimiento", SqlDbType.DateTime);
            parametros[6] = new SqlParameter("@direccion", SqlDbType.VarChar, 10);
            parametros[7] = new SqlParameter("@es_pareja", SqlDbType.Int);
            parametros[0].Value = dni;
            parametros[1].Value = codigo_grupo;
            parametros[2].Value = nombre;
            parametros[3].Value = apellido;
            parametros[4].Value = telefono;
            parametros[5].Value = fecha_nacimiento;
            parametros[6].Value = direccion;
            parametros[7].Value = es_pareja;
            res = oBase.Actualizar("sp_Modificar_Persona", parametros);
            return res;
        }

        public string eliminarPersona(string dni_param)
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@dni", SqlDbType.VarChar,8);
            parametros[0].Value = dni_param;
            res = oBase.Actualizar("sp_Eliminar_Persona", parametros);
            return res;
        }

        public DataTable listarIntegrantes(int codigo_grupo)
        {
            DataTable dtIntegrantes = new DataTable("datos");
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametro[0].Value = codigo_grupo;
            dtIntegrantes = oBase.Consultar("sp_ListarIntegrantes", parametro);
            return dtIntegrantes;
        }

    }
}
