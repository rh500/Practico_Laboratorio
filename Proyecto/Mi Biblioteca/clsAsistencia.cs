using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Biblioteca
{
    public class clsAsistencia
    {
        private clsBaseDatos oBase;
        private string dni;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        private int id_mensaje;

        public int ID_mensaje
        {
            get { return id_mensaje; }
            set { id_mensaje = value; }
        }

        private int asistio;

        public int Asistio
        {
            get { return asistio; }
            set { asistio = value; }
        }

        private DateTime fecha_creacion;

        public DateTime Fecha_creacion
        {
            get { return fecha_creacion; }
            set { fecha_creacion = value; }
        }

        public clsAsistencia()
        {
            oBase = new clsBaseDatos();
        }

        public DataTable listarAsistencias(int codigo_grupo)
        {
            DataTable dtAsistencias = new DataTable("asistencias");
            SqlParameter[] parametros = new SqlParameter[1];
            parametros[0] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametros[0].Value = codigo_grupo;
            dtAsistencias = oBase.Consultar("sp_Listar_asistencias", parametros);
            return dtAsistencias;
        }

        public string agregarAsistencia(int idformulario)
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@dni", SqlDbType.VarChar, 10);
            parametros[1] = new SqlParameter("@id_mensaje", SqlDbType.Int);
            parametros[2] = new SqlParameter("@asistio", SqlDbType.Int);
            parametros[3] = new SqlParameter("@fecha_creacion", SqlDbType.DateTime);
            parametros[0].Value = dni;
            parametros[1].Value = idformulario;
            parametros[2].Value = asistio;
            parametros[3].Value = fecha_creacion;
            res = oBase.Actualizar("sp_Agregar_Asistencia", parametros);
            return res;
        }

        
    }
}
