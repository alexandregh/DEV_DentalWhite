using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Logradouro;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Dal.DalDDD;
using Dental_White.DAL.Dal.DalCadastroPaciente;
using Dental_White.DAL.Persistence;

namespace Dental_White.DAL.Dal.DalCadastroPaciente
{
    public class DalCadastroPaciente : ConexaoDentalWhite
    {
        /// <summary>
        /// Método que pesquisa se um Usuário está ou não cadastrado no sistema.
        /// </summary>
        /// <param name="LoginUsuario">Recebe um objeto do tipo LoginUsuario.</param>
        /// <returns>Retorna verdadeiro se o usuário pesquisado está cadastrado no sistema ou falso se o usuário ainda não possue cadastro no sistema.</returns>
        public bool FindPacienteByLogin(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteByNome(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteBySobrenome(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteBySobrenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteByDataNascimento(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByDataNascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteByEmail(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteByCPF(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }
        public bool FindPacienteByRG(EntityPaciente entityPaciente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Numero", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
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
            finally
            {
                base.CloseDBDentalWhite();
            }
        }


        public Int32 FindByIdCurrentPaciente(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindByIdCurrentPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    return (entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]));
                }
                else
                {
                    return 0;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindIdMyPaciente(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindIdMyPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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

        public EntityPaciente FindPacienteById_sByLogin(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sByNome(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sBySobrenome(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sBySobrenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sByDatanascimento(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByDatanascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sByEmail(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sByCPF(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_sByRG(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_sByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@RG", entityPaciente.RG.Numero);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Telefone = new EntityTelefone();
                    entityPaciente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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


        
        public EntityPaciente FindPacienteById_s(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_s", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Login = Convert.ToString(DrDB["Login"]);
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindPacienteById_s(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindPacienteById_s", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityPaciente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityPaciente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityPaciente.Login = Convert.ToString(DrDB["Login"]);
                }
                else
                {
                    return null;
                }
                return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        


        public string FindPacienteByEmailCPF(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();
                string meuUsuario;

                CmdDB = new SqlCommand("spFindPacienteByEmailCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                if (entityPaciente.Email != string.Empty && entityPaciente.Email != null) // Se a pesquisa for pelo Email
                {
                    CmdDB.Parameters.AddWithValue("@EmailCPF", entityPaciente.Email);
                    CmdDB.Parameters.AddWithValue("@CPFEmail", entityPaciente.CPF);
                }
                else if (entityPaciente.CPF != Int64.MaxValue) // Se a pesquisa for pelo CPF
                {
                    CmdDB.Parameters.AddWithValue("@CPFEmail", entityPaciente.CPF);
                    entityPaciente.Email = "";
                    CmdDB.Parameters.AddWithValue("@EmailCPF", entityPaciente.Email);
                }
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    meuUsuario = DrDB.GetString(0).ToString();
                    DrDB.Close();
                    return meuUsuario;
                }
                else
                {
                    DrDB.Close();
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (ArgumentException ex)
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


        public void InsertPaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = null;
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.ExecuteNonQuery();
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
        public void InsertPaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone2.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone2.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone2.Numero);
                if (entityTelefone2.Operadora == null)
                {
                    entityTelefone2.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone2.Operadora);

                CmdDB.ExecuteNonQuery();
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
        public void InsertPaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone2.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone2.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone2.Numero);
                if (entityTelefone2.Operadora == null)
                {
                    entityTelefone2.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone2.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone3.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone3.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone3.Numero);
                if (entityTelefone3.Operadora == null)
                {
                    entityTelefone3.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone3.Operadora);

                CmdDB.ExecuteNonQuery();
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


        public void UpdatePaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdatePaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.ExecuteNonQuery();
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
        public void UpdatePaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdatePaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone2.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone2.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone2.Numero);
                if (entityTelefone2.Operadora == null)
                {
                    entityTelefone2.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone2.Operadora);

                CmdDB.ExecuteNonQuery();
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
        public void UpdatePaciente(EntityPaciente entityPaciente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpDatePaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityPaciente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityPaciente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityPaciente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityPaciente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityPaciente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityPaciente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityPaciente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityPaciente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityPaciente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityPaciente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityPaciente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityPaciente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityPaciente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityPaciente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone1.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone1.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone1.Numero);
                if (entityTelefone1.Operadora == null)
                {
                    entityTelefone1.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone1.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone2.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone2.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone2.Numero);
                if (entityTelefone2.Operadora == null)
                {
                    entityTelefone2.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone2.Operadora);

                CmdDB.Parameters.AddWithValue("@TipoTelefone", entityTelefone3.TipoTelefone);
                CmdDB.Parameters.AddWithValue("@DDD", entityTelefone3.DDD);
                CmdDB.Parameters.AddWithValue("@NumeroTel", entityTelefone3.Numero);
                if (entityTelefone3.Operadora == null)
                {
                    entityTelefone3.Operadora = "";
                }
                CmdDB.Parameters.AddWithValue("@Operadora", entityTelefone3.Operadora);

                CmdDB.ExecuteNonQuery();
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


        public void InsertFotoPaciente(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertFotoPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@UrlFoto", entityPaciente.UrlFoto);
                CmdDB.ExecuteNonQuery();
            }
            catch (ArgumentException ex)
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
        } // .............
        public void UpdateFotoPaciente(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdateFotoPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@UrlFoto", entityPaciente.UrlFoto);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                CmdDB.ExecuteNonQuery();
            }
            catch (ArgumentException ex)
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
        public string FindFotoPaciente(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();
                string caminhoFoto;

                CmdDB = new SqlCommand("spFindFotoPaciente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);
                DrDB = CmdDB.ExecuteReader();
                if (DrDB.Read())
                {
                    if (DrDB.IsDBNull(0))
                    {
                        DrDB.Close();
                        return null;
                    }
                    else
                    {
                        caminhoFoto = Convert.ToString(DrDB.GetValue(0));
                        DrDB.Close();
                        return caminhoFoto;
                    }
                }
                else
                {
                    DrDB.Close();
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (ArgumentException ex)
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


        public EntityPaciente FindAllDataPacienteByLogin(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityPaciente.Login);                
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteByNome(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Nome", entityPaciente.Nome);

                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteBySobrenome(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteBySobrenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityPaciente.Sobrenome);

                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteByDatanascimento(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByDatanascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityPaciente.DataNascimento);

                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteByEmail(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Email", entityPaciente.Email);

                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteByCPF(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@CPF", entityPaciente.CPF);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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
        public EntityPaciente FindAllDataPacienteByRG(EntityPaciente entityPaciente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataPacienteByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityPaciente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityPaciente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityPaciente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityPaciente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@RG", entityPaciente.RG.Numero);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityPaciente.Endereco = new EntityEndereco();
                    entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                    entityPaciente.RG = new EntityRG();
                    entityPaciente.Telefone = new EntityTelefone();

                    entityPaciente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityPaciente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityPaciente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityPaciente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityPaciente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityPaciente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityPaciente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityPaciente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityPaciente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityPaciente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityPaciente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityPaciente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityPaciente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityPaciente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityPaciente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityPaciente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityPaciente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityPaciente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityPaciente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityPaciente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityPaciente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityPaciente;
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
            catch (InvalidCastException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (FormatException ex)
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