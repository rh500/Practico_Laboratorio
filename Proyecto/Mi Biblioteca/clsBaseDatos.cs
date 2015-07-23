using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Mi_Biblioteca
{
    public class clsBaseDatos
    {
        
        private SqlConnection sqlConexion;

        public clsBaseDatos()
        {
            sqlConexion = new SqlConnection();
            sqlConexion = clsUtilidades.sqlConexion;
            sqlConexion.Close();
        }

        public DataTable Consultar(string procedimiento, SqlParameter[] parametros)
        {
            DataTable dt = new DataTable("datos");
            SqlDataAdapter sqlAdapter = new SqlDataAdapter();
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexion;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = procedimiento;
            if (parametros != null)
            {
                sqlComando.Parameters.AddRange(parametros);
            }
            try
            {
                sqlAdapter.SelectCommand = sqlComando;
                sqlAdapter.Fill(dt);
            }
            catch(SqlException ex)
            {
                dt = null;
            }
            sqlConexion.Close();
            return dt;
        }

        public string Actualizar(string procedimiento, SqlParameter[] parametros)
        {
            string res = "";
            SqlCommand sqlComando = new SqlCommand();
            sqlComando.Connection = sqlConexion;
            sqlComando.CommandType = CommandType.StoredProcedure;
            sqlComando.CommandText = procedimiento;
            if (parametros != null)
            {
                sqlComando.Parameters.AddRange(parametros);
            }
            try
            {
                sqlConexion.Open();
                sqlComando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                res = ex.Message;
            }
            sqlConexion.Close();
            return res;
        }


    }
}
