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

namespace Dental_White.UI.Pages.AdminClientePaciente.Dependente.Cadastro
{
    public partial class Default : System.Web.UI.Page
    {
        string login;
        bool erros = false;
        string str;
        DalDDD dalUFEstado = new DalDDD();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            if (!IsPostBack)
            {
                txtNumeroTelefone1.Enabled = false;
                txtNumeroTelefone2.Enabled = false;
                txtNumeroTelefone3.Enabled = false;
                ddlDDD1.Enabled = false;
                ddlDDD2.Enabled = false;
                ddlDDD3.Enabled = false;
                if (Session["Usuario"] != null)
                {
                    login = Request.QueryString["login"];
                    this.ExibirDDD();
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
        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                bool resultado = false;
                int qtdTelefone = 0;
                pnlMensagemErro.Visible = false;

                EntityDependente entityDependente = new EntityDependente();
                entityDependente.Endereco = new EntityEndereco();
                entityDependente.Endereco.Logradouro = new EntityLogradouro();
                entityDependente.RG = new EntityRG();
                entityDependente.GrauParentesco = new EntityGrauParentesco();
                EntityPaciente entityPaciente = new EntityPaciente();

                EntityTelefone entityTelefone1 = new EntityTelefone();
                EntityTelefone entityTelefone2 = new EntityTelefone();
                EntityTelefone entityTelefone3 = new EntityTelefone();
                DalCadastroDependente dalCadastroDependente = new DalCadastroDependente();

                this.InserirDadosPessoais(entityDependente);
                if (erros != true) // Se não existir erros...
                {
                    resultado = dalCadastroDependente.FindDependenteByNome(entityDependente);
                    if (resultado) // Se existir Paciente já cadastrado
                    {
                        pnlMensagemErro.Visible = true;
                        lblMensagemErro.Text = "Dependente já cadastrado.";
                    }
                    else
                    {
                        this.InserirDocumentos(entityDependente);

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

                        this.InserirEndereco(entityDependente); // Contém todas as informações do Paciente, Endereço e Logradouro

                        if (erros)
                        {
                            pnlMensagemErro.Visible = true;
                            throw new Exception("Opção Inválida.");
                        }
                        else
                        {
                            bool contatoTelefone = false;
                            if (qtdTelefone == 1)
                            {
                                if (Session["Usuario"] != null)
                                {
                                    entityPaciente.Login = Request.QueryString["login"];
                                }
                                entityPaciente = dalCadastroDependente.FindIdMyPaciente(entityPaciente);
                                if(entityPaciente != null)
                                {
                                    entityDependente.IdPaciente = entityPaciente.IdPaciente;
                                    dalCadastroDependente.InsertDependente(entityDependente, entityTelefone1);
                                    contatoTelefone = true;
                                    resultado = true;
                                }
                                else
                                {
                                    throw new Exception("O sistema não pode encontrar o Paciente (Titular).");
                                }
                            }
                            if (qtdTelefone == 2)
                            {
                                if (Session["Usuario"] != null)
                                {
                                    entityPaciente.Login = Request.QueryString["login"];
                                }
                                entityPaciente = dalCadastroDependente.FindIdMyPaciente(entityPaciente);
                                if (entityPaciente != null)
                                {
                                    entityDependente.IdPaciente = entityPaciente.IdPaciente;
                                    dalCadastroDependente.InsertDependente(entityDependente, entityTelefone1, entityTelefone2);
                                    contatoTelefone = true;
                                    resultado = true;
                                }
                                else
                                {
                                    throw new Exception("O sistema não pode encontrar o Paciente (Titular).");
                                }
                            }
                            if (qtdTelefone == 3)
                            {
                                if (Session["Usuario"] != null)
                                {
                                    entityPaciente.Login = Request.QueryString["login"];
                                }
                                entityPaciente = dalCadastroDependente.FindIdMyPaciente(entityPaciente);
                                if (entityPaciente != null)
                                {
                                    entityDependente.IdPaciente = entityPaciente.IdPaciente;
                                    dalCadastroDependente.InsertDependente(entityDependente, entityTelefone1, entityTelefone2, entityTelefone3);
                                    contatoTelefone = true;
                                    resultado = true;
                                }
                                else
                                {
                                    throw new Exception("O sistema não pode encontrar o Paciente (Titular).");
                                }
                            }
                            else
                            {
                                if (!contatoTelefone)
                                {
                                    throw new Exception("Pelo menos uma forma de Contato de Telefone deverá ser cadastrada.");
                                }
                            }
                            if (contatoTelefone)
                            {
                                pnlMensagemSucesso.Visible = true;
                            }
                        }
                        if (resultado)
                        {
                            pnlMensagemSucesso.Visible = true;
                        }
                    }
                }
                else
                {
                    this.RenderizarCamposFormulario();
                    pnlMensagemErro.Visible = true;
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
                //entityDependente.Login = txtLogin.Text;
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
                //else
                //{
                //    erros = true;
                //}
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
                //else
                //{
                //    //erros = true;
                //}
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
                //else
                //{
                //    erros = true;
                //}
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