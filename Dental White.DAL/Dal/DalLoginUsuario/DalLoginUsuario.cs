using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Persistence;
using Dental_White.DAL.Util.Criptografia;

namespace Dental_White.DAL.Dal.DalLoginUsuario
{
    public class DalLoginUsuario : ConexaoDentalWhite
    {
        /// <summary>
        /// Método que pesquisa se um Usuário está ou não cadastrado no sistema.
        /// </summary>
        /// <param name="LoginUsuario">Recebe um objeto do tipo LoginUsuario.</param>
        /// <returns>Retorna verdadeiro se o usuário pesquisado está cadastrado no sistema ou falso se o usuário ainda não possue cadastro no sistema.</returns>
        public bool FindUsuarioInserted(EntityLoginUsuario LoginUsuario)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindUsuarioInserted", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", LoginUsuario.Login);
                CmdDB.Parameters.AddWithValue("@Senha", UtilCriptografia.EncriptarSenha(LoginUsuario.Senha));
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    DrDB.Close();
                    resultado = true;
                }
                else
                {
                    DrDB.Close();
                    resultado = false;
                }
                return resultado;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("Login já existe. Por favor tente outro.");
                }
                else
                {
                    throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

        /// <summary>
        /// Método que pesquisa se um Login está ou não cadastrado no sistema.
        /// </summary>
        /// <param name="login">Recebe um parâmetro login do tipo string</param>
        /// <returns>Retorna verdadeiro se o login pesquisado está cadastrado no sistema ou falso se o login ainda não possue cadastro no sistema.</returns>
        public bool FindLoginUsuarioExists(string login)
        {
            try
            {
                int resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindLoginUsuarioExists", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", login);
                DrDB = CmdDB.ExecuteReader();
                if(DrDB.Read())
                {
                    DrDB.Close();
                    DrDB.Dispose();
                    return true;
                }
                else
                {
                    DrDB.Close();
                    DrDB.Dispose();
                    return false;
                }
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
                base.CloseDBDentalWhite();
            }
        }
        public bool FindSenhaUsuarioExists(EntityLoginUsuario entityLoginUsuario)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindSenhaUsuarioExists", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityLoginUsuario.Login);
                CmdDB.Parameters.AddWithValue("@Perfil", entityLoginUsuario.Perfil);
                CmdDB.Parameters.AddWithValue("@IdLogin", entityLoginUsuario.IdLogin);
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    DrDB.Close();
                    resultado = true;
                }
                else
                {
                    DrDB.Close();
                    resultado = false;
                }
                return resultado;
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
        public EntityLoginUsuario FindUsuarioByLoginSenha(EntityLoginUsuario entityLoginUsuario)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindUsuarioByLoginSenha", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityLoginUsuario.Login);
                CmdDB.Parameters.AddWithValue("@Senha", UtilCriptografia.EncriptarSenha(entityLoginUsuario.Senha));
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    entityLoginUsuario.Login = Convert.ToString(DrDB["Login"]);
                    entityLoginUsuario.Senha = Convert.ToString(DrDB["Senha"]);
                    entityLoginUsuario.DataCadastro = Convert.ToDateTime(DrDB["DataCadastro"]);
                    entityLoginUsuario.Perfil = Convert.ToString(DrDB["Perfil"]);
                    return entityLoginUsuario;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("Login já existe. Por favor tente outro.");
                }
                else
                {
                    throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
        public string FindTipoPerfilByLogin(string login)
        {
            try
            {
                string tipoPerfil;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindTipoPerfilByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", login);
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    tipoPerfil = Convert.ToString(DrDB["TipoPerfil"]);
                    return tipoPerfil;
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("Login já existe. Por favor tente outro.");
                }
                else
                {
                    throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
                }
            }
            catch (InvalidOperationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }

        /// <summary>
        /// Método que cadastra um usuário no sistema.
        /// </summary>
        /// <param name="LoginUsuario">Recebe um objeto do tipo LoginUsuário.</param>
        public void InsertLoginUsuario(EntityLoginUsuario entityLoginUsuario)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertLoginUsuario", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityLoginUsuario.Login);
                CmdDB.Parameters.AddWithValue("@Senha", UtilCriptografia.EncriptarSenha(entityLoginUsuario.Senha));
                CmdDB.Parameters.AddWithValue("@DataCadastro", entityLoginUsuario.DataCadastro);
                CmdDB.Parameters.AddWithValue("@Perfil", entityLoginUsuario.Perfil);
                CmdDB.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                if(ex.Number == 2627)
                {
                    throw new Exception("Login já existe. Por favor tente outro.");
                }
                else
                {
                    throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool UpdateTipoPerfilUsuario(EntityLoginUsuario entityLoginUsuario)
        {
            try
            {
                Int16 resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdateTipoPerfilUsuario", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityLoginUsuario.Login);
                CmdDB.Parameters.AddWithValue("@TipoPerfil", entityLoginUsuario.TipoPerfil);
                resultado = Convert.ToByte(CmdDB.ExecuteNonQuery());
                if(resultado > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    throw new Exception("Login já existe. Por favor tente outro.");
                }
                else
                {
                    throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
                }
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