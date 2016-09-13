using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Dependente;
using Dental_White.DAL.Entity.GrauParentesco;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Logradouro;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Dal.DalDDD;
using Dental_White.DAL.Dal.DalCadastroDependente;
using Dental_White.DAL.Persistence;

namespace Dental_White.DAL.Dal.DalCadastroDependente
{
    public class DalCadastroDependente : ConexaoDentalWhite
    {
        EntityPaciente entityPaciente = new EntityPaciente();
        public bool FindDependenteByLogin(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByMyLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
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
        public bool FindDependenteByNome(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
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
        public bool FindDependenteBySobrenome(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteBySobrenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
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
        public bool FindDependenteByDataNascimento(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByDataNascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
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
        public bool FindDependenteByEmail(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
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
        public bool FindDependenteByCPF(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
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
        public bool FindDependenteByRG(EntityDependente entityDependente)
        {
            try
            {
                bool resultado;
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Numero", entityDependente.RG.Numero);
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


        public bool FindLoginDependente(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindLoginDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read()) // Se o Login do Dependente existir
                {
                    DrDB.Close();
                    return true;
                }
                else // Se o Login do Dependente não existir
                {
                    DrDB.Close();
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


        public EntityDependente FindDependenteById_sByLogin(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sByNome(EntityDependente entityDependente, EntityTelefone entityTelefone1)// aqui
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sBySobrenome(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sBySobrenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sByDatanascimento(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByDatanascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sByEmail(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sByCPF(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_sByRG(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_sByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@RG", entityDependente.RG.Numero);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityPaciente.IdPaciente = Convert.ToInt32(DrDB["IdPaciente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                }
                else
                {
                    return null;
                }
                return entityDependente;
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



        public EntityDependente FindDependenteById_s(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_s", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                    entityDependente.Login = Convert.ToString(DrDB["Login"]);
                }
                else
                {
                    return null;
                }
                return entityDependente;
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
        public EntityDependente FindDependenteById_s(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindDependenteById_s", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityTelefone1.IdTelefone);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco.Logradouro.IdLogradouro = Convert.ToInt32(DrDB["IdLogradouro"]);
                    entityDependente.Endereco.IdEndereco = Convert.ToInt32(DrDB["IdEndereco"]);
                    entityDependente.IdDependente = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.GrauParentesco.IdGrauParentesco = Convert.ToInt32(DrDB["IdDependente"]);
                    entityDependente.RG.IdRG = Convert.ToInt32(DrDB["IdRG"]);
                    entityTelefone1.IdTelefone = Convert.ToInt32(DrDB["IdTelefone"]);
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.Telefone.IdTelefone = entityTelefone1.IdTelefone;
                    entityDependente.Login = Convert.ToString(DrDB["Login"]);
                }
                else
                {
                    return null;
                }
                return entityDependente;
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


        public string FindDependenteByEmailCPF(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();
                string meuUsuario;

                CmdDB = new SqlCommand("spFindDependenteByEmailCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                if (entityDependente.Email != string.Empty && entityDependente.Email != null) // Se a pesquisa for pelo Email
                {
                    CmdDB.Parameters.AddWithValue("@EmailCPF", entityDependente.Email);
                    CmdDB.Parameters.AddWithValue("@CPFEmail", entityDependente.CPF);
                }
                else if (entityDependente.CPF != Int64.MaxValue) // Se a pesquisa for pelo CPF
                {
                    CmdDB.Parameters.AddWithValue("@CPFEmail", entityDependente.CPF);
                    entityDependente.Email = "";
                    CmdDB.Parameters.AddWithValue("@EmailCPF", entityDependente.Email);
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


        public void InsertDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@IdPaciente", entityDependente.IdPaciente);

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                entityDependente.Login = "";
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@NivelGrauParentesco", entityDependente.GrauParentesco.NivelGrauParentesco);
                CmdDB.Parameters.AddWithValue("@DescricaoGrauParentesco", entityDependente.GrauParentesco.DescricaoGrauParentesco);

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
        public void InsertDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

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
        public void InsertDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

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


        public void UpdateDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpDateDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);

                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                entityDependente.Login = "";
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@NivelGrauParentesco", entityDependente.GrauParentesco.NivelGrauParentesco);
                CmdDB.Parameters.AddWithValue("@DescricaoGrauParentesco", entityDependente.GrauParentesco.DescricaoGrauParentesco);

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


        public void UpdateDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdateDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

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
        public void UpdateDependente(EntityDependente entityDependente, EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpDateDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;

                CmdDB.Parameters.AddWithValue("@TipoLogradouro", entityDependente.Endereco.Logradouro.TipoLogradouro);
                CmdDB.Parameters.AddWithValue("@Logradouro", entityDependente.Endereco.Logradouro.Logradouro);

                CmdDB.Parameters.AddWithValue("@NumeroEnd", entityDependente.Endereco.Numero);
                CmdDB.Parameters.AddWithValue("@Bairro", entityDependente.Endereco.Bairro);
                CmdDB.Parameters.AddWithValue("@Complemento", entityDependente.Endereco.Complemento);
                CmdDB.Parameters.AddWithValue("@UF", entityDependente.Endereco.UF);
                CmdDB.Parameters.AddWithValue("@Estado", entityDependente.Endereco.Estado);
                CmdDB.Parameters.AddWithValue("@Cidade", entityDependente.Endereco.Cidade);
                CmdDB.Parameters.AddWithValue("@CEP", entityDependente.Endereco.CEP);

                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                CmdDB.Parameters.AddWithValue("@Sexo", entityDependente.Sexo);
                CmdDB.Parameters.AddWithValue("@EstadoCivil", entityDependente.EstadoCivil);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);

                CmdDB.Parameters.AddWithValue("@NumeroRG", entityDependente.RG.Numero);
                CmdDB.Parameters.AddWithValue("@OrgaoEmissor", entityDependente.RG.OrgaoEmissor);
                CmdDB.Parameters.AddWithValue("@DataEmissao", entityDependente.RG.DataEmissao);

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
        public void UpdateLoginDependente(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdateLoginDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
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


        public void InsertFotoDependente(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spInsertFotoDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@UrlFoto", entityDependente.UrlFoto);
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
        public void UpdateFotoDependente(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spUpdateFotoDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@UrlFoto", entityDependente.UrlFoto);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
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
        public string FindFotoDependente(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();
                string caminhoFoto;

                CmdDB = new SqlCommand("spFindFotoDependente", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
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


        public EntityDependente FindAllDataDependenteByLogin(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByLogin", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@Login", entityDependente.Login);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteByNome(EntityDependente entityDependente)//aqui
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByNome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdPaciente", entityPaciente.IdPaciente);//
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@Nome", entityDependente.Nome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteBySobrenome(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteBySobrenomenome", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@Sobrenome", entityDependente.Sobrenome);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteByDatanascimento(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByDatanascimento", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@DataNascimento", entityDependente.DataNascimento);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteByEmail(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByEmail", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@Email", entityDependente.Email);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteByCPF(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByCPF", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@CPF", entityDependente.CPF);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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
        public EntityDependente FindAllDataDependenteByRG(EntityDependente entityDependente)
        {
            try
            {
                base.OpenDBDentalWhite();

                CmdDB = new SqlCommand("spFindAllDataDependenteByRG", ConDB);
                CmdDB.CommandType = CommandType.StoredProcedure;
                CmdDB.Parameters.AddWithValue("@IdLogradouro", entityDependente.Endereco.Logradouro.IdLogradouro);
                CmdDB.Parameters.AddWithValue("@IdEndereco", entityDependente.Endereco.IdEndereco);
                CmdDB.Parameters.AddWithValue("@IdDependente", entityDependente.IdDependente);
                CmdDB.Parameters.AddWithValue("@IdRG", entityDependente.RG.IdRG);
                CmdDB.Parameters.AddWithValue("@IdTelefone", entityDependente.Telefone.IdTelefone);
                CmdDB.Parameters.AddWithValue("@IdGrauParentesco", entityDependente.GrauParentesco.IdGrauParentesco);
                CmdDB.Parameters.AddWithValue("@RG", entityDependente.RG.Numero);
                DrDB = CmdDB.ExecuteReader();

                if (DrDB.Read())
                {
                    entityDependente.Endereco = new EntityEndereco();
                    entityDependente.Endereco.Logradouro = new EntityLogradouro();
                    entityDependente.RG = new EntityRG();
                    entityDependente.Telefone = new EntityTelefone();
                    entityDependente.GrauParentesco = new EntityGrauParentesco();

                    entityDependente.Nome = Convert.ToString(DrDB["Nome"]);
                    entityDependente.Sobrenome = Convert.ToString(DrDB["Sobrenome"]);
                    entityDependente.Email = Convert.ToString(DrDB["Email"]);
                    if (DrDB["Sexo"] != string.Empty)
                    {
                        Int16 sexo = Convert.ToInt16(DrDB["Sexo"]);
                        if (sexo == 1) // 1 = Masculino
                        {
                            entityDependente.Sexo = EnumSexo.Masculino;
                        }
                        if (sexo == 2) // 2 = Feminino
                        {
                            entityDependente.Sexo = EnumSexo.Feminino;
                        }
                    }
                    if (DrDB["EstadoCivil"] != string.Empty)
                    {
                        string estadoCivil = Convert.ToString(DrDB["EstadoCivil"]);
                        if (estadoCivil == "1") // Se Solteiro
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                        }
                        if (estadoCivil == "2") // Se Casado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                        }
                        if (estadoCivil == "3") // Se Divorciado
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                        }
                        if (estadoCivil == "4") // Se Viúvo
                        {
                            entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                        }
                    }
                    entityDependente.DataNascimento = Convert.ToDateTime(DrDB["DataNascimento"]);

                    entityDependente.CPF = Convert.ToInt64(DrDB["CPF"]);
                    entityDependente.RG.Numero = Convert.ToInt64(DrDB["NumeroRG"]);
                    entityDependente.RG.OrgaoEmissor = Convert.ToString(DrDB["OrgaoEmissor"]);
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(DrDB["DataEmissao"]);

                    entityDependente.GrauParentesco.NivelGrauParentesco = Convert.ToString(DrDB["NivelGrauParentesco"]);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = Convert.ToString(DrDB["DescricaoGrauParentesco"]);

                    entityDependente.Telefone.TipoTelefone = Convert.ToString(DrDB["TipoTelefone"]);
                    entityDependente.Telefone.Operadora = Convert.ToString(DrDB["Operadora"]);
                    entityDependente.Telefone.DDD = Convert.ToInt16(DrDB["DDD"]);
                    entityDependente.Telefone.Numero = Convert.ToInt32(DrDB["NumeroTel"]);

                    entityDependente.Endereco.UF = Convert.ToString(DrDB["UF"]);
                    entityDependente.Endereco.Estado = Convert.ToString(DrDB["Estado"]);
                    entityDependente.Endereco.Cidade = Convert.ToString(DrDB["Cidade"]);
                    entityDependente.Endereco.Logradouro.TipoLogradouro = Convert.ToString(DrDB["TipoLogradouro"]);
                    entityDependente.Endereco.Logradouro.Logradouro = Convert.ToString(DrDB["Logradouro"]);
                    entityDependente.Endereco.Numero = Convert.ToString(DrDB["NumeroEndereco"]);
                    entityDependente.Endereco.Bairro = Convert.ToString(DrDB["Bairro"]);
                    entityDependente.Endereco.Complemento = Convert.ToString(DrDB["Complemento"]);
                    entityDependente.Endereco.CEP = Convert.ToInt32(DrDB["CEP"]);

                    return entityDependente;
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