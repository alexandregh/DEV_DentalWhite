<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.Servicos.Especialidades.Default" %>

<%@ Register Src="~/WUC/WUCBemVindo.ascx" TagPrefix="uc1" TagName="WUCBemVindo" %>

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
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSectionBody" runat="server">
    <section id="sectionBody">
        <section id="contentBody">
            <uc1:WUCBemVindo runat="server" ID="WUCBemVindo" />
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
                        <h2 class="txtTituloMensagemSucesso">Recuperação do usuário cadastrado realizado com sucesso.</h2><br />
                    </article>
                </asp:Panel>
            </article>
            <section class="boxContainnerTipoPesquisa">
                <h3>Consultar Especialidades</h3><br />
                <asp:LinkButton ID="LinkVoltar" runat="server" OnClick="LinkVoltar_Click">Home</asp:LinkButton><hr /><br />
                <section style="float:left;">
                <label style="font-weight:bold;">Selecione a Especialidade:</label>
                <asp:DropDownList ID="ddlEspecialidade" runat="server" CssClass="textbox" AutoPostBack="true" OnLoad="ddlEspecialidade_Load" OnSelectedIndexChanged="ddlEspecialidade_SelectedIndexChanged">
                    
                </asp:DropDownList>
                <div style="float:right; margin-left:30px; position:relative; top:-5px;">
                    <asp:Button ID="btnConsultar" runat="server" Text="Pesquisar" CssClass="button" OnClick="btnConsultar_Click" />
                </div>
                </section>
            </section>
            <asp:Panel ID="pnlEspecialidade" runat="server" Visible="false">
                <section class="boxContainnerEspecialidades">
                    <h3><asp:Label ID="lblNomeEspecialidade" runat="server"></asp:Label></h3><br />
                    <article>
                        <p class="paragrafo">
                            <asp:Label ID="lblDescricaoEspecialidade" runat="server"></asp:Label>
                        </p>
                    </article>
                    <article>
                        <br /><br /><br />
                        <h4 style="font-weight:bold;">Habilidades Odontológicas:</h4>
                        <p>Resolução CFO 82/2008</p>
                        </p>Reconhece e regulamenta o uso pelo Cirurgião-dentista de práticas integrativas e complementares à saúde bucal.</p>
                        </p>Art. 1º Reconhece o exercício pelo Cirurgião-dentista das seguintes práticas integrativas e complementares à saúde bucal:</p>
                        <p>Acupuntura;
                        Fitoterapia;
                        Terapia Floral;
                        Hipnose;
                        Homeopatia e
                        Laserterapia.</p>
                    </article>
                </section>
            </asp:Panel>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>