using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Persistence;

namespace Dental_White.DAL.Dal.DalDDD
{
    public class DalDDD : ConexaoDentalWhite
    {
        public List<EntityDDD> FindAllDDD()
        {
            string query1 = "select Sigla, DDD from TBDDD order by DDD";
            try
            {
                base.OpenDBDentalWhite();
                CmdDB = new SqlCommand(query1, ConDB);
                DrDB = CmdDB.ExecuteReader();
                List<EntityDDD> listaDDD = new List<EntityDDD>();
                while(DrDB.Read())
                {
                    EntityDDD EntityDDD = new EntityDDD();
                    EntityDDD.Sigla = Convert.ToString(DrDB["Sigla"]);
                    EntityDDD.DDD = Convert.ToInt16(DrDB["DDD"]);
                    listaDDD.Add(EntityDDD);
                }
                return listaDDD;
            }
            catch(InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(SqlException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                query1 = null;
                base.CloseDBDentalWhite();
            }
        }
        public List<EntityEndereco> FindAllUFEstado()
        {
            string query1 = "select Sigla, Estado from TBEstados";
            try
            {
                base.OpenDBDentalWhite();
                CmdDB = new SqlCommand(query1, ConDB);
                DrDB = CmdDB.ExecuteReader();
                List<EntityEndereco> listaUFEstado = new List<EntityEndereco>();
                while (DrDB.Read())
                {
                    EntityEndereco entityEndereco = new EntityEndereco();
                    entityEndereco.UF = Convert.ToString(DrDB["Sigla"]);
                    entityEndereco.Estado = Convert.ToString(DrDB["Estado"]);
                    listaUFEstado.Add(entityEndereco);
                }
                return listaUFEstado;
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
    }
}