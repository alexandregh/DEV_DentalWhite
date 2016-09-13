using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dental_White.DAL.Persistence;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalLoginUsuario;

namespace Dental_White.UI.Pages.Usuario
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }
        protected void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string login = txtLogin.Text;
                string senha = txtSenha.Text;
                string confirmacaoSenha= txtConfirmacaoSenha.Text;

                if(login == string.Empty || senha == string.Empty || confirmacaoSenha == string.Empty)
                {
                    pnlMensagemErro.Visible = true;
                }
                else if(senha != confirmacaoSenha)
                {
                    pnlMensagemErro.Visible = true;
                }
                else
                {
                    pnlMensagemErro.Visible = false;
                    EntityLoginUsuario entityLoginUsuario = new EntityLoginUsuario();
                    DalLoginUsuario dalLoginUsuario = new DalLoginUsuario();
                    bool resultado;

                    entityLoginUsuario.Login = login;
                    resultado = dalLoginUsuario.FindLoginUsuarioExists(entityLoginUsuario.Login);
                    if(resultado) // Se existir Usuário já cadastrado
                    {
                        pnlMensagemErro.Visible = true;
                        lblMensagemErro.Text = "Usuário já cadastrado.";
                    }
                    else
                    {
                        entityLoginUsuario.Login = txtLogin.Text;
                        entityLoginUsuario.Senha = txtSenha.Text;
                        entityLoginUsuario.DataCadastro = DateTime.Now;
                        entityLoginUsuario.Perfil = Request.QueryString["perfil"];

                        dalLoginUsuario.InsertLoginUsuario(entityLoginUsuario);
                        pnlMensagemSucesso.Visible = true;
                    }
                }
            }
            catch(Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
    }
}