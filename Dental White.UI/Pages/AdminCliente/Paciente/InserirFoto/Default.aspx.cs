using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data.SqlClient;
using Dental_White.DAL.Entity.Paciente;
using Dental_White.DAL.Entity.Login;
using Dental_White.DAL.Dal.DalCadastroPaciente;

namespace Dental_White.UI.Pages.AdminCliente.Paciente.InserirFoto
{
    public partial class Default : System.Web.UI.Page
    {
        string path, login, fileExtension, textoErro;
        string novoNomeArquivo = "u_p_";
        bool erro = false;
        EntityPaciente entityPaciente = new EntityPaciente();
        DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                pnlInformacoesArquivos.Visible = false;
                if (!IsPostBack)
                {
                    if (Session["Usuario"] != null)
                    {
                        login = Request.QueryString["login"];
                    }
                }
                else
                {
                    login = Request.QueryString["login"];
                }
            }
            catch (HttpException ex)
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
        protected void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                pnlMensagemErro.Visible = false;
                pnlMensagemSucesso.Visible = false;
                if (FileUploadImagem.HasFile)
                {
                    // BLOQUEIA A TRANSFERÊNCIA DE ARQUIVOS MAIOR QUE 1MB
                    if (FileUploadImagem.PostedFile.ContentLength < 1048576)
                    {
                        Boolean fileOK = false;
                        path = HttpContext.Current.Server.MapPath("/Recursos/fotos/clientes/");
                        if (FileUploadImagem.HasFile)
                        {
                            fileExtension = Path.GetExtension(FileUploadImagem.FileName).ToLower();
                            String[] allowedExtensions = { ".jpeg", ".jpg" };

                            for (int i = 0; i < allowedExtensions.Length; i++)
                            {
                                if (fileExtension == allowedExtensions[i])
                                {
                                    fileOK = true;
                                }
                            }
                        }
                        if (fileOK)
                        {
                            try
                            {
                                novoNomeArquivo += login;
                                
                                if(!Directory.Exists(path))
                                {
                                    Directory.CreateDirectory(path);
                                }
                                else
                                {
                                    if (!File.Exists(novoNomeArquivo))
                                    {
                                        FileUploadImagem.SaveAs(path + novoNomeArquivo + fileExtension);
                                        path = "/Recursos/fotos/clientes/";
                                        entityPaciente.Login = Request.QueryString["login"];
                                        entityPaciente.UrlFoto = path + novoNomeArquivo + fileExtension;
                                        pnlMensagemSucesso.Visible = true;
                                        imgFoto.ImageUrl = entityPaciente.UrlFoto;
                                        dalCadastroPaciente.UpdateFotoPaciente(entityPaciente);
                                        pnlInformacoesArquivos.Visible = true;
                                        lblExtensaoArquivo.Text = fileExtension;
                                        lblTamanhoArquivo.Text = Convert.ToString(FileUploadImagem.PostedFile.ContentLength) + " bytes";
                                        lblCaminhoArquivo.Text = entityPaciente.UrlFoto;
                                        pnlMensagemErro.Visible = false;
                                        this.btnInserir.Attributes.CssStyle.Value = "Position: relative; Top:210px";
                                    }
                                    else
                                    {
                                        throw new Exception("Arquivo de imagem " + novoNomeArquivo + fileExtension + " foi alterado.");
                                    }
                                }
                            }
                            catch (ArgumentNullException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (PathTooLongException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (DirectoryNotFoundException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch(IOException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (UnauthorizedAccessException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (ArgumentException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (NotSupportedException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch(HttpException ex)
                            {
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                            catch (Exception ex)
                            {
                                // MENSAGEM INFORMATIVA PARA O USUÁRIO
                                lblMensagemErro.Text = ex.Message;
                                pnlMensagemErro.Visible = true;
                            }
                        }
                        else
                        {
                            // MENSAGEM INFORMATIVA PARA O USUÁRIO
                            throw new Exception("Só poderá carregar imagens neste campo.");
                            pnlMensagemErro.Visible = true;
                        }
                    }
                    else
                    {
                        // MENSAGEM INFORMATIVA PARA O USUÁRIO
                        throw new Exception("Limite máximo para a imagem é de 1MB.");
                        pnlMensagemErro.Visible = true;
                    }
                }
                else
                {
                    throw new Exception("Imagem não foi selecionada.");
                    pnlMensagemErro.Visible = true;
                }
            }
            catch (ArgumentException ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
            catch (HttpException ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
            catch (Exception ex)
            {
                lblMensagemErro.Text = ex.Message;
                pnlMensagemErro.Visible = true;
            }
            if(erro)
            {
                lblMensagemErro.Text = textoErro;
                pnlMensagemErro.Visible = true;
            }
        }
        protected void imgFoto_Load(object sender, EventArgs e)
        {
            try
            {
                if(pnlInformacoesArquivos.Visible == false)
                {
                    this.btnInserir.Attributes.CssStyle.Value = "Position: relative; Top:340px";
                }
                if (!IsPostBack)
                {
                    string UrlFoto;
                    bool resultado;
                    EntityPaciente entityPaciente = new EntityPaciente();
                    DalCadastroPaciente dalCadastroPaciente = new DalCadastroPaciente();

                    entityPaciente.Login = Request.QueryString["login"];
                    path = HttpContext.Current.Server.MapPath("/Recursos/fotos/clientes/");
                    entityPaciente.IdPaciente = dalCadastroPaciente.FindByIdCurrentPaciente(entityPaciente);
                    resultado = dalCadastroPaciente.FindPacienteByLogin(entityPaciente);
                    if (!resultado)
                    {
                        FileUploadImagem.Enabled = false;
                        throw new Exception("É necessário que você cadastre seus dados pessoais para que possa inserir/visualizar sua foto.");
                    }
                    else
                    {
                        FileUploadImagem.Enabled = true;
                        entityPaciente.UrlFoto = dalCadastroPaciente.FindFotoPaciente(entityPaciente);
                        if(entityPaciente.UrlFoto == null || entityPaciente.UrlFoto == string.Empty)
                        {
                            throw new Exception("Foto não foi carregada ou não existe foto cadastrada.");
                        }
                        else
                        {
                            imgFoto.ImageUrl = entityPaciente.UrlFoto;
                            imgFoto.ResolveUrl(imgFoto.ImageUrl);
                            imgFoto.DataBind();
                        }
                    }
                }
            }
            catch (ArgumentNullException ex)
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