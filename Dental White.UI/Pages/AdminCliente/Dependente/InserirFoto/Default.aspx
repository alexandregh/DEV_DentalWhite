<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.AdminCliente.Dependente.InserirFoto.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../../../Recursos/css/cssreset/cssreset.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/css/DentalWhite/DentalWhite.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/css/bodyPrincipal/bodyPrincipal.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/css/textos/textos.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/jq/coin-slider-footer/coin-slider-styles-footer.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/jq/SimplejQueryDropdowns/css/style.css" media="screen" />
    <link rel="stylesheet" href="../../../../Recursos/css/formularios/formularios.css" media="screen" />
    <script src="../../../../Recursos/jq/jquery-2.1.4.min.js" type="text/javascript"></script>
    <script src="../../../../Recursos/jq/coin-slider-footer/coin-slider-footer.js" type="text/javascript"></script>
    <script src="../../../../Recursos/jq/coin-slider-footer/scriptcoin-slider-footer.js" type="text/javascript"></script>
    <script src="../../../../Recursos/jq/SimplejQueryDropdowns/js/jquery.dropdownPlain.js" type="text/javascript"></script>
    <script src="../../../../Recursos/jq/MaskedInput/JQueryMaskedInput.js" type="text/javascript"></script>
    <script src="../../../../Recursos/jq/MaskedInput/MaskedInput.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSectionBody" runat="server">
    <section id="sectionBody">
        <section id="contentBody">
            <uc1:WUCBemVindo runat="server" id="WUCBemVindo" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <article>
                <asp:Panel ID="pnlMensagemErro" runat="server" Visible="false">
                    <article class="boxContainnerMensagem">
                        <h2 class="txtTituloMensagemErro">Ocorreram os seguintes erros:</h2><br />
                        <asp:Label ID="lblMensagemErro" runat="server" CssClass="txtItensMensagemErro"></asp:Label>
                        <asp:ValidationSummary ID="SummarioErro" runat="server" ShowSummary="true" DisplayMode="BulletList" CssClass="txtItensMensagemErro" EnableClientScript="False" />
                    </article>
                </asp:Panel>
            </article>
            <article>
                <asp:Panel ID="pnlMensagemSucesso" runat="server" Visible="false">
                    <article class="boxContainnerMensagem">
                        <h2 class="txtTituloMensagemSucesso">Imagem carregada com sucesso.</h2><br />
                    </article>
                </asp:Panel>
            </article>
            <article class="frmCadastroPaciente">
                <h3>Inserir/Visualizar Sua Foto de Dependente</h3><br />
                <asp:LinkButton ID="LinkVoltar" runat="server" OnClick="LinkVoltar_Click">Voltar</asp:LinkButton><hr /><br />
                <h1>Formulário de Paciente - Módulo Inserir/Visualizar Foto.</h1><br />
                <section>
                    <fieldset id="fieldsetInserirFoto">
                        <legend>Inserir Foto:</legend>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorSelecionarArquivo" runat="server" ControlToValidate="FileUploadImagem" Display="Dynamic" ErrorMessage="Campo Arquivo é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                            <label>Arquivo:</label><br />
                            <asp:UpdatePanel ID="UpdatePanel2" runat="server"> 
                                <Triggers> 
                                    <asp:PostBackTrigger ControlID="btnInserir" /> 
                                </Triggers> 
                            <ContentTemplate> 
                                <asp:FileUpload ID="FileUploadImagem" runat="server" Width="99%" CssClass="textbox" /><br />
                                <asp:Panel ID="pnlInformacoesArquivos" runat="server" Visible="false">
                                    <p style="font-weight:bold;">Informações do Arquivos:</p><hr /><br />
                                    <label style="font-weight:bold;">Extensão do Arquivo:</label>
                                    <asp:Label ID="lblExtensaoArquivo" runat="server"></asp:Label><br />
                                    <label style="font-weight:bold;">Tamanho do Arquivo:</label>
                                    <asp:Label ID="lblTamanhoArquivo" runat="server"></asp:Label><br />
                                    <label style="font-weight:bold;">Caminho do Arquivo:</label>
                                    <asp:Label ID="lblCaminhoArquivo" runat="server"></asp:Label>
                                    <asp:Label ID="lblArquivo" runat="server"></asp:Label><br /><br />
                                </asp:Panel>
                                <asp:Button ID="btnInserir" runat="server" Text="Inserir" CssClass="button buttonInserirFoto" OnClick="btnInserir_Click" />
                            </ContentTemplate> 
                            </asp:UpdatePanel> 
                    </fieldset>

                    <fieldset id="fieldsetImagemFoto">
                        <legend>Imagem da Foto:</legend>
                            <asp:Image ID="imgFoto" runat="server" Height="390" Width="475" OnLoad="imgFoto_Load" />
                    </fieldset>
                </section>
            </article>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>    
</asp:Content>