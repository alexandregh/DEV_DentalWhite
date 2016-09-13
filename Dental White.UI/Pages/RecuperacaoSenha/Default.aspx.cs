using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalCadastroPaciente;
using Dental_White.DAL.Dal.DalLoginUsuario;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.RecuperacaoSenha
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtUsuario.Focus();
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                lblMeuUsuario.Visible = false;
            }
            else
            {
                pnlMensagemSucesso.Visible = false;
                pnlMensagemErro.Visible = true;
                RequiredFieldValidatorUsuario.Visible = true;
                RequiredFieldValidatorUsuario.Display = ValidatorDisplay.Dynamic;
                RequiredFieldValidatorUsuario.Text = "*";
                txtUsuario.Focus();
            }
        }
        protected void btnRecuperarSenha_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                if (txtUsuario.Text != string.Empty || txtPerfil.Text != string.Empty)
                {
                    EntityLoginUsuario entityLoginUsuario = new EntityLoginUsuario();
                    DalLoginUsuario dalLoginUsuario = new DalLoginUsuario();
                    bool senhaExists;

                    entityLoginUsuario.Login = txtUsuario.Text;
                    senhaExists = dalLoginUsuario.FindSenhaUsuarioExists(entityLoginUsuario);
                    if (!senhaExists)
                    {
                        pnlRecuperacaoSenha.Visible = false;
                        pnlMensagemErro.Visible = true;
                        lblMensagemErro.Text = "Senha não está cadastrada no sistema.";
                        txtSenha.Focus();
                    }
                    else
                    {
                        pnlRecuperacaoSenha.Visible = true;
                        pnlMensagemErro.Visible = false;
                        lblSenhaEncontrada.Text = "Senha foi encontrada no sistema.";
                        txtSenha.Focus();
                    }   
                }
                else
                {
                    if (!IsPostBack)
                    {
                        if(txtUsuario.Text == string.Empty)
                        {
                            pnlMensagemSucesso.Visible = false;
                            pnlMensagemErro.Visible = true;
                            RequiredFieldValidatorSenha.Visible = true;
                            RequiredFieldValidatorSenha.Display = ValidatorDisplay.Dynamic;
                            RequiredFieldValidatorSenha.Text = "*";
                            lblMensagemErro.Text = "Campo Usuário é obrigatório.";
                            txtUsuario.Focus();
                        }
                        if (txtPerfil.Text == string.Empty)
                        {
                            pnlMensagemSucesso.Visible = false;
                            pnlMensagemErro.Visible = true;
                            RequiredFieldValidatorSenha.Visible = true;
                            RequiredFieldValidatorSenha.Display = ValidatorDisplay.Dynamic;
                            RequiredFieldValidatorSenha.Text = "*";
                            lblMensagemErro.Text = "Campo Perfil é obrigatório.";
                            txtPerfil.Focus();
                        }
                    }
                    else
                    {
                        if (txtUsuario.Text == string.Empty)
                        {
                            pnlMensagemSucesso.Visible = false;
                            pnlMensagemErro.Visible = true;
                            RequiredFieldValidatorSenha.Visible = true;
                            RequiredFieldValidatorSenha.Display = ValidatorDisplay.Dynamic;
                            RequiredFieldValidatorSenha.Text = "*";
                            lblMensagemErro.Text = "Campo Usuário é obrigatório.";
                            txtUsuario.Focus();
                        }
                        if (txtPerfil.Text == string.Empty)
                        {
                            pnlMensagemSucesso.Visible = false;
                            pnlMensagemErro.Visible = true;
                            RequiredFieldValidatorSenha.Visible = true;
                            RequiredFieldValidatorSenha.Display = ValidatorDisplay.Dynamic;
                            RequiredFieldValidatorSenha.Text = "*";
                            lblMensagemErro.Text = "Campo txtPerfil é obrigatório.";
                            txtPerfil.Focus();
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
            catch (ArgumentNullException ex)
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
        protected void btnLimparTela_Click(object sender, EventArgs e)
        {
            pnlMensagemErro.Visible = false;
            pnlMensagemSucesso.Visible = false;
            lblMeuUsuario.Visible = false;
            txtUsuario.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtConfirmacaoSenha.Text = string.Empty;
            lblSenhaEncontrada.Text = string.Empty;
            pnlRecuperacaoSenha.Visible = false;
            RequiredFieldValidatorUsuario.Visible = false;
            txtUsuario.Focus();
        }
    }
}