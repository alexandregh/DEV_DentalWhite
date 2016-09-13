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

namespace Dental_White.UI.Pages.AdminCliente.Paciente.ConsultarPaciente
{
    public partial class Default : System.Web.UI.Page
    {
        string login;
        bool resultado = false;
        string str;
        EntityPaciente entityPaciente = new EntityPaciente();
        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlMensagemErro.Visible = false;
            if (!IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    login = Request.QueryString["login"];
                    txtLogin.Text = login;
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
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "pornome")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Nome:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 50;
                        txtTipoPesquisa.ToolTip = "Digite Nome...";
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porsobrenome")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Sobrenome:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 80;
                        txtTipoPesquisa.ToolTip = "Digite Sobrenome...";
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "pordatanascimento")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Data de Nascimento:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 10;
                        txtTipoPesquisa.ToolTip = "Digite Data de Nascimento...";
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "poremail")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " Email:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 50;
                        txtTipoPesquisa.ToolTip = "Digite Email...";
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porcpf")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " CPF:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 11;
                        txtTipoPesquisa.ToolTip = "Digite CPF...";
                        pnlConsultarPaciente.Visible = false;
                    }
                    else if (ddlTipoPesquisa.SelectedValue == "porrg")
                    {
                        pnlTipoPesquisa.Visible = true;
                        lblTipoPesquisa.Text = " RG:";
                        txtTipoPesquisa.Focus();
                        txtTipoPesquisa.Text = string.Empty;
                        txtTipoPesquisa.MaxLength = 10;
                        txtTipoPesquisa.ToolTip = "Digite RG...";
                        pnlConsultarPaciente.Visible = false;
                    }
                }
                else
                {
                    pnlTipoPesquisa.Visible = false;
                    pnlConsultarPaciente.Visible = false;
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
                pnlConsultarPaciente.Visible = false;
                string tipoPesquisa = ddlTipoPesquisa.SelectedValue;

                if (tipoPesquisa != string.Empty)
                {
                    if (lblTipoPesquisa.Text == " Login:")
                    {
                        entityPaciente.Login = txtTipoPesquisa.Text.Trim();
                        login = Request.QueryString["login"];
                        if(entityPaciente.Login != login)
                        {
                            throw new Exception("Sua pesquisa por Login não pode ser efetuada. Informe seu Login de Usuário.");
                        }
                        entityPaciente.IdPaciente = dalCadastroPaciente.FindByIdCurrentPaciente(entityPaciente);
                        resultado = dalCadastroPaciente.FindPacienteByLogin(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Nome:")
                    {
                        entityPaciente.Nome = txtTipoPesquisa.Text.Trim();
                        entityPaciente.Login = login;
                        resultado = dalCadastroPaciente.FindPacienteByNome(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Sobrenome:")
                    {
                        entityPaciente.Sobrenome = txtTipoPesquisa.Text.Trim();
                        entityPaciente.Login = login;
                        resultado = dalCadastroPaciente.FindPacienteBySobrenome(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Data de Nascimento:")
                    {
                        entityPaciente.DataNascimento = Convert.ToDateTime(txtTipoPesquisa.Text);
                        entityPaciente.Login = login;
                        resultado = dalCadastroPaciente.FindPacienteByDataNascimento(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " Email:")
                    {
                        entityPaciente.Email = txtTipoPesquisa.Text;
                        entityPaciente.Login = login;
                        resultado = dalCadastroPaciente.FindPacienteByEmail(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " CPF:")
                    {
                        entityPaciente.CPF = Convert.ToInt64(txtTipoPesquisa.Text);
                        entityPaciente.Login = login;
                        resultado = dalCadastroPaciente.FindPacienteByCPF(entityPaciente);
                    }
                    if (lblTipoPesquisa.Text == " RG:")
                    {
                        entityPaciente.RG = new EntityRG();
                        entityPaciente.RG.Numero = Convert.ToInt64(txtTipoPesquisa.Text);
                        entityPaciente.Login = login;
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
                                entityPaciente.Telefone = new EntityTelefone();
                                
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
                                entityPaciente.Telefone = new EntityTelefone();

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
                                entityPaciente.Telefone = new EntityTelefone();
                                
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
                                entityPaciente.Telefone = new EntityTelefone();
                                
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
                                entityPaciente.Telefone = new EntityTelefone();
                                
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
                                entityPaciente.Telefone = new EntityTelefone();
                                
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
                                entityPaciente.Telefone = new EntityTelefone();

                                entityPaciente.RG.Numero = Convert.ToInt64(txtTipoPesquisa.Text);
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
                        pnlConsultarPaciente.Visible = true;
                        lblNome.Text = " " + entityPaciente.Nome;
                        lblSobrenome.Text = " " + entityPaciente.Sobrenome;
                        lblEmail.Text = " " + entityPaciente.Email;
                        if (entityPaciente.Sexo.ToString() == "Masculino")
                        {
                            lblSexo.Text = " Masculino";
                        }
                        if (entityPaciente.Sexo.ToString() == "Feminino")
                        {
                            lblSexo.Text = " Feminino";
                        }

                        if (entityPaciente.EstadoCivil.ToString() == "Solteiro")
                        {
                            lblEstadoCivil.Text = " Solteiro";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Casado")
                        {
                            lblEstadoCivil.Text = " Casado";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Divorciado")
                        {
                            lblEstadoCivil.Text = " Divorciado";
                        }
                        if (entityPaciente.EstadoCivil.ToString() == "Viúvo")
                        {
                            lblEstadoCivil.Text = " Viúvo";
                        }

                        lblDataNascimento.Text = Convert.ToString(entityPaciente.DataNascimento.ToShortDateString());

                        lblCPF.Text = Convert.ToString(entityPaciente.CPF);
                        str = lblCPF.Text;
                        short qtdCPF = Convert.ToSByte(str.Length);
                        for (short i = 1; i <= qtdCPF; i++)
                        {
                            if(i == 3 || i == 7 || i == 11)
                            {
                                lblCPF.Text = lblCPF.Text.Insert(i, ".");
                            }
                            if(i == 12)
                            {
                                lblCPF.Text = lblCPF.Text.Insert(i, "-");
                            }
                        }

                        lblNumeroRG.Text = Convert.ToString(entityPaciente.RG.Numero);
                        lblOrgaoEmissor.Text = Convert.ToString(entityPaciente.RG.OrgaoEmissor);
                        lblDataEmissao.Text = Convert.ToString(entityPaciente.RG.DataEmissao.ToShortDateString());

                        lblTipoTelefone1.Text = entityPaciente.Telefone.TipoTelefone;
                        lblOperadora1.Text = entityPaciente.Telefone.Operadora;
                        if (lblOperadora1.Text != string.Empty)
                        {
                            pnlOperadora1.Visible = true;
                        }
                        lblDDD1.Text = Convert.ToString(entityPaciente.Telefone.DDD);
                        lblNumeroTel1.Text = Convert.ToString(entityPaciente.Telefone.Numero);
                        str = lblNumeroTel1.Text;
                        if (str.Length == 8)
                        {
                            lblNumeroTel1.Text = lblNumeroTel1.Text.Insert(4, "-");
                        }
                        if (str.Length == 9)
                        {
                            lblNumeroTel1.Text = lblNumeroTel1.Text.Insert(5, "-");
                        }

                        lblUF.Text = Convert.ToString(entityPaciente.Endereco.UF);
                        lblEstado.Text = Convert.ToString(entityPaciente.Endereco.Estado);
                        lblCidade.Text = Convert.ToString(entityPaciente.Endereco.Cidade);
                        lblTipoLogradouro.Text = Convert.ToString(entityPaciente.Endereco.Logradouro.TipoLogradouro);
                        lblLogradouro.Text = Convert.ToString(entityPaciente.Endereco.Logradouro.Logradouro);
                        lblNumeroEnd.Text = Convert.ToString(entityPaciente.Endereco.Numero);
                        lblBairro.Text = Convert.ToString(entityPaciente.Endereco.Bairro);
                        lblComplemento.Text = Convert.ToString(entityPaciente.Endereco.Complemento);
                        lblCEP.Text = Convert.ToString(entityPaciente.Endereco.CEP);
                        str = lblCEP.Text;
                        short qtdCEP = Convert.ToSByte(str.Length);
                        for (short i = 1; i <= qtdCEP; i++)
                        {
                            if (i == 5)
                            {
                                lblCEP.Text = lblCEP.Text.Insert(i, "-");
                            }
                        }
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