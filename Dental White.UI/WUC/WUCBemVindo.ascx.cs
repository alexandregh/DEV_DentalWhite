using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Dental_White.DAL.Entity.Login;

namespace Dental_White.UI.WUC
{
    public partial class WUCBemVindo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usuario"] != null) // se existir uma Session ativa
                {
                    EntityLoginUsuario usuario = (EntityLoginUsuario)Session["Usuario"];
                    txtVisitante.Text = usuario.Login;
                    txtPerfil.Text = usuario.Perfil;
                    pnlPerfilLogout.Visible = true;
                }
            }
        }

        protected void linkLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Session.Remove("Usuario");
            Response.Redirect("~/Default.aspx", false);
        }
    }
}