using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Dal.DalCadastroPaciente;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.RecuperacaoUsuario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmailCPF.Focus();
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                lblMeuUsuario.Visible = false;
            }
            else
            {
                pnlMensagemSucesso.Visible = false;
                pnlMensagemErro.Visible = true;
                RequiredFieldValidatorEmailCPF.Visible = true;
                RequiredFieldValidatorEmailCPF.Display = ValidatorDisplay.Dynamic;
                RequiredFieldValidatorEmailCPF.Text = "*";
                txtEmailCPF.Focus();
            }
        }
        protected void btnRecuperarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                if (txtEmailCPF.Text != string.Empty)
                {
                    if (txtEmailCPF.Text.Contains("@")) // Pesquisa foi feita pelo Email
                    {
                        EntityPaciente entityPaciente = new EntityPaciente();
                        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();
                        string meuLogin;

                        entityPaciente.Email = txtEmailCPF.Text;
                        meuLogin = dalCadastroPaciente.FindPacienteByEmailCPF(entityPaciente);
                        if(meuLogin == null)
                        {
                            pnlMensagemErro.Visible = true;
                            lblMeuUsuario.Text = string.Empty;
                            lblMeuUsuario.Visible = false;
                            lblMensagemErro.Text = "Usuário não cadastrado no sistema ou ainda não cadastrado no sistema como um cliente (Paciente ou Dependente).";
                        }
                        else
                        {
                            pnlMensagemErro.Visible = false;
                            pnlMensagemSucesso.Visible = true;
                            lblMeuUsuario.Visible = true;
                            lblMeuUsuario.Text = "Seu Usuário é: " + meuLogin;
                        }
                    }
                    else // Pesquisa foi feita pelo CPF
                    {
                        EntityPaciente entityPaciente = new EntityPaciente();
                        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();
                        string meuLogin;

                        entityPaciente.CPF = Convert.ToInt64(txtEmailCPF.Text);
                        meuLogin = dalCadastroPaciente.FindPacienteByEmailCPF(entityPaciente);
                        if (meuLogin == null)
                        {
                            pnlMensagemErro.Visible = true;
                            lblMensagemErro.Text = "Usuário não está cadastrado no sistema.";
                        }
                        else
                        {
                            pnlMensagemSucesso.Visible = true;
                            lblMeuUsuario.Visible = true;
                            lblMeuUsuario.Text = "Seu Usuário é: " + meuLogin;
                        }
                    }
                }
                else
                {
                    if (!IsPostBack)
                    {
                        pnlMensagemSucesso.Visible = false;
                        pnlMensagemErro.Visible = true;
                        RequiredFieldValidatorEmailCPF.Visible = true;
                        RequiredFieldValidatorEmailCPF.Display = ValidatorDisplay.Dynamic;
                        RequiredFieldValidatorEmailCPF.Text = "*";
                        lblMensagemErro.Text = "Campo Email ou CPF é obrigatório.";
                        txtEmailCPF.Focus();
                    }
                    else
                    {
                        pnlMensagemSucesso.Visible = false;
                        pnlMensagemErro.Visible = true;
                        RequiredFieldValidatorEmailCPF.Visible = true;
                        RequiredFieldValidatorEmailCPF.Display = ValidatorDisplay.Dynamic;
                        RequiredFieldValidatorEmailCPF.Text = "*";
                        lblMensagemErro.Text = "Campo Email ou CPF é obrigatório.";
                        txtEmailCPF.Focus();
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
            catch(ArgumentNullException ex)
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
        protected void btnLimparTela_Click(object sender, EventArgs e)
        {
            pnlMensagemErro.Visible = false;
            pnlMensagemSucesso.Visible = false;
            lblMeuUsuario.Visible = false;
            txtEmailCPF.Text = string.Empty;
            RequiredFieldValidatorEmailCPF.Visible = false;
            txtEmailCPF.Focus();
        }
    }
}