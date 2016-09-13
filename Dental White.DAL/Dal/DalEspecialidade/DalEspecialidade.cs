using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Especialidade;
using Dental_White.DAL.Persistence;

namespace Dental_White.DAL.Dal.DalEspecialidade
{
    public class DalEspecialidade : ConexaoDentalWhite
    {
        public List<EntityEspecialidade> GetEspecialidadeByNome()
        {
            string query1 = "select IdEspecialidade, Nome from TBEspecialidade";
            try
            {
                base.OpenDBDentalWhite();
                CmdDB = new SqlCommand(query1, ConDB);
                DrDB = CmdDB.ExecuteReader();
                List<EntityEspecialidade> listaEspecialidade = new List<EntityEspecialidade>();
                while (DrDB.Read())
                {
                    EntityEspecialidade entityEspecialidade = new EntityEspecialidade();
                    entityEspecialidade.IdEspecialidade = Convert.ToInt32(DrDB["IdEspecialidade"]);
                    entityEspecialidade.Nome = Convert.ToString(DrDB["Nome"]);
                    listaEspecialidade.Add(entityEspecialidade);
                }
                return listaEspecialidade;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                query1 = null;
                base.CloseDBDentalWhite();
            }
        }
        public EntityEspecialidade GetDataEspecialidade(Int32 IdEspecialidade)
        {
            try
            {
                base.OpenDBDentalWhite();
                EntityEspecialidade entityEspecialidade = new EntityEspecialidade();

                CmdDB = new SqlCommand("spGetDataEspecialidade", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdEspecialidade", IdEspecialidade);
                DrDB = CmdDB.ExecuteReader();
                if(DrDB.Read())
                {
                    entityEspecialidade.Nome = Convert.ToString(DrDB["Nome"]);
                    entityEspecialidade.Descricao = Convert.ToString(DrDB["Descricao"]);
                }
                return entityEspecialidade;
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
    }
}