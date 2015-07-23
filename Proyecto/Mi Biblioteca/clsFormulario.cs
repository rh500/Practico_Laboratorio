using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Mi_Biblioteca
{
    public class clsFormulario
    {
        private clsBaseDatos oBase;

        private int id_formulario;
        public int ID_Formulario
        {
            get { return id_formulario; }
        }
        private string tipo;
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        private DateTime fecha_llenado;

        public DateTime Fecha_llenado
        {
            get { return fecha_llenado; }
            set { fecha_llenado = value; }
        }
        private string dia_celula;

        public string Dia_celula
        {
            get { return dia_celula; }
            set { dia_celula = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private int es_ofrenda;

        public int Es_ofrenda
        {
            get { return es_ofrenda; }
            set { es_ofrenda = value; }
        }
        private double monto;

        public double Monto
        {
            get { return monto; }
            set { monto = value; }
        }
        private string mensaje_consideracion = "";

        public string Mensaje_consideracion
        {
            get { return mensaje_consideracion; }
            set { mensaje_consideracion = value; }
        }
        private int codigo_grupo;

        public int Codigo_grupo
        {
            get { return codigo_grupo; }
            set { codigo_grupo = value; }
        }

        private int id_mensaje;

        public int ID_mensaje
        {
            get { return id_mensaje; }
            set { id_mensaje = value; }
        }
        
        public clsFormulario()
        {
            oBase = new clsBaseDatos();
        }

        public DataTable listarFormularios()
        {
            DataTable dtFormularios = new DataTable("formularios");
            dtFormularios = oBase.Consultar("sp_Listar_Formulario", null);
            return dtFormularios;
        }

        public string agregarFormulario()
        {
            
            string res = "";
            SqlParameter[] parametros = new SqlParameter[9];
            parametros[0] = new SqlParameter("@tipo", SqlDbType.VarChar, 30);
            parametros[1] = new SqlParameter("@fecha_llenado", SqlDbType.DateTime);
            parametros[2] = new SqlParameter("@dia_celula", SqlDbType.VarChar, 15);
            parametros[3] = new SqlParameter("@direccion", SqlDbType.VarChar, 60);
            parametros[4] = new SqlParameter("es_ofrenda", SqlDbType.Int);
            parametros[5] = new SqlParameter("@monto", SqlDbType.Float);
            parametros[6] = new SqlParameter("@mensaje_consideracion", SqlDbType.VarChar, 200);
            parametros[7] = new SqlParameter("@codigo_grupo", SqlDbType.Int);
            parametros[8] = new SqlParameter("@id_mensaje", SqlDbType.Int);
            parametros[0].Value = tipo;
            parametros[1].Value = fecha_llenado;
            parametros[2].Value = dia_celula;
            parametros[3].Value = direccion;
            parametros[4].Value = es_ofrenda;
            parametros[5].Value = monto;
            parametros[6].Value = mensaje_consideracion;
            parametros[7].Value = codigo_grupo;
            parametros[8].Value = id_mensaje;
            res = oBase.Actualizar("sp_agregar_formulario", parametros);
            return res;
        }

        public string modificarFormulario(int id_formulario)
        {
            string res = "";
            SqlParameter[] parametros = new SqlParameter[8];
            parametros[0] = new SqlParameter("@id_formulario", SqlDbType.Int);
            parametros[1] = new SqlParameter("@tipo", SqlDbType.VarChar, 30);
            parametros[2] = new SqlParameter("@fecha_llenado", SqlDbType.DateTime);
            parametros[3] = new SqlParameter("@dia_celula", SqlDbType.VarChar, 15);
            parametros[4] = new SqlParameter("@direccion", SqlDbType.VarChar, 60);
            parametros[5] = new SqlParameter("@es_ofrenda", SqlDbType.Char, 1);
            parametros[6] = new SqlParameter("@monto", SqlDbType.Float);
            parametros[7] = new SqlParameter("@mensaje_consideracion", SqlDbType.VarChar, 200);
            parametros[0].Value = id_formulario;
            parametros[1].Value = tipo;
            parametros[2].Value = fecha_llenado;
            parametros[3].Value = dia_celula;
            parametros[4].Value = direccion;
            parametros[5].Value = es_ofrenda;
            parametros[6].Value = monto;
            parametros[7].Value = mensaje_consideracion;
            res = oBase.Actualizar("sp_modificar_formulario", parametros);
            return res;
        }

        //public void FormularioReciente()
        //{
        //    DataTable dtFormulario = new DataTable("datos");
        //    dtFormulario = oBase.Consultar("sp_Formulario_Reciente", null);
        //    id_formulario = Convert.ToInt32(dtFormulario.Rows[0]["id_formulario"].ToString());
        //    titulo = dtFormulario.Rows[0]["titulo"].ToString();
        //    versiculos = dtFormulario.Rows[0]["versiculos"].ToString();
        //    mensaje_predica = dtFormulario.Rows[0]["mensaje_predica"].ToString();

        //}

        public DataTable listarFormularios_Mensaje_Grupo()
        {
            DataTable dtFormularios = new DataTable("formularios");
            dtFormularios = oBase.Consultar("sp_Listar_Formularios_Mensaje_Grupo", null);
            return dtFormularios;
        }

        public DataTable buscarFormulario_Mensaje(int id_mensaje, int codigo_grupo)
        {
            DataTable dtFormulario = new DataTable("formulario_mensaje");
            SqlParameter[] parametros = new SqlParameter[2];
            parametros[0] = new SqlParameter("@id_mensaje",SqlDbType.Int);
            parametros[1] = new SqlParameter("codigo_grupo", SqlDbType.Int);
            parametros[0].Value = id_mensaje;
            parametros[1].Value = codigo_grupo;
            dtFormulario = oBase.Consultar("sp_Buscar_Formulario_mensaje", parametros);
            return dtFormulario;
        }
    }
}
