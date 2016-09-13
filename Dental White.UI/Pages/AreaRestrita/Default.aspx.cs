using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalLoginUsuario;
using Dental_White.DAL.Persistence;

namespace Dental_White.UI.Pages.AreaRestrita
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void rdbPerfilUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string textoAdmSistema    = "Perfil Administrador do Sistema: todos os Administradores do Sistema pertencente ao Sistema Único de Cadastro de Colaboradores da Dental White - SUCC. Possuem privilégios de Administradores de todo o sistema.";
            string textoGerenteGestor = "Perfil Gerente de Setor: todos os Gerentes da Dental White que gerenciam cada Setor de forma única e exclusiva. Na sua falta, pode haver delegação de suas atribuições para outro Gestor em caráter temporário.";
            string textoColaboradores = "Perfil Colaborador: todos os Colaboradores da Dental White que possuem, cada um, seus ofícios e atribuições profissionais independentes e harmônicos entre si.";
            string textoClientes      = "Perfil Cliente: todos os Clientes da Dental White que possuem um vínculo com a mesma através da forma de Convênios com algum Plano Odontológico ou Particular.";
            string login;
            bool Ok = false;

            if (Session["Usuario"] == null)
            {
                Ok = true;
                if(Ok)
                {
                    if (rdbPerfilUsuario.SelectedItem.Value == "AdministradorSistema")
                    {
                        lblPerfilUsuario.Text = textoAdmSistema;
                        lblPerfilUsuario.Visible = true;
                        lblPerfilAdmSistema.Text = "Administrador do Sistema";
                        pnlBoxLoginUsuarioAdmSistema.Visible = true;
                        pnlBoxLoginUsuarioGerenteSetor.Visible = false;
                        pnlBoxLoginUsuarioColaborador.Visible = false;
                        pnlBoxLoginUsuarioCliente.Visible = false;
                        txtLoginAdmSistema.Focus();
                    }
                    if (rdbPerfilUsuario.SelectedItem.Value == "GerenteSetor")
                    {
                        lblPerfilUsuario.Text = textoGerenteGestor;
                        lblPerfilUsuario.Visible = true;
                        lblPerfilGerenteSetor.Text = "Gerente de Setor";
                        pnlBoxLoginUsuarioAdmSistema.Visible = false;
                        pnlBoxLoginUsuarioGerenteSetor.Visible = true;
                        pnlBoxLoginUsuarioColaborador.Visible = false;
                        pnlBoxLoginUsuarioCliente.Visible = false;
                        txtLoginGerenteSetor.Focus();
                    }
                    if (rdbPerfilUsuario.SelectedItem.Value == "Colaborador")
                    {
                        lblPerfilUsuario.Text = textoColaboradores;
                        lblPerfilUsuario.Visible = true;
                        lblPerfilColaborador.Text = "Colaborador";
                        pnlBoxLoginUsuarioAdmSistema.Visible = false;
                        pnlBoxLoginUsuarioGerenteSetor.Visible = false;
                        pnlBoxLoginUsuarioColaborador.Visible = true;
                        pnlBoxLoginUsuarioCliente.Visible = false;
                        txtLoginColaborador.Focus();
                    }
                    if (rdbPerfilUsuario.SelectedItem.Value == "Cliente")
                    {
                        lblPerfilUsuario.Text = textoClientes;
                        lblPerfilUsuario.Visible = true;
                        lblPerfilCliente.Text = "Cliente";
                        pnlBoxLoginUsuarioAdmSistema.Visible = false;
                        pnlBoxLoginUsuarioGerenteSetor.Visible = false;
                        pnlBoxLoginUsuarioColaborador.Visible = false;
                        pnlBoxLoginUsuarioCliente.Visible = true;
                        txtLoginCliente.Focus();
                    }
                }
                else
                {
                    Ok = false;
                }
            }
            if(!Ok)
            {
                EntityLoginUsuario usuario = (EntityLoginUsuario)Session["Usuario"];
                if (usuario != null)
                {
                    login = usuario.Login;
                    Response.Redirect("../AdminCliente/ClientePaciente/Default.aspx?login=" + login, false);
                }
            }
        }
        protected void rdbPerfilUsuario_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rdbPerfilUsuario.ClearSelection();
            }
        }
        protected void linkNovoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                string perfil = rdbPerfilUsuario.SelectedValue;
                Response.Redirect("../Usuario/Default.aspx?perfil=" + perfil);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
            catch(Exception ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void linkEsqueceuUsuarioCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string perfil = rdbPerfilUsuario.SelectedValue;
                Response.Redirect("../RecuperacaoUsuario/Default.aspx?perfil=" + perfil);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnLoginCliente_Click(object sender, EventArgs e)
        {
            try
            {
                EntityLoginUsuario entityLoginUsuario = new EntityLoginUsuario();
                DalLoginUsuario dalLoginUsuario = new DalLoginUsuario();
                string perfil = rdbPerfilUsuario.SelectedValue;
                bool resultado;

                entityLoginUsuario.Login = txtLoginCliente.Text;
                entityLoginUsuario.Senha = txtSenhaCliente.Text;
                if(entityLoginUsuario.Login != string.Empty && entityLoginUsuario.Senha != string.Empty)
                {
                    resultado = dalLoginUsuario.FindUsuarioInserted(entityLoginUsuario);
                    if (resultado) // Se usuário (login, senha) existe, logar no sistema
                    {
                        try
                        {
                            entityLoginUsuario = dalLoginUsuario.FindUsuarioByLoginSenha(entityLoginUsuario);
                            string login = entityLoginUsuario.Login;
                            DateTime datacadastro = entityLoginUsuario.DataCadastro;

                            FormsAuthentication.SetAuthCookie(entityLoginUsuario.Login, false); // Sessão
                            Session.Add("Usuario", entityLoginUsuario); // Adiciona usuário na Sessão

                            Response.Redirect("../../Pages/AdminCliente/ClientePaciente/Default.aspx?login=" + login + "&perfil=" + perfil, false);
                        }
                        catch(HttpException ex)
                        {
                            pnlMensagemErro.Visible = true;
                            lblMensagemErro.Text = ex.Message;
                        }
                        catch(ArgumentNullException ex)
                        {
                            pnlMensagemErro.Visible = true;
                            lblMensagemErro.Text = ex.Message;
                        }
                        catch (ArgumentException ex)
                        {
                            pnlMensagemErro.Visible = true;
                            lblMensagemErro.Text = ex.Message;
                        }
                        catch(ApplicationException ex)
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
                    else
                    {
                        pnlMensagemErro.Visible = true;
                        lblMensagemErro.Text = "Usuário não cadastrado no sistema ou Senha inválida.";
                    }
                }
                else
                {
                    pnlMensagemErro.Visible = true;
                }
            }
            catch(Exception ex)
            {
                lblMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void LinkEsqueceuSenhaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                string perfil = rdbPerfilUsuario.SelectedValue;
                Response.Redirect("../RecuperacaoSenha/Default.aspx?perfil=" + perfil);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
            catch (Exception ex)
            {
                lblMensagemErro.Text = ex.Message;
            }
        }
    }
}