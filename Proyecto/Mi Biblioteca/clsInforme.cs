using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Mi_Biblioteca
{
    public  class clsInforme
    {
        private clsBaseDatos oBase;

        string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string texto;

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        private DateTime fecha_creacion;

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int codigo_grupo;

        public int Codigo_grupo
        {
            get { return codigo_grupo; }
            set { codigo_grupo = value; }
        }

        public clsInforme()
        {
            oBase = new clsBaseDatos();
        }

        public DataTable listarInformes()
        {
            DataTable dtInformes = new DataTable();
            dtInformes = oBase.Consultar("sp_ListarInformes", null);
            return dtInformes;
        }

        public string agregarInforme()
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("@titulo", SqlDbType.VarChar, 20);
            parametros[1] = new SqlParameter("@texto", SqlDbType.VarChar, 200);
            parametros[2] = new SqlParameter("@fecha_creacion", SqlDbType.DateTime);
            parametros[3] = new SqlParameter("@tipo", SqlDbType.VarChar, 10);
            parametros[4] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametros[0].Value = titulo;
            parametros[1].Value = texto;
            parametros[2].Value = fecha_creacion;
            parametros[3].Value = tipo;
            parametros[4].Value = codigo_grupo;
            res = oBase.Actualizar("sp_agregar_Informe", parametros);
            return res;
        }

        public DataTable listarInformes_Grupo(int codigo_grupo)
        {
            DataTable dtInformes = new DataTable();
            SqlParameter[] parametro = new SqlParameter[1];
            parametro[0] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametro[0].Value = codigo_grupo;
            dtInformes = oBase.Consultar("sp_Informes_Grupo", parametro);
            return dtInformes;
        }

        public DataTable listarInformes_Admin()
        {
            DataTable dtInformes = new DataTable();
            dtInformes = oBase.Consultar("sp_Informes_Admin", null);
            return dtInformes;
        }
    }
}
