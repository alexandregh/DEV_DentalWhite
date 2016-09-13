using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Logradouro;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalDDD;
using Dental_White.DAL.Dal.DalCadastroPaciente;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.AdminCliente.Paciente.AtualizarPaciente
{
    public partial class Default : System.Web.UI.Page
    {
        string login;
        bool resultado = false;
        bool erros = false;
        DalDDD dalUFEstado = new DalDDD();
        EntityPaciente entityPaciente = new EntityPaciente();
        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlMensagemErro.Visible = false;
            if (!IsPostBack)
            {
                this.DesabilitarCampos();
                if (Session["Usuario"] != null)
                {
                    login = Request.QueryString["login"];
                    txtLogin.Text = login;
                    this.ExibirDDD();
                }
            }
            else
            {
                if (Session["Usuario"] != null)
                {
                    login = Request.QueryString["login"];
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
                    if(lblTipoPesquisa.Text == " Login:")
                    {
                        entityPaciente.Login = txtTipoPesquisa.Text.Trim();
                        entityPaciente.IdPaciente = dalCadastroPaciente.FindByIdCurrentPaciente(entityPaciente);
                        resultado = dalCadastroPaciente.FindPacienteByLogin(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Nome:")
                    {
                        entityPaciente.Nome = txtTipoPesquisa.Text.Trim();
                        resultado = dalCadastroPaciente.FindPacienteByNome(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Sobrenome:")
                    {
                        entityPaciente.Sobrenome = txtTipoPesquisa.Text.Trim();
                        resultado = dalCadastroPaciente.FindPacienteBySobrenome(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Data de Nascimento:")
                    {
                        entityPaciente.DataNascimento = Convert.ToDateTime(txtTipoPesquisa.Text);
                        resultado = dalCadastroPaciente.FindPacienteByDataNascimento(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Email:")
                    {
                        entityPaciente.Email = txtTipoPesquisa.Text;
                        resultado = dalCadastroPaciente.FindPacienteByEmail(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " CPF:")
                    {
                        entityPaciente.CPF = Convert.ToInt64(txtTipoPesquisa.Text);
                        resultado = dalCadastroPaciente.FindPacienteByCPF(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " RG:")
                    {
                        entityPaciente.RG = new EntityRG();
                        entityPaciente.RG.Numero = Convert.ToInt64(txtTipoPesquisa.Text);
                        resultado = dalCadastroPaciente.FindPacienteByRG(entityPaciente);
                    }
                    if (resultado) // Se existir Paciente
                    {
                        EntityTelefone entityTelefone1 = new EntityTelefone();
                        EntityTelefone entityTelefone2 = new EntityTelefone();
                        EntityTelefone entityTelefone3 = new EntityTelefone();
                        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();

                        switch (tipoPesquisa)
                        {
                            case "porlogin":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByLogin(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByLogin(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "pornome":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByNome(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByNome(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porsobrenome":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sBySobrenome(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteBySobrenome(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "pordatanascimento":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByDatanascimento(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByDatanascimento(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "poremail":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByEmail(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByEmail(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porcpf":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByCPF(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByCPF(entityPaciente);
                                if (entityPaciente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "porrg":
                                entityPaciente.Endereco = new EntityEndereco();
                                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                                entityPaciente.RG = new EntityRG();

                                entityPaciente = dalCadastroPaciente.FindPacienteById_sByRG(entityPaciente, entityTelefone1);
                                entityPaciente = dalCadastroPaciente.FindAllDataPacienteByRG(entityPaciente);
                                if (entityPaciente == null)
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
                        txtNome.Text = entityPaciente.Nome;
                        txtSobrenome.Text = entityPaciente.Sobrenome;
                        txtEmail.Text = entityPaciente.Email;
                        if (entityPaciente.Sexo.ToString() == "Masculino")
                        {
                            rdbSexo.SelectedValue = "1";
                        }
                        if (entityPaciente.Sexo.ToString() == "Feminino")
                        {
                            rdbSexo.SelectedValue = "2";
                        }

                        if (entityPaciente.EstadoCivil.ToString() == "Solteiro")
                        {
                            rdbEstadoCivil.SelectedValue = "Solteiro";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Casado")
                        {
                            rdbEstadoCivil.SelectedValue = "Casado";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Divorciado")
                        {
                            rdbEstadoCivil.SelectedValue = "Divorciado";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Viúvo")
                        {
                            rdbEstadoCivil.SelectedValue = "Viúvo";
                        }

                        txtDataNascimento.Text = entityPaciente.DataNascimento.ToShortDateString();
                        txtDataNascimento.Text = entityPaciente.DataNascimento.ToString("yyyy-MM-dd");

                        txtCPF.Text = Convert.ToString(entityPaciente.CPF);
                        txtNumeroRG.Text = Convert.ToString(entityPaciente.RG.Numero);
                        txtOrgaoEmissor.Text = Convert.ToString(entityPaciente.RG.OrgaoEmissor);
                        txtDataEmissao.Text = entityPaciente.RG.DataEmissao.ToShortDateString();
                        txtDataEmissao.Text = entityPaciente.RG.DataEmissao.ToString("yyyy-MM-dd");

                        ddlTipoTelefone1.SelectedValue = entityPaciente.Telefone.TipoTelefone;
                        ddlOperadora1.SelectedValue = entityPaciente.Telefone.Operadora;
                        if (ddlOperadora1.DataValueField != string.Empty)
                        {
                            pnlOperadora1.Visible = true;
                        }
                        ddlDDD1.SelectedItem.Text = Convert.ToString(entityPaciente.Telefone.DDD);
                        txtNumeroTelefone1.Text = Convert.ToString(entityPaciente.Telefone.Numero);

                        ddlUF.SelectedValue = Convert.ToString(entityPaciente.Endereco.UF);
                        ddlEstado.SelectedValue = Convert.ToString(entityPaciente.Endereco.Estado);
                        txtCidade.Text = Convert.ToString(entityPaciente.Endereco.Cidade);
                        rdbTipoLogradouro.SelectedValue = Convert.ToString(entityPaciente.Endereco.Logradouro.TipoLogradouro);
                        txtLogradouro.Text = Convert.ToString(entityPaciente.Endereco.Logradouro.Logradouro);
                        txtNumeroEnd.Text = Convert.ToString(entityPaciente.Endereco.Numero);
                        txtBairro.Text = Convert.ToString(entityPaciente.Endereco.Bairro);
                        txtComplemento.Text = Convert.ToString(entityPaciente.Endereco.Complemento);
                        txtCEP.Text = Convert.ToString(entityPaciente.Endereco.CEP);
                    }
                    else
                    {
                        throw new Exception("Não foi encontrado nenhum paciente.");
                    }
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
            catch(ArgumentOutOfRangeException ex)
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

                EntityPaciente entityPaciente = new EntityPaciente();
                entityPaciente.Endereco = new EntityEndereco();
                entityPaciente.Endereco.Logradouro = new EntityLogradouro();
                entityPaciente.RG = new EntityRG();

                EntityTelefone entityTelefone1 = new EntityTelefone();
                EntityTelefone entityTelefone2 = new EntityTelefone();
                EntityTelefone entityTelefone3 = new EntityTelefone();
                DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();

                this.InserirDadosPessoais(entityPaciente);
                this.InserirDocumentos(entityPaciente);
                this.InserirEndereco(entityPaciente);
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
                        entityPaciente = dalCadastroPaciente.FindPacienteById_sByLogin(entityPaciente, entityTelefone1);
                        entityTelefone1.IdTelefone = entityPaciente.Telefone.IdTelefone;
                        dalCadastroPaciente.UpdatePaciente(entityPaciente, entityTelefone1);
                        contatoTelefone = true;
                    }
                    if (qtdTelefone == 2)
                    {
                        entityPaciente = dalCadastroPaciente.FindPacienteById_s(entityPaciente, entityTelefone1, entityTelefone2);
                        
                        dalCadastroPaciente.UpdatePaciente(entityPaciente, entityTelefone1, entityTelefone2);
                        contatoTelefone = true;
                    }
                    if (qtdTelefone == 3)
                    {
                        entityPaciente = dalCadastroPaciente.FindPacienteById_s(entityPaciente, entityTelefone1, entityTelefone2, entityTelefone3);
                        
                        dalCadastroPaciente.UpdatePaciente(entityPaciente, entityTelefone1, entityTelefone2, entityTelefone3);
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
                if(resultado)
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
        private void InserirDadosPessoais(EntityPaciente entityPaciente)
        {
            try
            {
                entityPaciente.Login = txtLogin.Text;

                if (txtCPF.Text != string.Empty)
                {
                    entityPaciente.CPF = Convert.ToInt64(txtCPF.Text);
                }
                if (txtNome.Text != string.Empty)
                {
                    entityPaciente.Nome = txtNome.Text;
                }
                if (txtSobrenome.Text != string.Empty)
                {
                    entityPaciente.Sobrenome = txtSobrenome.Text;
                }
                if (txtEmail.Text != string.Empty)
                {
                    entityPaciente.Email = txtEmail.Text;
                }
                if (rdbSexo.SelectedValue != string.Empty)
                {
                    Int16 sexo = Convert.ToInt16(rdbSexo.SelectedValue);
                    if (sexo == 1) // 1 = Masculino
                    {
                        entityPaciente.Sexo = EnumSexo.Masculino;
                    }
                    if (sexo == 2) // 2 = Feminino
                    {
                        entityPaciente.Sexo = EnumSexo.Feminino;
                    }
                }
                if (rdbEstadoCivil.SelectedValue != string.Empty)
                {
                    string estadoCivil = rdbEstadoCivil.SelectedValue;
                    if (estadoCivil == "Solteiro")
                    {
                        entityPaciente.EstadoCivil = EnumEstadoCivil.Solteiro;
                    }
                    if (estadoCivil == "Casado")
                    {
                        entityPaciente.EstadoCivil = EnumEstadoCivil.Casado;
                    }
                    if (estadoCivil == "Divorciado")
                    {
                        entityPaciente.EstadoCivil = EnumEstadoCivil.Divorciado;
                    }
                    if (estadoCivil == "Viuvo")
                    {
                        entityPaciente.EstadoCivil = EnumEstadoCivil.Viuvo;
                    }
                }
                if (txtDataNascimento.Text != string.Empty)
                {
                    entityPaciente.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);
                }
                else
                {
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
        private void InserirDocumentos(EntityPaciente entityPaciente)
        {
            try
            {
                if (txtNumeroRG.Text != string.Empty)
                {
                    entityPaciente.RG.Numero = Convert.ToInt64(txtNumeroRG.Text);
                }
                if (txtOrgaoEmissor.Text != string.Empty)
                {
                    entityPaciente.RG.OrgaoEmissor = txtOrgaoEmissor.Text;
                }
                if (txtDataEmissao.Text != string.Empty)
                {
                    entityPaciente.RG.DataEmissao = Convert.ToDateTime(txtDataEmissao.Text);
                }
                else
                {
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
        private void InserirEndereco(EntityPaciente entityPaciente)
        {
            try
            {
                if (ddlUF.SelectedValue != string.Empty)
                {
                    entityPaciente.Endereco.UF = ddlUF.SelectedValue;
                }
                if (ddlEstado.Text != string.Empty)
                {
                    entityPaciente.Endereco.Estado = ddlEstado.Text;
                }
                if (txtCidade.Text != string.Empty)
                {
                    entityPaciente.Endereco.Cidade = txtCidade.Text;
                }
                if (txtLogradouro.Text != string.Empty)
                {
                    entityPaciente.Endereco.Logradouro.Logradouro = txtLogradouro.Text;
                }
                if (txtNumeroEnd.Text != string.Empty)
                {
                    entityPaciente.Endereco.Numero = txtNumeroEnd.Text;
                }
                if (rdbTipoLogradouro.SelectedValue != string.Empty)
                {
                    entityPaciente.Endereco.Logradouro.TipoLogradouro = rdbTipoLogradouro.SelectedValue;
                }
                if (txtBairro.Text != string.Empty)
                {
                    entityPaciente.Endereco.Bairro = txtBairro.Text;
                }
                if (txtComplemento.Text != string.Empty)
                {
                    entityPaciente.Endereco.Complemento = txtComplemento.Text;
                }
                if (txtCEP.Text != string.Empty)
                {
                    entityPaciente.Endereco.CEP = Convert.ToInt32(txtCEP.Text);
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