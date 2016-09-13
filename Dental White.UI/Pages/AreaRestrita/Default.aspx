<%@ Page Title="Dental White - Área Restrita" Language="C#" MasterPageFile="~/Template/Pages.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.AreaRestrita.Default" Buffer="true" Trace="false" EnableTheming="false" %>

<%@ Register Src="~/WUC/WUCBemVindo.ascx" TagPrefix="uc1" TagName="WUCBemVindo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../Recursos/css/cssreset/cssreset.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/css/DentalWhite/DentalWhite.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/css/bodyPrincipal/bodyPrincipal.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/css/textos/textos.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/jq/coin-slider-footer/coin-slider-styles-footer.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/jq/SimplejQueryDropdowns/css/style.css" media="screen" />
    <link rel="stylesheet" href="../../Recursos/css/formularios/formularios.css" media="screen" />
    <script src="../../Recursos/jq/jquery-2.1.4.min.js" type="text/javascript"></script>
    <script src="../../Recursos/jq/coin-slider-footer/coin-slider-footer.js" type="text/javascript"></script>
    <script src="../../Recursos/jq/coin-slider-footer/scriptcoin-slider-footer.js" type="text/javascript"></script>
    <script src="../../Recursos/jq/SimplejQueryDropdowns/js/jquery.dropdownPlain.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSectionBody" runat="server">
    <section id="sectionBody">
        <section id="contentBody">
            <uc1:WUCBemVindo runat="server" ID="WUCBemVindo" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
            <asp:Panel ID="pnlMensagemErro" runat="server" Visible="false">
                <article class="boxContainnerMensagem">
                    <h2 class="txtTituloMensagemErro">Ocorreram os seguintes erros:</h2><br />
                    <asp:Label ID="lblMensagemErro" runat="server" CssClass="txtItensMensagemErro"></asp:Label>
                    <asp:ValidationSummary ID="SummarioErro" runat="server" ShowSummary="true" DisplayMode="BulletList" CssClass="txtItensMensagemErro" EnableClientScript="False" />
                </article>
            </asp:Panel>
            <article id="boxPerfilUsuário">
                <fieldset id="fieldsetPerfilUsuário">
                <h1>Selecione um Perfil de Usuário.</h1><br /><hr /><br />
                <asp:RadioButtonList ID="rdbPerfilUsuario" runat="server" CssClass="rdbPerfilUsuario" TabIndex="1" ToolTip="Perfil de Usuário" OnSelectedIndexChanged="rdbPerfilUsuario_SelectedIndexChanged" AutoPostBack="True" OnLoad="rdbPerfilUsuario_Load">
                    <asp:ListItem Value="AdministradorSistema">Administrador do Sistema</asp:ListItem>
                    <asp:ListItem Value="GerenteSetor">Gerente de Setor</asp:ListItem>
                    <asp:ListItem Value="Colaborador">Colaborador</asp:ListItem>
                    <asp:ListItem Value="Cliente">Cliente</asp:ListItem>
                </asp:RadioButtonList>
                </fieldset>
                <asp:Label ID="lblPerfilUsuario" runat="server" Visible="False" CssClass="lblPerfilUsuario"></asp:Label>
            </article>

            <asp:Panel ID="pnlBoxLoginUsuarioAdmSistema" runat="server" Visible="False">
                <article class="boxLoginUsuario">
                    <fieldset>
                        <h1>Login do Usuário <br />Perfil <asp:Label ID="lblPerfilAdmSistema" runat="server"></asp:Label>.</h1><br /><hr /><br />
                        <label>Login:</label><br />
                        <asp:TextBox ID="txtLoginAdmSistema" runat="server" MaxLength="50" PlaceHolder="Digite Login" CssClass="textbox"></asp:TextBox><br />
                        <label>Senha:</label><br />
                        <asp:TextBox ID="txtSenhaAdmSistema" runat="server" TextMode="Password" MaxLength="50" PlaceHolder="Digite Senha" CssClass="textbox"></asp:TextBox>
                        <br /><p style="display:normal; margin:0px; padding:0px; text-align:center;">Novo usuário? Cadastre-se<a href="#">aqui</a>. | <a href="#">Esqueceu o Usuário</a> | <a href="#">Esqueceu a Senha</a></p>
                        <asp:Button ID="btnLoginAdmSistema" runat="server" Text="Login" CssClass="button" />
                    </fieldset>
                </article>
            </asp:Panel>
            
            <asp:Panel ID="pnlBoxLoginUsuarioGerenteSetor" runat="server" Visible="False">
                <article class="boxLoginUsuario">
                    <fieldset>
                        <h1>Login do Usuário <br />Perfil <asp:Label ID="lblPerfilGerenteSetor" runat="server"></asp:Label>.</h1><br /><hr /><br />
                        <label>Login:</label><br />
                        <asp:TextBox ID="txtLoginGerenteSetor" runat="server" MaxLength="50" PlaceHolder="Digite Login: <CPF>" CssClass="textbox"></asp:TextBox><br />
                        <label>Senha:</label><br />
                        <asp:TextBox ID="txtSenhaGerenteSetor" runat="server" TextMode="Password" MaxLength="50" PlaceHolder="Digite Senha" CssClass="textbox"></asp:TextBox>
                        <br /><br /><p style="display:normal; margin:0px; padding:0px; text-align:center;">Novo usuário? Cadastre-se <a href="#">aqui</a>. | Esqueceu a senha clique <a href="#">aqui</a>.</p>
                        <asp:Button ID="btnGerenteSetor" runat="server" Text="Login" CssClass="button" />
                    </fieldset>
                </article>
            </asp:Panel>
            
            <asp:Panel ID="pnlBoxLoginUsuarioColaborador" runat="server" Visible="False">
                <article class="boxLoginUsuario">
                    <fieldset>
                        <h1>Login do Usuário <br />Perfil <asp:Label ID="lblPerfilColaborador" runat="server"></asp:Label>.</h1><br /><hr /><br />
                        <label>Login:</label><br />
                        <asp:TextBox ID="txtLoginColaborador" runat="server" MaxLength="50" PlaceHolder="Digite Login: <CPF>" CssClass="textbox"></asp:TextBox><br />
                        <label>Senha:</label><br />
                        <asp:TextBox ID="txtSenhaColaborador" runat="server" TextMode="Password" MaxLength="50" PlaceHolder="Digite Senha" CssClass="textbox"></asp:TextBox>
                        <br /><br /><p style="display:normal; margin:0px; padding:0px; text-align:center;">Novo usuário? Cadastre-se <a href="#">aqui</a>. | Esqueceu a senha clique <a href="#">aqui</a>.</p>
                        <asp:Button ID="btnLoginColaborador" runat="server" Text="Login" CssClass="button" />
                    </fieldset>
                </article>
            </asp:Panel>
            
            <asp:Panel ID="pnlBoxLoginUsuarioCliente" runat="server" Visible="False">
                <article class="boxLoginUsuario">
                    <fieldset>
                        <h1>Login do Usuário <br />Perfil <asp:Label ID="lblPerfilCliente" runat="server"></asp:Label>.</h1><br /><hr /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogin" runat="server" ControlToValidate="txtLoginCliente" Display="Dynamic" Text="*" ErrorMessage="Campo Login é obrigatório." EnableClientScript="false" ForeColor="Red"></asp:RequiredFieldValidator>
                        <label>Login:</label><br />
                        <asp:TextBox ID="txtLoginCliente" runat="server" MaxLength="50" PlaceHolder="Digite Login..." CssClass="textbox"></asp:TextBox><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSenha" runat="server" ControlToValidate="txtSenhaCliente" Display="Dynamic" Text="*" ErrorMessage="Campo Senha é obrigatório." EnableClientScript="false" ForeColor="Red"></asp:RequiredFieldValidator>
                        <label>Senha:</label><br />
                        <asp:TextBox ID="txtSenhaCliente" runat="server" TextMode="Password" MaxLength="50" PlaceHolder="Digite Senha..." CssClass="textbox"></asp:TextBox>
                        <br /><br /><p style="display:normal; margin:0px; padding:0px; text-align:center;">Novo usuário? Cadastre-se <asp:LinkButton ID="linkNovoUsuario" runat="server" OnClick="linkNovoUsuario_Click">aqui</asp:LinkButton>. | Esqueceu:<asp:LinkButton ID="linkEsqueceuUsuarioCliente" runat="server" OnClick="linkEsqueceuUsuarioCliente_Click">Usuário</asp:LinkButton> | <asp:LinkButton ID="LinkEsqueceuSenhaCliente" runat="server" OnClick="LinkEsqueceuSenhaCliente_Click">Senha</asp:LinkButton></p>
                        <asp:Button ID="btnLoginCliente" runat="server" Text="Login" CssClass="button" OnClick="btnLoginCliente_Click" />
                    </fieldset>
                </article>
            </asp:Panel>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>