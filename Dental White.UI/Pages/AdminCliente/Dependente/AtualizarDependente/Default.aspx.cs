using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Dependente;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Logradouro;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Entity.GrauParentesco;
using Dental_White.DAL.Dal.DalDDD;
using Dental_White.DAL.Dal.DalCadastroDependente;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.AdminCliente.Dependente.AtualizarDependente
{
    public partial class Default1 : System.Web.UI.Page
    {
        string login;
        bool resultado, erros = false;
        bool updateLogin;
        string str;
        DalDDD dalUFEstado = new DalDDD();
        EntityDependente entityDependente = new EntityDependente();
        DalCadastroDependente dalCadastroDependente = new DalCadastroDependente();
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
            {
                try
                {
                    if (Session["Usuario"] != null)
                    {
                        login = Request.QueryString["login"];
                        this.ExibirDDD();
                    }
                    entityDependente.Login = login;
                    resultado = dalCadastroDependente.FindLoginDependente(entityDependente);
                    if (resultado) // Se o Login do Dependente existir
                    {
                        pnltxtLogin.Visible = false;
                        pnllblLogin.Visible = true;
                        RequiredFieldValidatorLogin.Enabled = false;
                        lblLogin.Text = login;
                        txtNome.Focus();
                    }
                    else
                    {
                        pnllblLogin.Visible = false;
                        pnltxtLogin.Visible = true;
                        RequiredFieldValidatorLogin.Enabled = true;
                    }
                    txtNumeroTelefone1.Enabled = false;
                    txtNumeroTelefone2.Enabled = false;
                    txtNumeroTelefone3.Enabled = false;
                    ddlDDD1.Enabled = false;
                    ddlDDD2.Enabled = false;
                    ddlDDD3.Enabled = false;
                }
                catch(HttpException ex)
                {
                    pnlMensagemErro.Visible = true;
                    lblMensagemErro.Text = ex.Message;
                }
                catch(Exception ex)
                {
                    pnlMensagemErro.Visible = true;
                    lblMensagemErro.Text = ex.Message;
                }
            }
        }
        protected void ddlTipoTelefone1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Telefone = ddlTipoTelefone1.SelectedValue;

                if (Telefone == string.Empty)
                {
                    ddlOperadora1.ClearSelection();
                    ddlOperadora1.Visible = false;
                    ddlDDD1.ClearSelection();
                    ddlDDD1.Enabled = false;
                    txtNumeroTelefone1.Text = string.Empty;
                    txtNumeroTelefone1.Enabled = false;
                    pnlMensagemErro.Visible = false;
                    ddlTipoTelefone1.Focus();
                }
                if (Telefone == "Residencial")
                {
                    pnlOperadora1.Visible = false;
                    RequiredFieldValidatorOperadora1.Enabled = false;
                    RequiredFieldValidatorDDD1.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone1.Enabled = false;
                    txtNumeroTelefone1.MaxLength = 8;
                    txtNumeroTelefone1.Text = string.Empty;
                    txtNumeroTelefone1.Enabled = true;
                    ddlDDD1.Enabled = true;
                    ddlDDD1.Focus();
                }
                if (Telefone == "Celular")
                {
                    pnlOperadora1.Visible = true;
                    RequiredFieldValidatorOperadora1.Enabled = true;
                    RequiredFieldValidatorDDD1.Enabled = true;
                    RequiredFieldValidatorNumeroTelefone1.Enabled = true;
                    txtNumeroTelefone1.MaxLength = 9;
                    txtNumeroTelefone1.Text = string.Empty;
                    txtNumeroTelefone1.Enabled = true;
                    ddlDDD1.Enabled = true;
                    ddlOperadora1.Focus();
                }
                if (Telefone == "Recado")
                {
                    pnlOperadora1.Visible = false;
                    RequiredFieldValidatorOperadora1.Enabled = false;
                    RequiredFieldValidatorDDD1.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone1.Enabled = false;
                    txtNumeroTelefone1.MaxLength = 8;
                    txtNumeroTelefone1.Text = string.Empty;
                    txtNumeroTelefone1.Enabled = true;
                    ddlDDD1.Enabled = true;
                    ddlDDD1.Focus();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void ddlTipoTelefone2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Telefone = ddlTipoTelefone2.SelectedValue;
                if (Telefone == string.Empty)
                {
                    ddlOperadora2.ClearSelection();
                    ddlOperadora2.Visible = false;
                    ddlDDD2.ClearSelection();
                    ddlDDD2.Enabled = false;
                    txtNumeroTelefone2.Text = string.Empty;
                    txtNumeroTelefone2.Enabled = false;
                    pnlMensagemErro.Visible = false;
                    ddlTipoTelefone2.Focus();
                }
                if (Telefone == "Residencial")
                {
                    pnlOperadora2.Visible = false;
                    RequiredFieldValidatorOperadora2.Enabled = false;
                    RequiredFieldValidatorDDD2.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone2.Enabled = false;
                    txtNumeroTelefone2.MaxLength = 8;
                    txtNumeroTelefone2.Text = string.Empty;
                    txtNumeroTelefone2.Enabled = true;
                    ddlDDD2.Enabled = true;
                    ddlDDD2.Focus();
                }
                if (Telefone == "Celular")
                {
                    pnlOperadora2.Visible = true;
                    RequiredFieldValidatorOperadora2.Enabled = true;
                    RequiredFieldValidatorDDD2.Enabled = true;
                    RequiredFieldValidatorNumeroTelefone2.Enabled = true;
                    txtNumeroTelefone2.MaxLength = 9;
                    txtNumeroTelefone2.Text = string.Empty;
                    txtNumeroTelefone2.Enabled = true;
                    ddlDDD2.Enabled = true;
                    ddlOperadora2.Focus();
                }
                if (Telefone == "Recado")
                {
                    pnlOperadora2.Visible = false;
                    RequiredFieldValidatorOperadora2.Enabled = false;
                    RequiredFieldValidatorDDD2.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone2.Enabled = false;
                    txtNumeroTelefone2.MaxLength = 8;
                    txtNumeroTelefone2.Text = string.Empty;
                    txtNumeroTelefone2.Enabled = true;
                    ddlDDD2.Enabled = true;
                    ddlDDD2.Focus();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void ddlTipoTelefone3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string Telefone = ddlTipoTelefone3.SelectedValue;
                if (Telefone == string.Empty)
                {
                    ddlOperadora3.ClearSelection();
                    ddlOperadora3.Visible = false;
                    ddlDDD3.ClearSelection();
                    ddlDDD3.Enabled = false;
                    txtNumeroTelefone3.Text = string.Empty;
                    txtNumeroTelefone3.Enabled = false;
                    pnlMensagemErro.Visible = false;
                    ddlTipoTelefone3.Focus();
                }
                if (Telefone == "Residencial")
                {
                    pnlOperadora3.Visible = false;
                    RequiredFieldValidatorOperadora3.Enabled = false;
                    RequiredFieldValidatorDDD3.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone3.Enabled = false;
                    txtNumeroTelefone1.Text = string.Empty;
                    txtNumeroTelefone1.Enabled = true;
                    txtNumeroTelefone3.Enabled = true;
                    ddlDDD3.Enabled = true;
                    ddlDDD3.Focus();
                }
                if (Telefone == "Celular")
                {
                    pnlOperadora3.Visible = true;
                    RequiredFieldValidatorOperadora3.Enabled = true;
                    RequiredFieldValidatorDDD3.Enabled = true;
                    RequiredFieldValidatorNumeroTelefone3.Enabled = true;
                    txtNumeroTelefone3.Text = string.Empty;
                    txtNumeroTelefone3.Enabled = true;
                    ddlDDD3.Enabled = true;
                    ddlOperadora3.Focus();
                }
                if (Telefone == "Recado")
                {
                    pnlOperadora3.Visible = false;
                    RequiredFieldValidatorOperadora3.Enabled = false;
                    RequiredFieldValidatorDDD3.Enabled = false;
                    RequiredFieldValidatorNumeroTelefone3.Enabled = false;
                    txtNumeroTelefone3.Text = string.Empty;
                    txtNumeroTelefone3.Enabled = true;
                    ddlDDD3.Enabled = true;
                    ddlDDD3.Focus();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void ddlTipoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                if (ddlTipoPesquisa.SelectedValue != string.Empty)
                {
                    pnlTipoPesquisa.Visible = true;
                    if (ddlTipoPesquisa.SelectedValue == "porlogin")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Login:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 50;
                        txtTipoPesquisa.ToolTip = "Digite Login...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "pornome")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Nome:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 50;
                        txtTipoPesquisa.ToolTip = "Digite Nome...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porsobrenome")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Sobrenome:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 80;
                        txtTipoPesquisa.ToolTip = "Digite Sobrenome...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "pordatanascimento")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Data de Nascimento:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 10;
                        txtTipoPesquisa.ToolTip = "Digite Data de Nascimento...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "poremail")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Email:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 50;
                        txtTipoPesquisa.ToolTip = "Digite Email...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porcpf")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " CPF:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 11;
                        txtTipoPesquisa.ToolTip = "Digite CPF...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porrg")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " RG:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 10;
                        txtTipoPesquisa.ToolTip = "Digite RG...";
                        pnlAtualizarPaciente.Visible = false;
                    }
                }
                else
                {
                    pnlTipoPesquisa.Visible = false;
                    pnlAtualizarPaciente.Visible = false;
                    lblTipoPesquisa.Text = string.Empty;
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                string tipoPesquisa = ddlTipoPesquisa.SelectedValue;

                if (tipoPesquisa != string.Empty)
                {
                    if (lblTipoPesquisa.Text == " Login:")
                    {
                        entityDependente.Login = txtTipoPesquisa.Text.Trim();
                        resultado = dalCadastroDependente.FindDependenteByLogin(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " Nome:")
                    {
                        entityDependente.Nome = txtTipoPesquisa.Text.Trim();
                        resultado = dalCadastroDependente.FindDependenteByNome(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " Sobrenome:")
                    {
                        entityDependente.Sobrenome = txtTipoPesquisa.Text.Trim();
                        resultado = dalCadastroDependente.FindDependenteBySobrenome(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " Data de Nascimento:")
                    {
                        entityDependente.DataNascimento = Convert.ToDateTime(txtTipoPesquisa.Text);
                        resultado = dalCadastroDependente.FindDependenteByDataNascimento(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " Email:")
                    {
                        entityDependente.Email = txtTipoPesquisa.Text;
                        resultado = dalCadastroDependente.FindDependenteByEmail(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " CPF:")
                    {
                        entityDependente.CPF = Convert.ToInt64(txtTipoPesquisa.Text);
                        resultado = dalCadastroDependente.FindDependenteByCPF(entityDependente);
                    }
                    if (lblTipoPesquisa.Text == " RG:")
                    {
                        entityDependente.RG = new EntityRG();
                        entityDependente.RG.Numero = Convert.ToInt64(txtTipoPesquisa.Text);
                        resultado = dalCadastroDependente.FindDependenteByRG(entityDependente);
                    }
                    if (resultado) // Se existir Dependente
                    {
                        EntityTelefone entityTelefone1 = new EntityTelefone();
                        EntityTelefone entityTelefone2 = new EntityTelefone();
                        EntityTelefone entityTelefone3 = new EntityTelefone();
                        DalCadastroDependente dalCadastroDependente = new DalCadastroDependente();

                        switch (tipoPesquisa)
                        {
                            case "porlogin":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O dependente ainda não pode ser encontrado pelo Login. Tente outra forma de pesquisa.");
                                }
                                else
                                {
                                    break;
                                }
                            case "pornome":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porsobrenome":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "pordatanascimento":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "poremail":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porcpf":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porrg":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.Telefone = new EntityTelefone();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();
                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByRG(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            default:
                                throw new Exception("Opção Inválida.");
                        }
                        pnlAtualizarPaciente.Visible = true;
                        this.HabilitarCampos();
                        txtNome.Text = entityDependente.Nome;
                        txtSobrenome.Text = entityDependente.Sobrenome;
                        txtEmail.Text = entityDependente.Email;
                        if (entityDependente.Sexo.ToString() == "Masculino")
                        {
                            rdbSexo.SelectedValue = "1";
                        }
                        if (entityDependente.Sexo.ToString() == "Feminino")
                        {
                            rdbSexo.SelectedValue = "2";
                        }

                        if (entityDependente.EstadoCivil.ToString() == "Solteiro")
                        {
                            rdbEstadoCivil.SelectedValue = "Solteiro";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Casado")
                        {
                            rdbEstadoCivil.SelectedValue = "Casado";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Divorciado")
                        {
                            rdbEstadoCivil.SelectedValue = "Divorciado";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Viúvo")
                        {
                            rdbEstadoCivil.SelectedValue = "Viúvo";
                        }

                        txtDataNascimento.Text = entityDependente.DataNascimento.ToShortDateString();
                        txtDataNascimento.Text = entityDependente.DataNascimento.ToString("yyyy-MM-dd");

                        txtCPF.Text = Convert.ToString(entityDependente.CPF);
                        txtNumeroRG.Text = Convert.ToString(entityDependente.RG.Numero);
                        txtOrgaoEmissor.Text = Convert.ToString(entityDependente.RG.OrgaoEmissor);
                        txtDataEmissao.Text = entityDependente.RG.DataEmissao.ToShortDateString();
                        txtDataEmissao.Text = entityDependente.RG.DataEmissao.ToString("yyyy-MM-dd");

                        rdbNivelGrauParentesco.SelectedValue = entityDependente.GrauParentesco.NivelGrauParentesco;
                        txtDescricaoGrauParentesco.Text = entityDependente.GrauParentesco.DescricaoGrauParentesco;

                        ddlTipoTelefone1.SelectedValue = entityDependente.Telefone.TipoTelefone;
                        ddlOperadora1.SelectedValue = entityDependente.Telefone.Operadora;
                        if (ddlOperadora1.DataValueField != string.Empty)
                        {
                            pnlOperadora1.Visible = true;
                        }
                        ddlDDD1.SelectedItem.Text = Convert.ToString(entityDependente.Telefone.DDD);
                        txtNumeroTelefone1.Text = Convert.ToString(entityDependente.Telefone.Numero);

                        ddlUF.SelectedValue = Convert.ToString(entityDependente.Endereco.UF);
                        ddlEstado.SelectedValue = Convert.ToString(entityDependente.Endereco.Estado);
                        txtCidade.Text = Convert.ToString(entityDependente.Endereco.Cidade);
                        rdbTipoLogradouro.SelectedValue = Convert.ToString(entityDependente.Endereco.Logradouro.TipoLogradouro);
                        txtLogradouro.Text = Convert.ToString(entityDependente.Endereco.Logradouro.Logradouro);
                        txtNumeroEnd.Text = Convert.ToString(entityDependente.Endereco.Numero);
                        txtBairro.Text = Convert.ToString(entityDependente.Endereco.Bairro);
                        txtComplemento.Text = Convert.ToString(entityDependente.Endereco.Complemento);
                        txtCEP.Text = Convert.ToString(entityDependente.Endereco.CEP);
                    }
                    else
                    {
                        if (tipoPesquisa == "porlogin")
                        {
                            throw new Exception("O Dependente ainda não pode ser encontrado pelo Login. Tente outra forma de pesquisa.");
                        }
                        if (tipoPesquisa == "pornome")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                        if (tipoPesquisa == "porsobrenome")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                        if (tipoPesquisa == "pordatanascimento")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                        if (tipoPesquisa == "poremail")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                        if (tipoPesquisa == "porcpf")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                        if (tipoPesquisa == "porrg")
                        {
                            throw new Exception("O Dependente atualmente não se encontra cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.");
                        }
                    }
                }
                if(entityDependente.Login == null || entityDependente.Login == string.Empty)
                {
                    txtLogin.Text = Request.QueryString["login"];
                    txtLogin.ReadOnly = true;
                }
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = false;
                bool contatoTelefone = false;
                int qtdTelefone = 0;
                pnlMensagemErro.Visible = false;

                EntityDependente entityDependente = new EntityDependente();
                entityDependente.Endereco = new EntityEndereco();
                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                entityDependente.RG = new EntityRG();
                entityDependente.GrauParentesco = new EntityGrauParentesco();

                EntityTelefone entityTelefone1 = new EntityTelefone();
                EntityTelefone entityTelefone2 = new EntityTelefone();
                EntityTelefone entityTelefone3 = new EntityTelefone();
                DalCadastroDependente dalCadastroDependente = new DalCadastroDependente();

                this.InserirDadosPessoais(entityDependente);
                this.InserirDocumentos(entityDependente);
                this.InserirEndereco(entityDependente);
                this.InserirTelefones(entityTelefone1);

                if (ddlTipoTelefone1.SelectedValue != string.Empty)
                {
                    this.ValidarCamposTelefone();
                    this.InserirTelefones(entityTelefone1);
                    qtdTelefone = 1;
                }
                else if (ddlTipoTelefone1.SelectedValue != string.Empty && ddlTipoTelefone2.SelectedValue != string.Empty)
                {
                    this.ValidarCamposTelefone();
                    this.InserirTelefones(entityTelefone1, entityTelefone2);
                    qtdTelefone = 2;
                }
                else if (ddlTipoTelefone1.SelectedValue != string.Empty && ddlTipoTelefone2.SelectedValue != string.Empty && ddlTipoTelefone3.SelectedValue != string.Empty)
                {
                    this.ValidarCamposTelefone();
                    this.InserirTelefones(entityTelefone1, entityTelefone2, entityTelefone3);
                    qtdTelefone = 3;
                }
                else
                {
                    erros = false;
                }
                if (erros)
                {
                    pnlMensagemErro.Visible = true;
                    throw new Exception("Opção Inválida.");
                }
                else
                {
                    if (qtdTelefone == 1)
                    {
                        entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                        entityTelefone1.IdTelefone = entityDependente.Telefone.IdTelefone;
                        dalCadastroDependente.UpdateDependente(entityDependente, entityTelefone1);
                        if(entityDependente.Login == null || entityDependente.Login == string.Empty)
                        {
                            entityDependente.Login = Request.QueryString["login"];
                            dalCadastroDependente.UpdateLoginDependente(entityDependente);
                        }
                        contatoTelefone = true;
                    }
                    if (qtdTelefone == 2)
                    {
                        entityDependente = dalCadastroDependente.FindDependenteById_s(entityDependente, entityTelefone1, entityTelefone2);

                        dalCadastroDependente.UpdateDependente(entityDependente, entityTelefone1, entityTelefone2);
                        contatoTelefone = true;
                    }
                    if (qtdTelefone == 3)
                    {
                        entityDependente = dalCadastroDependente.FindDependenteById_s(entityDependente, entityTelefone1, entityTelefone2, entityTelefone3);

                        dalCadastroDependente.UpdateDependente(entityDependente, entityTelefone1, entityTelefone2, entityTelefone3);
                        contatoTelefone = true;
                    }
                    else
                    {
                        if (!contatoTelefone)
                        {
                            throw new Exception("Pelo menos uma forma de Contato de Telefone deverá ser cadastrada.");
                        }
                        else
                        {
                            resultado = true;
                        }
                    }
                }
                if (resultado)
                {
                    pnlMensagemSucesso.Visible = true;
                }
            }
            catch (FormatException ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
            catch (OverflowException ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
            catch (Exception ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
        }
        private void InserirDadosPessoais(EntityDependente entityDependente)
        {
            try
            {
                if (txtCPF.Text != string.Empty)
                {
                    str = txtCPF.Text;
                    short qtdCPF = Convert.ToSByte(str.Length);
                    for (short i = 1; i <= qtdCPF; i++)
                    {
                        if (i == 3 || i == 7 || i == 11)
                        {
                            txtCPF.Text = txtCPF.Text.Replace(".", "");
                        }
                        if (i == 12)
                        {
                            txtCPF.Text = txtCPF.Text.Replace("-", "");
                        }
                    }
                    entityDependente.CPF = Convert.ToInt64(txtCPF.Text);
                }
                if (txtNome.Text != string.Empty)
                {
                    entityDependente.Nome = txtNome.Text;
                }
                if (txtSobrenome.Text != string.Empty)
                {
                    entityDependente.Sobrenome = txtSobrenome.Text;
                }
                if (txtEmail.Text != string.Empty)
                {
                    entityDependente.Email = txtEmail.Text;
                }
                if (rdbSexo.SelectedValue != string.Empty)
                {
                    Int16 sexo = Convert.ToInt16(rdbSexo.SelectedValue);
                    if (sexo == 1) // 1 = Masculino
                    {
                        entityDependente.Sexo = EnumSexo.Masculino;
                    }
                    if (sexo == 2) // 2 = Feminino
                    {
                        entityDependente.Sexo = EnumSexo.Feminino;
                    }
                }
                if (rdbEstadoCivil.SelectedValue != string.Empty)
                {
                    string estadoCivil = rdbEstadoCivil.SelectedValue;
                    if (estadoCivil == "Solteiro")
                    {
                        entityDependente.EstadoCivil = EnumEstadoCivil.Solteiro;
                    }
                    if (estadoCivil == "Casado")
                    {
                        entityDependente.EstadoCivil = EnumEstadoCivil.Casado;
                    }
                    if (estadoCivil == "Divorciado")
                    {
                        entityDependente.EstadoCivil = EnumEstadoCivil.Divorciado;
                    }
                    if (estadoCivil == "Viuvo")
                    {
                        entityDependente.EstadoCivil = EnumEstadoCivil.Viuvo;
                    }
                }
                if (txtDataNascimento.Text != string.Empty)
                {
                    entityDependente.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                }
                else
                {
                    this.RenderizarCamposFormulario();
                    erros = true;
                }
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void InserirDocumentos(EntityDependente entityDependente)
        {
            try
            {
                if (txtNumeroRG.Text != string.Empty)
                {
                    str = txtNumeroRG.Text;
                    short qtdRG = Convert.ToSByte(str.Length);
                    for (short i = 1; i <= qtdRG; i++)
                    {
                        if (i == 3 || i == 7)
                        {
                            txtNumeroRG.Text = txtNumeroRG.Text.Replace(".", "");
                        }
                        if (i == 11)
                        {
                            txtNumeroRG.Text = txtNumeroRG.Text.Replace("-", "");
                        }
                    }
                    entityDependente.RG.Numero = Convert.ToInt64(txtNumeroRG.Text);
                    entityDependente.GrauParentesco.DescricaoGrauParentesco = txtDescricaoGrauParentesco.Text;
                }
                if (txtOrgaoEmissor.Text != string.Empty)
                {
                    entityDependente.RG.OrgaoEmissor = txtOrgaoEmissor.Text;
                }
                if (txtDataEmissao.Text != string.Empty)
                {
                    entityDependente.RG.DataEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                }
                if (rdbNivelGrauParentesco.SelectedValue != string.Empty)
                {
                    if (rdbNivelGrauParentesco.SelectedValue == "conjuge")
                    {
                        entityDependente.GrauParentesco.NivelGrauParentesco = "conjuge";
                    }
                    if (rdbNivelGrauParentesco.SelectedValue == "filhosenteados")
                    {
                        entityDependente.GrauParentesco.NivelGrauParentesco = "filhosenteados";
                    }
                    if (rdbNivelGrauParentesco.SelectedValue == "paimae")
                    {
                        entityDependente.GrauParentesco.NivelGrauParentesco = "paimae";
                    }
                }
                else
                {
                    this.RenderizarCamposFormulario();
                    erros = true;
                }
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void InserirTelefones(EntityTelefone entityTelefone1)
        {
            try
            {
                if (ddlTipoTelefone1.SelectedValue != string.Empty)
                {
                    entityTelefone1.TipoTelefone = ddlTipoTelefone1.Text;
                }
                if (ddlOperadora1.SelectedValue != string.Empty)
                {
                    entityTelefone1.Operadora = ddlOperadora1.Text;
                }
                if (ddlDDD1.SelectedValue != string.Empty)
                {
                    entityTelefone1.DDD = Convert.ToInt16(ddlDDD1.SelectedItem.Text);
                }
                if (txtNumeroTelefone1.Text != string.Empty)
                {
                    entityTelefone1.Numero = Convert.ToInt32(txtNumeroTelefone1.Text);
                }
                else
                {
                    this.RenderizarCamposFormulario();
                    erros = true;
                }
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void InserirTelefones(EntityTelefone entityTelefone1, EntityTelefone entityTelefone2)
        {
            try
            {
                // *** TELEFONE 1 ***
                if (ddlTipoTelefone1.SelectedValue != string.Empty)
                {
                    entityTelefone1.TipoTelefone = ddlTipoTelefone1.Text;
                }
                if (ddlOperadora1.SelectedValue != string.Empty)
                {
                    entityTelefone1.Operadora = ddlOperadora1.Text;
                }
                if (ddlDDD1.SelectedValue != string.Empty)
                {
                    entityTelefone1.DDD = Convert.ToInt16(ddlDDD1.SelectedItem.Text);
                }
                if (txtNumeroTelefone1.Text != string.Empty)
                {
                    entityTelefone1.Numero = Convert.ToInt32(txtNumeroTelefone1.Text);
                }
                else
                {
                    erros = true;
                }
                // *** TELEFONE 1 ***

                // *** TELEFONE 2 ***
                if (ddlTipoTelefone2.SelectedValue != string.Empty)
                {
                    entityTelefone2.TipoTelefone = ddlTipoTelefone2.Text;
                }
                if (ddlOperadora2.SelectedValue != string.Empty)
                {
                    entityTelefone2.Operadora = ddlOperadora2.Text;
                }
                if (ddlDDD2.SelectedValue != string.Empty)
                {
                    entityTelefone2.DDD = Convert.ToInt16(ddlDDD2.SelectedItem.Text);
                }
                if (txtNumeroTelefone2.Text != string.Empty)
                {
                    entityTelefone2.Numero = Convert.ToInt32(txtNumeroTelefone2.Text);
                }
                else
                {
                    erros = true;
                }
                // *** TELEFONE 2 ***
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void InserirTelefones(EntityTelefone entityTelefone1, EntityTelefone entityTelefone2, EntityTelefone entityTelefone3)
        {
            try
            {
                // *** TELEFONE 1 ***
                if (ddlTipoTelefone1.SelectedValue != string.Empty)
                {
                    entityTelefone1.TipoTelefone = ddlTipoTelefone1.Text;
                }
                if (ddlOperadora1.SelectedValue != string.Empty)
                {
                    entityTelefone1.Operadora = ddlOperadora1.Text;
                }
                if (ddlDDD1.SelectedValue != string.Empty)
                {
                    entityTelefone1.DDD = Convert.ToInt16(ddlDDD1.SelectedItem.Text);
                }
                if (txtNumeroTelefone1.Text != string.Empty)
                {
                    entityTelefone1.Numero = Convert.ToInt32(txtNumeroTelefone1.Text);
                }
                else
                {
                    erros = true;
                }
                // *** TELEFONE 1 ***

                // *** TELEFONE 2 ***
                if (ddlTipoTelefone2.SelectedValue != string.Empty)
                {
                    entityTelefone2.TipoTelefone = ddlTipoTelefone2.Text;
                }
                else if (ddlOperadora2.SelectedValue != string.Empty)
                {
                    entityTelefone2.Operadora = ddlOperadora2.Text;
                }
                else if (ddlDDD2.SelectedValue != string.Empty)
                {
                    entityTelefone2.DDD = Convert.ToInt16(ddlDDD2.SelectedItem.Text);
                }
                else if (txtNumeroTelefone2.Text != string.Empty)
                {
                    entityTelefone2.Numero = Convert.ToInt32(txtNumeroTelefone2.Text);
                }
                else
                {
                    erros = true;
                }
                // *** TELEFONE 2 ***

                // *** TELEFONE 3 ***
                if (ddlTipoTelefone3.SelectedValue != string.Empty)
                {
                    entityTelefone3.TipoTelefone = ddlTipoTelefone3.Text;
                }
                else if (ddlOperadora3.SelectedValue != string.Empty)
                {
                    entityTelefone3.Operadora = ddlOperadora3.Text;
                }
                else if (ddlDDD3.SelectedValue != string.Empty)
                {
                    entityTelefone3.DDD = Convert.ToInt16(ddlDDD3.SelectedItem.Text);
                }
                else if (txtNumeroTelefone3.Text != string.Empty)
                {
                    entityTelefone3.Numero = Convert.ToInt32(txtNumeroTelefone3.Text);
                }
                else
                {
                    erros = true;
                }
                // *** TELEFONE 3 ***
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void InserirEndereco(EntityDependente entityDependente)
        {
            try
            {
                if (ddlUF.SelectedValue != string.Empty)
                {
                    entityDependente.Endereco.UF = ddlUF.SelectedValue;
                }
                if (ddlEstado.Text != string.Empty)
                {
                    entityDependente.Endereco.Estado = ddlEstado.Text;
                }
                if (txtCidade.Text != string.Empty)
                {
                    entityDependente.Endereco.Cidade = txtCidade.Text;
                }
                if (txtLogradouro.Text != string.Empty)
                {
                    entityDependente.Endereco.Logradouro.Logradouro = txtLogradouro.Text;
                }
                if (txtNumeroEnd.Text != string.Empty)
                {
                    entityDependente.Endereco.Numero = txtNumeroEnd.Text;
                }
                if (rdbTipoLogradouro.SelectedValue != string.Empty)
                {
                    entityDependente.Endereco.Logradouro.TipoLogradouro = rdbTipoLogradouro.SelectedValue;
                }
                if (txtBairro.Text != string.Empty)
                {
                    entityDependente.Endereco.Bairro = txtBairro.Text;
                }
                if (txtComplemento.Text != string.Empty)
                {
                    entityDependente.Endereco.Complemento = txtComplemento.Text;
                }
                if (txtCEP.Text != string.Empty)
                {
                    entityDependente.Endereco.CEP = Convert.ToInt32(txtCEP.Text);
                }
                else
                {
                    this.RenderizarCamposFormulario();
                    erros = true;
                }
            }
            catch (FormatException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (OverflowException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void ValidarCamposTelefone()
        {
            try
            {
                // *** VALIDAÇÃO DOS CAMPOS DO 1º TELEFONE ***
                if (RequiredFieldValidatorOperadora1.Enabled)
                {
                    ddlOperadora1.Width = 176;
                    txtNumeroTelefone1.Width = 175;
                    if (ddlDDD1.SelectedValue == "0")
                    {
                        RequiredFieldValidatorDDD1.Enabled = true;
                    }
                    else
                    {
                        RequiredFieldValidatorDDD1.Enabled = false;
                    }
                }
                if (RequiredFieldValidatorDDD1.Enabled)
                {
                    RequiredFieldValidatorNumeroTelefone1.Enabled = true;
                }
                // *** VALIDAÇÃO DOS CAMPOS DO 1º TELEFONE ***

                // *** VALIDAÇÃO DOS CAMPOS DO 2º TELEFONE ***
                if (RequiredFieldValidatorOperadora1.Enabled)
                {
                    ddlOperadora2.Width = 176;
                    txtNumeroTelefone2.Width = 175;
                    if (ddlDDD2.SelectedValue == "0")
                    {
                        RequiredFieldValidatorDDD2.Enabled = true;
                    }
                    else
                    {
                        RequiredFieldValidatorDDD2.Enabled = false;
                    }
                }
                if (RequiredFieldValidatorDDD2.Enabled)
                {
                    RequiredFieldValidatorNumeroTelefone2.Enabled = true;
                }
                // *** VALIDAÇÃO DOS CAMPOS DO 2º TELEFONE ***

                // *** VALIDAÇÃO DOS CAMPOS DO 3º TELEFONE ***
                if (RequiredFieldValidatorOperadora1.Enabled)
                {
                    ddlOperadora3.Width = 176;
                    txtNumeroTelefone3.Width = 175;
                    if (ddlDDD3.SelectedValue == "0")
                    {
                        RequiredFieldValidatorDDD3.Enabled = true;
                    }
                    else
                    {
                        RequiredFieldValidatorDDD3.Enabled = false;
                    }
                }
                if (RequiredFieldValidatorDDD3.Enabled)
                {
                    RequiredFieldValidatorNumeroTelefone3.Enabled = true;
                }
                // *** VALIDAÇÃO DOS CAMPOS DO 3º TELEFONE ***
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void ExibirDDD()
        {
            try
            {
                if (!IsPostBack)
                {
                    DalDDD dalDDD = new DalDDD();

                    ddlDDD1.DataSource = dalDDD.FindAllDDD();
                    ddlDDD1.DataValueField = "Sigla";
                    ddlDDD1.DataTextField = "DDD";
                    ddlDDD1.DataBind();
                    ddlDDD1.Items.Insert(0, new ListItem("-Selecione-", "0"));

                    ddlDDD2.DataSource = dalDDD.FindAllDDD();
                    ddlDDD2.DataValueField = "Sigla";
                    ddlDDD2.DataTextField = "DDD";
                    ddlDDD2.DataBind();
                    ddlDDD2.Items.Insert(0, new ListItem("-Selecione-", "0"));

                    ddlDDD3.DataSource = dalDDD.FindAllDDD();
                    ddlDDD3.DataValueField = "Sigla";
                    ddlDDD3.DataTextField = "DDD";
                    ddlDDD3.DataBind();
                    ddlDDD3.Items.Insert(0, new ListItem("-Selecione-", "0"));
                }
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void ExibirUFEstado()
        {
            try
            {
                if (!IsPostBack)
                {
                    ddlEstado.DataSource = dalUFEstado.FindAllUFEstado();
                    ddlEstado.DataValueField = "Estado";
                    ddlEstado.DataTextField = "Estado";
                    ddlEstado.DataBind();
                    ddlEstado.Items.Insert(0, new ListItem("-Selecione-", "0"));
                }
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void ExibirEstadoUF()
        {
            try
            {
                if (!IsPostBack)
                {
                    ddlUF.DataSource = dalUFEstado.FindAllUFEstado();
                    ddlUF.DataValueField = "UF";
                    ddlUF.DataTextField = "UF";
                    ddlUF.DataBind();
                    ddlUF.Items.Insert(0, new ListItem("-Selecione-", "0"));
                }
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        private void RenderizarCamposFormulario()
        {
            try
            {
                // renderização dos campos
                if (ddlOperadora1.SelectedValue == string.Empty)
                {
                    ddlOperadora1.Width = 180;
                }
                if (ddlOperadora2.SelectedValue == string.Empty)
                {
                    ddlOperadora1.Width = 180;
                }
                if (ddlOperadora3.SelectedValue == string.Empty)
                {
                    ddlOperadora1.Width = 180;
                }
                if (txtNumeroTelefone1.Text == string.Empty)
                {
                    txtNumeroTelefone1.Width = 175;
                }
                if (txtNumeroTelefone2.Text == string.Empty)
                {
                    txtNumeroTelefone2.Width = 175;
                }
                if (txtNumeroTelefone3.Text == string.Empty)
                {
                    txtNumeroTelefone3.Width = 175;
                }
                if (txtCidade.Text == string.Empty)
                {
                    txtCidade.Width = 85;
                }
                if (txtLogradouro.Text == string.Empty)
                {
                    txtLogradouro.Width = 150;
                }
                // renderização dos campos
            }
            catch (ArgumentOutOfRangeException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void ddlUF_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ExibirUFEstado();
            }
        }
        protected void ddlEstado_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.ExibirEstadoUF();
            }
        }
        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtSobrenome.Enabled = false;
            txtDataNascimento.Enabled = false;
            txtEmail.Enabled = false;
            rdbSexo.Enabled = false;
            rdbEstadoCivil.Enabled = false;
            txtCPF.Enabled = false;
            txtNumeroRG.Enabled = false;
            txtOrgaoEmissor.Enabled = false;
            txtDataEmissao.Enabled = false;
            rdbNivelGrauParentesco.Enabled = false;
            txtDescricaoGrauParentesco.Enabled = false;
            ddlTipoTelefone1.Enabled = false;
            ddlTipoTelefone2.Enabled = false;
            ddlTipoTelefone3.Enabled = false;
            ddlOperadora1.Enabled = false;
            ddlOperadora2.Enabled = false;
            ddlOperadora3.Enabled = false;
            ddlDDD1.Enabled = false;
            ddlDDD2.Enabled = false;
            ddlDDD3.Enabled = false;
            txtNumeroTelefone1.Enabled = false;
            txtNumeroTelefone2.Enabled = false;
            txtNumeroTelefone3.Enabled = false;
            ddlDDD1.Enabled = false;
            ddlDDD2.Enabled = false;
            ddlDDD3.Enabled = false;
            ddlUF.Enabled = false;
            ddlEstado.Enabled = false;
            txtCidade.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumeroEnd.Enabled = false;
            rdbTipoLogradouro.Enabled = false;
            txtBairro.Enabled = false;
            txtComplemento.Enabled = false;
            txtCEP.Enabled = false;
            btnAtualizar.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtSobrenome.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtEmail.Enabled = true;
            rdbSexo.Enabled = true;
            rdbEstadoCivil.Enabled = true;
            txtCPF.Enabled = true;
            txtNumeroRG.Enabled = true;
            txtOrgaoEmissor.Enabled = true;
            txtDataEmissao.Enabled = true;
            rdbNivelGrauParentesco.Enabled = true;
            txtDescricaoGrauParentesco.Enabled = true;
            ddlTipoTelefone1.Enabled = true;
            ddlTipoTelefone2.Enabled = true;
            ddlTipoTelefone3.Enabled = true;
            ddlOperadora1.Enabled = true;
            ddlOperadora2.Enabled = true;
            ddlOperadora3.Enabled = true;
            ddlDDD1.Enabled = true;
            ddlDDD2.Enabled = true;
            ddlDDD3.Enabled = true;
            txtNumeroTelefone1.Enabled = true;
            txtNumeroTelefone2.Enabled = true;
            txtNumeroTelefone3.Enabled = true;
            ddlDDD1.Enabled = true;
            ddlDDD2.Enabled = true;
            ddlDDD3.Enabled = true;
            ddlUF.Enabled = true;
            ddlEstado.Enabled = true;
            txtCidade.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumeroEnd.Enabled = true;
            rdbTipoLogradouro.Enabled = true;
            txtBairro.Enabled = true;
            txtComplemento.Enabled = true;
            txtCEP.Enabled = true;
            btnAtualizar.Enabled = true;
        }
        protected void LinkVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityLoginUsuario usuario = (EntityLoginUsuario)Session["Usuario"];
                login = usuario.Login;
                Response.Redirect("../../ClientePaciente/Default.aspx?login=" + login, false);
            }
            catch (ApplicationException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (HttpException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (ArgumentNullException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (ArgumentException ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
    }
}