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

namespace Dental_White.UI.Template
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string login;
        DalLoginUsuario dalLoginUsuario = new DalLoginUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LinkGerenciarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                EntityLoginUsuario usuario = (EntityLoginUsuario)Session["Usuario"];
                if (usuario != null)
                {
                    login = usuario.Login;
                    Response.Redirect("Pages/AdminCliente/ClientePaciente/Default.aspx?login=" + login, false);
                }
            }
            catch (ApplicationException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (HttpException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (ArgumentNullException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Ocorreu o seguinte erro: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
        }
    }
}