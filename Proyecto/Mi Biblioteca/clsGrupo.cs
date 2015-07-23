using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Mi_Biblioteca
{
    public class clsGrupo
    {
        private clsBaseDatos oBase;
        private SqlConnection sqlConexion;

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
        private string contraseña;

        public string Contraseña
        {
            get { return contraseña; }
            set { contraseña = value; }
        }
        private int eliminado;

        public int Eliminado
        {
            get { return eliminado; }
            set { eliminado = value; }
        }

        public clsGrupo()
        {
            oBase = new clsBaseDatos();
        }
        
        public DataTable listarGrupos()
        {
            DataTable dtGrupos = new DataTable("grupos");
            dtGrupos = oBase.Consultar("sp_ListarGrupos", null);
            return dtGrupos;
        }

        public string agregarGrupo()
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@nombre", SqlDbType.VarChar, 15);
            parametros[1] = new SqlParameter("@contrasena", SqlDbType.VarChar, 20);
            parametros[0].Value = nombre;
            parametros[1].Value = contraseña;
            res = oBase.Actualizar("sp_agregar_grupo", parametros);
            return res;
        }

        public string eliminarGrupo(int codigo_grupo)
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@codigo_grupo", SqlDbType.VarChar, 15);
            parametros[0].Value = codigo_grupo;
            res = oBase.Actualizar("sp_eliminar_grupo", parametros);
            return res;
        }

        public int buscarGrupo(string usu)
        {
            //SIRVE PARA BUSCAR EL CODIGO DEL GRUPO
            int codigo;
            DataTable dtGrupo = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@usuario", SqlDbType.VarChar, 15);
            parametro[0].Value = usu;
            dtGrupo = oBase.Consultar("sp_BuscarGrupo", parametro);
            codigo = Convert.ToInt32(dtGrupo.Rows[0]["codigo_grupo"].ToString());
            return codigo;
        }

        public bool HayFormulario(int codigo_grupo)
        {
            bool tiene = false;
            DataTable dtGrupo = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametro[0].Value = codigo_grupo;
            dtGrupo = oBase.Consultar("sp_Hay_Formulario", parametro);
            if (dtGrupo.Rows.Count != 0)
            {
                tiene = true;
            }
            return tiene;
        }
        public DataTable listarGrupos_SIN()
        {
            DataTable dtGrupos = new DataTable("grupos");
            dtGrupos = oBase.Consultar("sp_ListarGrupos_SinPareja", null);
            return dtGrupos;
        }
        public DataTable listarGrupos_No_Formulario()
        {
            DataTable dtGrupos = new DataTable("grupos");
            dtGrupos = oBase.Consultar("sp_Grupo_No_Formulario", null);
            return dtGrupos;
        }

    }
}
