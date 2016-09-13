using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Dental_White.DAL.Persistence
{
    /// <summary>
    /// Classe de Conexão ao Banco de Dados da Dental White.
    /// </summary>
    public class ConexaoDentalWhite
    {
        protected SqlConnection ConDB;
        protected SqlCommand CmdDB;
        protected SqlDataReader DrDB;
        protected SqlTransaction TrDB;

        /// <summary>
        /// Método para Abrir Conexão ao Banco de Dados da Dental White.
        /// </summary>
        protected void OpenDBDentalWhite()
        {
            try
            {
                ConDB = new SqlConnection(ConfigurationManager.ConnectionStrings["DBDentalWhite"].ConnectionString);
                ConDB.Open();
            }
            catch(InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o erro a seguir: " + ex.Message);
            }
            catch(SqlException ex)
            {
                throw new Exception("Ocorreu o erro a seguir: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
        /// <summary>
        /// Método para Fechar Conexão ao Banco de Dados da Dental White.
        /// </summary>
        protected void CloseDBDentalWhite()
        {
            try
            {
                ConDB.Close();
            }
            catch(SqlException ex)
            {
                throw new Exception("Ocorreu o erro a seguir: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}