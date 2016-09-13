<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Pages.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.RecuperacaoSenha.Default" Buffer="true" Trace="false" EnableTheming="false" %>

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
                        <h2 class="txtTituloMensagemSucesso">Recuperação da Senha do usuário cadastrado realizado com sucesso.</h2><br />
                    </article>
                </asp:Panel>
            </article>
            <article>
                <fieldset id="fieldsetRecuperarSenha">
                    <h1>Recuperação da Senha do Usuário Cadastrado</h1><br />
                    <a href="../AreaRestrita/Default.aspx">Voltar</a><hr /><br />
                    <legend>Recuperação da Senha:</legend>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsuario" runat="server" Display="Dynamic" ControlToValidate="txtUsuario" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                        <label>Digite o nome do seu Usuário:</label><br />
                        <asp:TextBox ID="txtUsuario" runat="server" Width="99%" CssClass="textbox" TabIndex="1"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorPerfil" runat="server" ControlToValidate="txtPerfil" Display="Dynamic" ErrorMessage="Campo Perfil é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Digite o Perfil do seu Usuário:</label><br />
                        <asp:TextBox ID="txtPerfil" runat="server" Width="99%" CssClass="txtCPF textbox" MaxLength="11" TabIndex="5"></asp:TextBox><br /><br />
                        <asp:Label ID="lblMeuUsuario" runat="server" Visible="false" Font-Bold="true"></asp:Label>
                        <asp:Label ID="lblSenhaEncontrada" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <asp:Panel ID="pnlRecuperacaoSenha" runat="server" Visible="false">
                            <fieldset>
                            <legend>Informe Nova Senha:</legend>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorSenha" runat="server" ErrorMessage="Campo Senha é obrigatório." Display="Dynamic" ControlToValidate="txtSenha" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                                <label>Senha:</label><br />
                                <asp:TextBox ID="txtSenha" runat="server" MaxLength="50" Width="99%" TextMode="Password" CssClass="textbox" TabIndex="5"></asp:TextBox><br /><br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorConfirmacaoSenha" runat="server" ErrorMessage="Campo Confirmação da Senha é obrigatório." Display="Dynamic" ControlToValidate="txtConfirmacaoSenha" Text="*" EnableClientScript="False" ForeColor="Red"></asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidatorSenhas" runat="server" ErrorMessage="Os campos Senha e Confirma Senha deverão ser iguais." ControlToCompare="txtSenha" ControlToValidate="txtConfirmacaoSenha" Display="Dynamic" Text="*" EnableClientScript="False" ForeColor="Red"></asp:CompareValidator>
                                <label>Confirme a Senha:</label><br />
                                <asp:TextBox ID="txtConfirmacaoSenha" runat="server" MaxLength="50" Width="99%" TextMode="Password" CssClass="textbox" TabIndex="10"></asp:TextBox><br /><br />
                                <asp:Button ID="btnCriarNovaSenha" runat="server" Text="Criar Nova Senha" CssClass="button" TabIndex="15" />
                            </fieldset>
                        </asp:Panel><br>
                        <asp:Button ID="btnRecuperarSenha" runat="server" Text="Recuperar Senha" CssClass="buttonMiddle" TabIndex="5" OnClick="btnRecuperarSenha_Click" />
                        <asp:Button ID="btnLimparTela" runat="server" Text="Limpar Tela" CssClass="buttonMiddle" TabIndex="10" OnClick="btnLimparTela_Click" />
                </fieldset>
            </article>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>
