using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Biblioteca
{
    public class clsMensaje_Predica
    {
        private clsBaseDatos oBase;

        private int id_mensaje;

        public int ID_mensaje
        {
            get { return id_mensaje; }
            set { id_mensaje = value; }
        }
        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        private string versiculos;

        public string Versiculos
        {
            get { return versiculos; }
            set { versiculos = value; }
        }
        private string texto_mensaje;

        public string Texto_mensaje
        {
            get { return texto_mensaje; }
            set { texto_mensaje = value; }
        }
        private DateTime fecha_emitido;

        public DateTime Fecha_emitido
        {
            get { return fecha_emitido; }
            set { fecha_emitido = value; }
        }

        public clsMensaje_Predica()
        {
            oBase = new clsBaseDatos();
        }

        public DataTable ListarMensajes()
        {
            DataTable dtMensajes = new DataTable("mensajes_predica");
            dtMensajes = oBase.Consultar("sp_ListarMensajes", null);
            return dtMensajes;
        }

        public void MensajeReciente()
        {
            DataTable dtMensaje = new DataTable("mensaje_predica");
            dtMensaje = oBase.Consultar("sp_MensajeReciente", null);
            id_mensaje = Convert.ToInt32(dtMensaje.Rows[0]["id_mensaje"].ToString());
            titulo = dtMensaje.Rows[0]["titulo"].ToString();
            versiculos = dtMensaje.Rows[0]["versiculos"].ToString();
            texto_mensaje = dtMensaje.Rows[0]["texto_mensaje"].ToString();
            fecha_emitido = Convert.ToDateTime(dtMensaje.Rows[0]["fecha_emitido"].ToString());
        }

        public string AgregarMensaje()
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[4];
            parametros[0] = new SqlParameter("@titulo", SqlDbType.VarChar, 60);
            parametros[1] = new SqlParameter("@versiculos", SqlDbType.VarChar, 10);
            parametros[2] = new SqlParameter("@texto_mensaje", SqlDbType.VarChar, 300);
            parametros[3] = new SqlParameter("@fecha_emitido", SqlDbType.DateTime);
            parametros[0].Value = titulo;
            parametros[1].Value = versiculos;
            parametros[2].Value = texto_mensaje;
            parametros[3].Value = fecha_emitido;
            res = oBase.Actualizar("sp_AgregarMensajePredica", parametros);
            return res;
        }

        public bool HayMensaje()
        {
            bool hay = false;
            DataTable dtMensaje = new DataTable("hay_mensaje");
            dtMensaje = oBase.Consultar("sp_MensajeReciente",null);
            if (dtMensaje.Rows.Count != 0)
            {
                hay = true;
            }
            return hay;
        }
    }
}
