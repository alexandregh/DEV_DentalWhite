<%@ Page Title="Dental White - Usuário" Language="C#" MasterPageFile="~/Template/Pages.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.Usuario.Default" Buffer="true" Trace="false" EnableTheming="false" %>

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
                        <h2 class="txtTituloMensagemSucesso">Cadastro realizado com sucesso.</h2><br />
                    </article>
                </asp:Panel>
            </article>
            <article>
                <fieldset id="fieldsetDadosPessoais">
                    <h1>Cadastro de Novo Usuário</h1><br />
                    <a href="../AreaRestrita/Default.aspx">Voltar</a><hr /><br />
                    <legend>Dados do Usuário:</legend>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin" runat="server" ErrorMessage="Campo Login é obrigatório." Display="Dynamic" ControlToValidate="txtLogin" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        <label>Login:</label><br />
                        <asp:TextBox ID="txtLogin" runat="server" MaxLength="50" Width="99%" CssClass="textbox" TabIndex="1"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSenha" runat="server" ErrorMessage="Campo Senha é obrigatório." Display="Dynamic" ControlToValidate="txtSenha" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        <label>Senha:</label><br />
                        <asp:TextBox ID="txtSenha" runat="server" MaxLength="50" Width="99%" TextMode="Password" CssClass="textbox" TabIndex="5"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmacaoSenha" runat="server" ErrorMessage="Campo Confirmação da Senha é obrigatório." Display="Dynamic" ControlToValidate="txtConfirmacaoSenha" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidatorSenhas" runat="server" ErrorMessage="Os campos Senha e Confirma Senha deverão ser iguais." ControlToCompare="txtSenha" ControlToValidate="txtConfirmacaoSenha" Display="Dynamic" Text="*" EnableClientScript="False" ForeColor="Red"></asp:CompareValidator>
                        <label>Confirme a Senha:</label><br />
                        <asp:TextBox ID="txtConfirmacaoSenha" runat="server" MaxLength="50" Width="99%" TextMode="Password" CssClass="textbox" TabIndex="10"></asp:TextBox><br /><br />
                        <asp:Literal ID="lblPerfilSelecionado" runat="server"></asp:Literal>
                        <asp:Button ID="btnCadastrarUsuario" runat="server" Text="Cadastrar Usuário" CssClass="button" OnClick="btnCadastrarUsuario_Click" TabIndex="15" />
                    </fieldset>
            </article>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>