using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Dependente;
using Dental_White.DAL.Entity.GrauParentesco;
using Dental_White.DAL.Entity.RG;
using Dental_White.DAL.Entity.Telefone;
using Dental_White.DAL.Entity.Logradouro;
using Dental_White.DAL.Entity.Endereco;
using Dental_White.DAL.Entity.Sexo;
using Dental_White.DAL.Entity.EstadoCivil;
using Dental_White.DAL.Entity.DDD;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalDDD;
using Dental_White.DAL.Dal.DalCadastroDependente;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.AdminCliente.Dependente.AtualizarDependente
{
    public partial class Default : System.Web.UI.Page
    {
        string login;
        bool resultado = false;
        string str;
        EntityDependente entityDependente = new EntityDependente();
        DalCadastroDependente dalCadastroDependente = new DalCadastroDependente();
        protected void Page_Load(object sender, EventArgs e)
        {
            pnlMensagemErro.Visible = false;
            if (!IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    login = Request.QueryString["login"];
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
                pnlMensagemErro.Visible = false;
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
                    if (resultado) // Se existir Paciente
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByLogin(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByLogin(entityDependente);
                                if (entityDependente == null)
                                {
                                    throw new Exception("O paciente não pode ser encontrado.");
                                }
                                else
                                {
                                    break;
                                }
                            case "pornome":
                                entityDependente.Endereco = new EntityEndereco();
                                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                                entityDependente.RG = new EntityRG();
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByNome(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByNome(entityDependente);
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sBySobrenome(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteBySobrenome(entityDependente);
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByDatanascimento(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByDatanascimento(entityDependente);
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByEmail(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByEmail(entityDependente);
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByCPF(entityDependente, entityTelefone1);
                                entityDependente = dalCadastroDependente.FindAllDataDependenteByCPF(entityDependente);
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
                                entityDependente.GrauParentesco = new EntityGrauParentesco();

                                entityDependente = dalCadastroDependente.FindDependenteById_sByRG(entityDependente, entityTelefone1);
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
                        pnlConsultarPaciente.Visible = true;
                        lblNome.Text = " " + entityDependente.Nome;
                        lblSobrenome.Text = " " + entityDependente.Sobrenome;
                        lblEmail.Text = " " + entityDependente.Email;
                        if (entityDependente.Sexo.ToString() == "Masculino")
                        {
                            lblSexo.Text = " Masculino";
                        }
                        if (entityDependente.Sexo.ToString() == "Feminino")
                        {
                            lblSexo.Text = " Feminino";
                        }

                        if (entityDependente.EstadoCivil.ToString() == "Solteiro")
                        {
                            lblEstadoCivil.Text = " Solteiro";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Casado")
                        {
                            lblEstadoCivil.Text = " Casado";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Divorciado")
                        {
                            lblEstadoCivil.Text = " Divorciado";
                        }
                        if (entityDependente.EstadoCivil.ToString() == "Viúvo")
                        {
                            lblEstadoCivil.Text = " Viúvo";
                        }

                        lblDataNascimento.Text = Convert.ToString(entityDependente.DataNascimento.ToShortDateString());

                        lblCPF.Text = Convert.ToString(entityDependente.CPF);
                        str = lblCPF.Text;
                        short qtdCPF = Convert.ToSByte(str.Length);
                        for (short i = 1; i <= qtdCPF; i++)
                        {
                            if (i == 3 || i == 7 || i == 11)
                            {
                                lblCPF.Text = lblCPF.Text.Insert(i, ".");
                            }
                            if (i == 12)
                            {
                                lblCPF.Text = lblCPF.Text.Insert(i, "-");
                            }
                        }

                        lblNumeroRG.Text = Convert.ToString(entityDependente.RG.Numero);
                        lblOrgaoEmissor.Text = Convert.ToString(entityDependente.RG.OrgaoEmissor);
                        lblDataEmissao.Text = " " + Convert.ToString(entityDependente.RG.DataEmissao.ToShortDateString());

                        lblNivelGrauParentesco.Text = Convert.ToString(entityDependente.GrauParentesco.NivelGrauParentesco);
                        if (lblNivelGrauParentesco.Text == "conjuge")
                        {
                            lblNivelGrauParentesco.Text = "Cônjuge";
                        }
                        if (lblNivelGrauParentesco.Text == "filhosenteados")
                        {
                            lblNivelGrauParentesco.Text = "Filhos(as) / Enteados(as)";
                        }
                        if (lblNivelGrauParentesco.Text == "paimae")
                        {
                            lblNivelGrauParentesco.Text = "Pai / Mãe";
                        }
                        txtDescricaoGrauParentesco.Text = Convert.ToString(entityDependente.GrauParentesco.DescricaoGrauParentesco);

                        lblTipoTelefone1.Text = entityDependente.Telefone.TipoTelefone;
                        lblOperadora1.Text = entityDependente.Telefone.Operadora;
                        if (lblOperadora1.Text != string.Empty)
                        {
                            pnlOperadora1.Visible = true;
                        }
                        lblDDD1.Text = Convert.ToString(entityDependente.Telefone.DDD);
                        lblNumeroTel1.Text = Convert.ToString(entityDependente.Telefone.Numero);
                        str = lblNumeroTel1.Text;
                        if (str.Length == 8)
                        {
                            lblNumeroTel1.Text = lblNumeroTel1.Text.Insert(4, "-");
                        }
                        if (str.Length == 9)
                        {
                            lblNumeroTel1.Text = lblNumeroTel1.Text.Insert(5, "-");
                        }

                        lblUF.Text = Convert.ToString(entityDependente.Endereco.UF);
                        lblEstado.Text = Convert.ToString(entityDependente.Endereco.Estado);
                        lblCidade.Text = Convert.ToString(entityDependente.Endereco.Cidade);
                        lblTipoLogradouro.Text = Convert.ToString(entityDependente.Endereco.Logradouro.TipoLogradouro);
                        lblLogradouro.Text = Convert.ToString(entityDependente.Endereco.Logradouro.Logradouro);
                        lblNumeroEnd.Text = Convert.ToString(entityDependente.Endereco.Numero);
                        lblBairro.Text = Convert.ToString(entityDependente.Endereco.Bairro);
                        lblComplemento.Text = Convert.ToString(entityDependente.Endereco.Complemento);
                        lblCEP.Text = Convert.ToString(entityDependente.Endereco.CEP);
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
                        if (tipoPesquisa == "porlogin")
                        {
                            throw new Exception("O Dependente ainda não pode ser encontrado pelo Login. Tente outra forma de pesquisa.");
                        }
                        if (tipoPesquisa == "pornome")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
                        if (tipoPesquisa == "porsobrenome")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
                        if (tipoPesquisa == "pordatanascimento")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
                        if (tipoPesquisa == "poremail")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
                        if (tipoPesquisa == "porcpf")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
                        if (tipoPesquisa == "porrg")
                        {
                            throw new Exception("O Dependente atualmente pode não estar cadastrado no sistema pelo seu Titular. É necessário que seu Titular cadastre seus dados no sistema.<br /><br />Informe no campo de pesquisa apenas os seus dados de Dependente.");
                        }
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