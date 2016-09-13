<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.AdminCliente.Paciente.ConsultarPaciente.Default" Buffer="true" Trace="false" EnableTheming="false" %>

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
            <uc1:WUCBemVindo runat="server" id="WUCBemVindo" />
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Panel ID="pnlMensagemErro" runat="server" Visible="false">
                    <section class="boxContainnerMensagem">
                        <h2 class="txtTituloMensagemErro">Ocorreram os seguintes erros:</h2><br />
                        <asp:Label ID="lblMensagemErro" runat="server" CssClass="txtItensMensagemErro"></asp:Label>
                        <asp:ValidationSummary ID="SummarioErro" runat="server" ShowSummary="true" DisplayMode="BulletList" CssClass="txtItensMensagemErro" EnableClientScript="False" />
                    </section>
                </asp:Panel>
                <asp:Panel ID="pnlMensagemSucesso" runat="server" Visible="false">
                    <section class="boxContainnerMensagem">
                        <h2 class="txtTituloMensagemSucesso">Cadastro realizado com sucesso.</h2><br />
                    </section>
                </asp:Panel>
                <section class="boxContainnerTipoPesquisa">
                    <h3>Atualizar Dados do Paciente</h3><br />
                    <asp:LinkButton ID="LinkVoltar" runat="server" OnClick="LinkVoltar_Click">Voltar</asp:LinkButton><hr /><br />
                    <section style="float:left;">
                        <label style="font-weight:bold;">Selecione o Tipo de Pesquisa:</label>
                        <asp:DropDownList ID="ddlTipoPesquisa" runat="server" CssClass="textbox" AutoPostBack="true" OnSelectedIndexChanged="ddlTipoPesquisa_SelectedIndexChanged">
                            <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                            <asp:ListItem Value="porlogin" Text="Por Login"></asp:ListItem>
                            <asp:ListItem Value="pornome" Text="Por Nome"></asp:ListItem>
                            <asp:ListItem Value="porsobrenome" Text="Por Sobrenome"></asp:ListItem>
                            <asp:ListItem Value="pordatanascimento" Text="Por Data de Nascimento"></asp:ListItem>
                            <asp:ListItem Value="poremail" Text="Por Email"></asp:ListItem>
                            <asp:ListItem Value="porcpf" Text="Por CPF"></asp:ListItem>
                            <asp:ListItem Value="porrg" Text="Por RG"></asp:ListItem>
                        </asp:DropDownList>
                    </section>
                    <section style="float:left; margin-left:15px;">
                        <asp:Panel ID="pnlTipoPesquisa" runat="server" Visible="false">
                            <label style="font-weight:bold;">Digite </label><asp:Label ID="lblTipoPesquisa" runat="server" Font-Bold="true"></asp:Label>
                            <asp:TextBox ID="txtTipoPesquisa" runat="server" CssClass="textbox"></asp:TextBox>
                            <div style="float:right; margin-left:30px; position:relative; top:-5px;">
                                <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="button" OnClick="btnPesquisar_Click" />
                            </div>
                        </asp:Panel>
                    </section>
                </section>
                <asp:Panel ID="pnlConsultarPaciente" runat="server" Visible="false">
                    <section class="frmCadastroPaciente">
                    <h1>Formulário de Paciente - Módulo Consultar Paciente.</h1><br />
                    <fieldset id="fieldsetDadosPessoais" style="height:355px;">
                        <legend>Dados Pessoais:</legend>
                        <label>Login:</label><br />
                        <asp:Label ID="txtLogin" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Nome:</label><br />
                        <asp:Label ID="lblNome" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Sobrenome:</label><br />
                        <asp:Label ID="lblSobrenome" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Data de Nascimento:</label><br />
                        <asp:Label ID="lblDataNascimento" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Email:</label><br />
                        <asp:Label ID="lblEmail" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Sexo:</label><br />
                        <asp:Label ID="lblSexo" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Estado Civil:</label><br />
                        <asp:Label ID="lblEstadoCivil" runat="server" Font-Bold="true"></asp:Label>
                    </fieldset>

                    <fieldset id="fieldsetDocumentos">
                        <legend>Documentos:</legend>
                        <label>CPF:</label><br />
                        <asp:Label ID="lblCPF" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>RG:</label><br />
                        <label>Número:</label><br />
                        <asp:Label ID="lblNumeroRG" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label class="lista">Órgão Emissor:</label><br />
                        <asp:Label ID="lblOrgaoEmissor" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label class="lista">Data de Emissão:</label><br />
                        <asp:Label ID="lblDataEmissao" runat="server" Font-Bold="true"></asp:Label>
                    </fieldset>

                    <fieldset id="fieldsetTelefone">
                        <legend>Telefone:</legend>
                        <asp:Panel ID="pnlTelefone1" runat="server">
                            <h2 style="font-size:14px">1º Telefone:</h2>
                            <table>
                                <tr>
                                    <td>
                                        <label>Tipo de Telefone:</label>
                                        <asp:Label ID="lblTipoTelefone1" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Panel ID="pnlOperadora1" runat="server" Visible="False">
                                            <label>Operadora:</label>
                                            <asp:Label ID="lblOperadora1" runat="server" Font-Bold="true"></asp:Label>
                                        </asp:Panel><br /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>DDD:</label>
                                        <asp:Label ID="lblDDD1" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <label>Número:</label>
                                        <asp:Label ID="lblNumeroTel1" runat="server" Font-Bold="true"></asp:Label><br /><br />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel ID="pnlTelefone2" runat="server" Visible="false">
                            <h2 style="font-size:14px">2º Telefone:</h2>
                            <table>
                                <tr>
                                    <td>
                                        <label>Tipo de Telefone:</label>
                                        <asp:Label ID="lblTipoTelefone2" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Panel ID="pnlOperadora2" runat="server" Visible="False">
                                            <label>Operadora:</label>
                                            <asp:Label ID="lblOperadora2" runat="server" Font-Bold="true"></asp:Label>
                                        </asp:Panel><br /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>DDD:</label>
                                        <asp:Label ID="lblDDD2" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <label>Número:</label>
                                        <asp:Label ID="lblNumeroTel2" runat="server" Font-Bold="true"></asp:Label><br /><br />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>

                        <asp:Panel ID="pnlTelefone3" runat="server" Visible="false">
                            <h2 style="font-size:14px">3º Telefone:</h2>
                            <table>
                                <tr>
                                    <td>
                                        <label>Tipo de Telefone:</label>
                                        <asp:Label ID="lblTipoTelefone3" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <asp:Panel ID="pnlOperadora3" runat="server" Visible="False">
                                            <label>Operadora:</label>
                                            <asp:Label ID="lblOperadora3" runat="server" Font-Bold="true"></asp:Label>
                                        </asp:Panel><br /><br />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <label>DDD:</label>
                                        <asp:Label ID="lblDDD3" runat="server" Font-Bold="true"></asp:Label>
                                    </td>
                                    <td>
                                        <label>Número:</label>
                                        <asp:Label ID="lblNumeroTel3" runat="server" Font-Bold="true"></asp:Label><br /><br />
                                    </td>
                                </tr>
                            </table>
                        </asp:Panel>
                    </fieldset>

                    <fieldset id="fieldsetEndereco">
                        <legend>Endereço:</legend>
                        <div style="float:left; margin-left:0px; display:block;">
                            <label>UF:</label>
                            <asp:Label ID="lblUF" runat="server" Font-Bold="true"></asp:Label>
                        </div>
                        <div style="float:left; margin-left:70px; margin-right:70px; display:block;">
                            <label>Estado:</label>
                            <asp:Label ID="lblEstado" runat="server" Font-Bold="true"></asp:Label>
                        </div>
                        <div style="margin-left:70px; display:block;">
                            <label>Cidade:</label>
                            <asp:Label ID="lblCidade" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        </div>
                        <label>Logradouro:</label>
                        <asp:Label ID="lblLogradouro" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Número:</label>
                        <asp:Label ID="lblNumeroEnd" runat="server" Font-Bold="true" Width="100px"></asp:Label><br /><br />
                        <label>Tipo do Logradouro:</label><br />
                        <asp:Label ID="lblTipoLogradouro" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Bairro:</label><br />
                        <asp:Label ID="lblBairro" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>Complemento:</label><br />
                        <asp:Label ID="lblComplemento" runat="server" Font-Bold="true"></asp:Label><br /><br />
                        <label>CEP:</label><br />
                        <asp:Label ID="lblCEP" runat="server" Font-Bold="true"></asp:Label><br /><br />
                    </fieldset>
                </section>
                </asp:Panel>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>
