using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Entity.Especialidade;
using Dental_White.DAL.Dal.DalEspecialidade;

namespace Dental_White.UI.Pages.Servicos.Especialidades
{
    public partial class Default : System.Web.UI.Page
    {
        string login;
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
        protected void LinkVoltar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityLoginUsuario usuario = (EntityLoginUsuario)Session["Usuario"];
                if(usuario != null)
                {
                    login = usuario.Login;
                    Response.Redirect("../../../../Default.aspx?login=" + login, false);
                }
                else
                {
                    Response.Redirect("../../../../Default.aspx", false);
                }
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
        protected void ddlEspecialidade_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    DalEspecialidade dalEspecialidade = new DalEspecialidade();
                    ddlEspecialidade.DataSource = dalEspecialidade.GetEspecialidadeByNome();
                    ddlEspecialidade.DataValueField = "IdEspecialidade";
                    ddlEspecialidade.DataTextField = "Nome";
                    ddlEspecialidade.DataBind();
                    ddlEspecialidade.Items.Insert(0, new ListItem("-Selecione-", "0"));
                }
            }
            catch (Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void ddlEspecialidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                pnlEspecialidade.Visible = false;
                btnConsultar.Focus();
            }
            catch(Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                EntityEspecialidade entityEspecialidade = new EntityEspecialidade();
                DalEspecialidade dalEspecialidade = new DalEspecialidade();
                int IdEspecialidade;

                IdEspecialidade = Convert.ToInt32(ddlEspecialidade.SelectedIndex);
                entityEspecialidade = dalEspecialidade.GetDataEspecialidade(IdEspecialidade);
                pnlEspecialidade.Visible = true;
                lblNomeEspecialidade.Text = entityEspecialidade.Nome;
                lblDescricaoEspecialidade.Text = entityEspecialidade.Descricao;
            }
            catch(Exception ex)
            {
                pnlMensagemErro.Visible = true;
                lblMensagemErro.Text = ex.Message;
            }
        }
    }
}