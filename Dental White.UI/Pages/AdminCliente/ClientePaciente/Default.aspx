<%@ Page Title="" Language="C#" MasterPageFile="~/Template/AllPerfis.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.AdminCliente.Cliente.Default" Buffer="true" Trace="false" EnableTheming="false" %>

<%@ Register Src="~/WUC/WUCBemVindo.ascx" TagPrefix="uc1" TagName="WUCBemVindo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../../../Recursos/css/cssreset/cssreset.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/css/DentalWhite/DentalWhite.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/css/bodyPrincipal/bodyPrincipal.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/css/textos/textos.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/jq/coin-slider-footer/coin-slider-styles-footer.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/jq/SimplejQueryDropdowns/css/style.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/css/formularios/formularios.css" media="screen" />
    <link rel="stylesheet" href="../../../Recursos/jq/Accordion/jquery-ui.css" media="screen" />
    <script src="../../../Recursos/jq/jquery-2.1.4.min.js" type="text/javascript"></script>
    <script src="../../../Recursos/jq/coin-slider-footer/coin-slider-footer.js" type="text/javascript"></script>
    <script src="../../../Recursos/jq/coin-slider-footer/scriptcoin-slider-footer.js" type="text/javascript"></script>
    <script src="../../../Recursos/jq/SimplejQueryDropdowns/js/jquery.dropdownPlain.js" type="text/javascript"></script>
    <script src="../../../Recursos/jq/Accordion/jquery-ui.js" type="text/javascript"></script>
    <script src="../../../Recursos/jq/Accordion/Accordion.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSectionBody" runat="server">
    <section id="sectionBody">
        <section id="contentBody">
            <uc1:WUCBemVindo runat="server" ID="WUCBemVindo" />
            <article>
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                    <ContentTemplate>
                        <asp:Panel ID="pnlMensagemErro" runat="server" Visible="false">
                            <section class="boxContainnerMensagem">
                                <h2 class="txtTituloMensagemErro">Ocorreram os seguintes erros:</h2>
                                <br />
                                <asp:Label ID="lblMensagemErro" runat="server" CssClass="txtItensMensagemErro"></asp:Label>
                                <asp:ValidationSummary ID="SummarioErro" runat="server" ShowSummary="true" DisplayMode="BulletList" CssClass="txtItensMensagemErro" EnableClientScript="False" />
                            </section>
                        </asp:Panel>
                        <asp:Panel ID="pnlMensagemSucesso" runat="server" Visible="false">
                            <section class="boxContainnerMensagem">
                                <h2 class="txtTituloMensagemSucesso">Cadastro do Tipo de Perfil realizado com sucesso.</h2>
                                <br />
                                <p style="text-align: center;">Clique<asp:LinkButton ID="LinkCliqueAqui" runat="server" OnClick="LinkCliqueAqui_Click"> aqui</asp:LinkButton>.</p>
                            </section>
                        </asp:Panel>

                        <asp:Panel ID="pnlSelecaoTipoPerfil" runat="server" Visible="false">
                            <section class="boxContainnerTipoPesquisa">
                                <section style="float: left;">
                                    <label style="font-weight: bold;">Selecione o Tipo de Perfil a ser Cadastrado:</label>
                                    <asp:DropDownList ID="ddlTipoPesquisa" runat="server" CssClass="textbox" AutoPostBack="true" OnSelectedIndexChanged="ddlTipoPesquisa_SelectedIndexChanged">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                        <asp:ListItem Value="Titular" Text="Titular"></asp:ListItem>
                                        <asp:ListItem Value="Dependente" Text="Dependente"></asp:ListItem>
                                    </asp:DropDownList>
                                </section>
                                <section style="float: left; margin-left: 15px;">
                                    <asp:Panel ID="pnlCadastrarPerfil" runat="server" Visible="false">
                                        <div style="float: right; margin-left: 30px; position: relative; top: -5px;">
                                            <asp:Button ID="btnCadastrarPerfil" runat="server" Text="Cadastrar Perfil" CssClass="button" OnClick="btnCadastrarPerfil_Click" />
                                        </div>
                                    </asp:Panel>
                                </section>
                            </section>
                        </asp:Panel>

                        <section>
                            <asp:Panel ID="pnlTitular" runat="server" Visible="true">
                                <fieldset class="fieldsetGerenciarPaciente">
                                    <br />
                                    <h1>Gerenciar Paciente - Módulo Titular</h1><br /><hr /><br />
                                    <div class="accordion">
                                        <h3>Paciente</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkCadastrarPaciente" runat="server" Text="Cadastrar Dados do Paciente" OnClick="linkCadastrarPaciente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkAtualizarPaciente" runat="server" Text="Atualizar Dados do Paciente" OnClick="linkAtualizarPaciente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkConsultarPaciente" runat="server" Text="Consultar Dados do Paciente" OnClick="linkConsultarPaciente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkInserirFotoPaciente" runat="server" Text="Inserir/Visualizar Foto do Paciente" OnClick="linkInserirFotoPacienteTitular_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkExcluirFotoPaciente" runat="server" Text="Excluir Foto do Paciente" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                        <h3>Plano Odontológico</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkVincularPacientePlano" runat="server" Text="Vincular Paciente ao Plano Odontológico" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkAtualizarPacientePlano" runat="server" Text="Atualizar Paciente ao Plano Odontológico" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkConsultarPacientePlano" runat="server" Text="Consultar Paciente ao Plano Odontológico" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkDesvincularPacientePlano" runat="server" Text="Desvincular Paciente ao Plano Odontológico" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                        <h3>Dependente</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkCadastrarDependentes" runat="server" Text="Cadastrar Dado(s) do(s) Dependente(s)" OnClick="linkCadastrarDependentes_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkAtualizarDependentes" runat="server" Text="Atualizar Dado(s) do(s) Dependente(s)" OnClick="linkAtualizarDependentes_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkConsultarDependentes" runat="server" Text="Consultar Dados do(s) Dependente(s)" OnClick="linkConsultarDependentes_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkVincularDependenteTitular" runat="server" Text="Vincular Dependente ao Titular" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="linkExcluirDependentes" runat="server" Text="Excluir Dependentes" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </fieldset>
                            </asp:Panel>


                            <asp:Panel ID="pnlDependente" runat="server" Visible="false">
                                <fieldset class="fieldsetGerenciarPaciente">
                                    <br />
                                    <h1>Gerenciar Paciente - Módulo Dependente</h1><br /><hr /><br />
                                    <div class="accordion">
                                        <h3>Dependente</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkAtualizarDependente" runat="server" Text="Atualizar Dados do Dependente" OnClick="LinkAtualizarDependente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkConsultarDependente" runat="server" Text="Consultar Dados do Dependente" OnClick="LinkConsultarDependente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkInserirFotoDependente" runat="server" Text="Inserir/Visualizar Foto do Dependente" OnClick="LinkInserirFotoDependente_Click" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkExcluirFotoDependente" runat="server" Text="Excluir Foto" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                        <h3>Plano Odontológico</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkConsultarDadosPacientePlano" runat="server" Text="Consultar Paciente ao Plano Odontológico" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                        <h3>Paciente</h3>
                                        <div>
                                            <ul>
                                                <li class="lista">
                                                    <p class="paragrafo">
                                                        <asp:LinkButton ID="LinkConsultarDadosPaciente" runat="server" Text="Consultar Dados do Paciente" ForeColor="Blue"></asp:LinkButton>
                                                    </p>
                                                </li>
                                            </ul>
                                        </div>
                                    </div>
                                </fieldset>
                            </asp:Panel>
                        </section>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </article>
        </section>
    </section>
</asp:Content>
