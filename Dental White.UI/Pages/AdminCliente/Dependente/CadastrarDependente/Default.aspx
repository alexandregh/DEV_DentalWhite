<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Pages.AdminClientePaciente.Dependente.Cadastro.Default" Buffer="true" Trace="false" EnableTheming="false" %>

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
            <asp:Panel ID="pnlMensagemErro" runat="server" Visible="false">
                <article class="boxContainnerMensagem">
                    <h2 class="txtTituloMensagemErro">Ocorreram os seguintes erros:</h2><br />
                    <asp:Label ID="lblMensagemErro" runat="server" CssClass="txtItensMensagemErro"></asp:Label>
                    <asp:ValidationSummary ID="SummarioErro" runat="server" ShowSummary="true" DisplayMode="BulletList" CssClass="txtItensMensagemErro" EnableClientScript="False" />
                </article>
                <article>
                    <asp:Panel ID="pnlMensagemSucesso" runat="server" Visible="false">
                        <article class="boxContainnerMensagem">
                            <h2 class="txtTituloMensagemSucesso">Cadastro realizado com sucesso.</h2><br />
                        </article>
                    </asp:Panel>
                </article>
            </asp:Panel>
            <article class="frmCadastroPaciente">
                <h3>Cadastrar Dados do Dependente</h3><br />
                <asp:LinkButton ID="LinkVoltar" runat="server" OnClick="LinkVoltar_Click">Voltar</asp:LinkButton><hr /><br />
                <h1>Formulário de Dependente - Módulo Cadastrar Dependente.</h1><br />
                    <fieldset class="extfieldsetDadosPessoais">
                    <legend>Dados Pessoais:</legend>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNome" runat="server" ControlToValidate="txtNome" Display="Dynamic" ErrorMessage="Campo Login é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Nome:</label><br />
                        <asp:TextBox ID="txtNome" runat="server" MaxLength="50" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSobrenome" runat="server" ControlToValidate="txtSobrenome" Display="Dynamic" ErrorMessage="Campo Sobrenome é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Sobrenome:</label><br />
                        <asp:TextBox ID="txtSobrenome" runat="server" MaxLength="80" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDataNascimento" runat="server" ControlToValidate="txtDataNascimento" Display="Dynamic" ErrorMessage="Campo Data de Nascimento é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Data de Nascimento:</label><br />
                        <asp:TextBox ID="txtDataNascimento" runat="server" Type="date" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ErrorMessage="Campo Email é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>E-mail:</label>
                        <asp:TextBox ID="txtEmail" runat="server" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorSexo" runat="server" ControlToValidate="rdbSexo" Display="Dynamic" ErrorMessage="Campo Sexo é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Sexo:</label><br />
                        <asp:RadioButtonList ID="rdbSexo" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                            <asp:ListItem Value="1" Text="Masculino"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Feminino"></asp:ListItem>
                        </asp:RadioButtonList><br /><br />
                        <label>Estado Civil:</label><br />
                        <asp:RadioButtonList ID="rdbEstadoCivil" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                            <asp:ListItem Value="Solteiro" Text="Solteiro(a)"></asp:ListItem>
                            <asp:ListItem Value="Casado" Text="Casado(a)"></asp:ListItem>
                            <asp:ListItem Value="Divorciado" Text="Divorciado(a)"></asp:ListItem>
                            <asp:ListItem Value="Viuvo" Text="Viúvo(a)"></asp:ListItem>
                        </asp:RadioButtonList>
                    </fieldset>

                    <fieldset id="fieldsetDocumentos">
                    <legend>Documentos:</legend>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorCPF" runat="server" ControlToValidate="txtCPF" Display="Dynamic" ErrorMessage="Campo CPF é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>CPF:</label><br />
                        <asp:TextBox ID="txtCPF" runat="server" Width="99%" CssClass="txtCPF textbox" MaxLength="11"></asp:TextBox><br /><br />
                        <label>RG:</label><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumeroRG" runat="server" ControlToValidate="txtNumeroRG" Display="Dynamic" ErrorMessage="Campo RG é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label>Número:</label><br />
                        <asp:TextBox ID="txtNumeroRG" runat="server" Width="99%" CssClass="txtNumeroRG textbox" MaxLength="11"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorOrgaoEmissor" runat="server" ControlToValidate="txtOrgaoEmissor" Display="Dynamic" ErrorMessage="Campo Órgão Emissor é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label class="lista">Órgão Emissor:</label><br />
                        <asp:TextBox ID="txtOrgaoEmissor" runat="server" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorDataEmissao" runat="server" ControlToValidate="txtDataEmissao" Display="Dynamic" ErrorMessage="Campo Data de Emissão é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                        <label class="lista">Data de Emissão:</label><br />
                        <asp:TextBox ID="txtDataEmissao" runat="server" type="date" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                        <fieldset>
                        <legend>Grau de Parentesco</legend>
                            <label>Nível do Grau de Parentesco:</label><br />
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatorNivelGrauParentesco" runat="server" ControlToValidate="rdbNivelGrauParentesco" Display="Dynamic" ErrorMessage="Campo Nível do Grau de Parentesco é obrigatório." Text="*" ForeColor="Red" EnableClientScript="true"></asp:RequiredFieldValidator>
                            <asp:RadioButtonList ID="rdbNivelGrauParentesco" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                                <asp:ListItem Value="conjuge" Text="Cônjuge">Cônjuge</asp:ListItem>
                                <asp:ListItem Value="filhosenteados" Text="Filhos(as) / Enteados(as)">Filhos(as) / Enteados(as)</asp:ListItem>
                                <asp:ListItem Value="paimae" Text="Pai / Mãe">Pai / Mãe</asp:ListItem>
                            </asp:RadioButtonList><br /><br />
                            <label>Descrição do Grau de Parentesco:</label><br />
                            <asp:TextBox ID="txtDescricaoGrauParentesco" runat="server" TextMode="MultiLine" Height="70" Width="99%" CssClass="textbox"></asp:TextBox>
                        </fieldset>
                    </fieldset>

                    <fieldset id="fieldsetTelefone">
                    <legend>Telefone:</legend>
                        <h2 style="font-size:14px">1º Telefone:</h2>
                        <table>
                            <tr>
                                <td>
                                    <label>Tipo de Telefone:</label>
                                    <asp:DropDownList ID="ddlTipoTelefone1" runat="server" Width="45.5%" AutoPostBack="True" CssClass="textbox" OnSelectedIndexChanged="ddlTipoTelefone1_SelectedIndexChanged">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                        <asp:ListItem Value="Residencial" Text="Residencial"></asp:ListItem>
                                        <asp:ListItem Value="Celular" Text="Celular"></asp:ListItem>
                                        <asp:ListItem Value="Recado" Text="Recado"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Panel ID="pnlOperadora1" runat="server" Visible="False">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorOperadora1" runat="server" ControlToValidate="ddlOperadora1" Display="Dynamic" ErrorMessage="Campo Operadora do 1º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                        <label>Operadora:</label>
                                        <asp:DropDownList ID="ddlOperadora1" runat="server" Width="39.5%" CssClass="textbox">
                                            <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="OI" Text="OI"></asp:ListItem>
                                            <asp:ListItem Value="VIVO" Text="VIVO"></asp:ListItem>
                                            <asp:ListItem Value="TIM" Text="TIM"></asp:ListItem>
                                            <asp:ListItem Value="CLARO" Text="CLARO"></asp:ListItem>
                                        </asp:DropDownList>
                                    </asp:Panel><br /><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDDD1" runat="server" ControlToValidate="ddlDDD1" Display="Dynamic" ErrorMessage="Campo DDD do 1º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>DDD:</label>
                                    <asp:DropDownList ID="ddlDDD1" runat="server" Width="39%" CssClass="textbox">

                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumeroTelefone1" runat="server" ControlToValidate="txtNumeroTelefone1" Display="Dynamic" ErrorMessage="Campo Número 1º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>Número:</label>
                                    <asp:TextBox ID="txtNumeroTelefone1" runat="server" Width="39%" CssClass="txtNumeroTelefone1 textbox"></asp:TextBox><br /><br />
                                </td>
                            </tr>
                        </table>

                        <h2 style="font-size:14px">2º Telefone:</h2>
                        <table>
                            <tr>
                                <td>
                                    <label>Tipo de Telefone:</label>
                                    <asp:DropDownList ID="ddlTipoTelefone2" runat="server" Width="45.5%" AutoPostBack="True" CssClass="textbox" OnSelectedIndexChanged="ddlTipoTelefone2_SelectedIndexChanged">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                        <asp:ListItem Value="Residencial">Residencial</asp:ListItem>
                                        <asp:ListItem Value="Celular">Celular</asp:ListItem>
                                        <asp:ListItem Value="Recado">Recado</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Panel ID="pnlOperadora2" runat="server" Visible="False">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorOperadora2" runat="server" ControlToValidate="ddlOperadora2" Display="Dynamic" ErrorMessage="Campo Operadora do 2º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>Operadora:</label>
                                    <asp:DropDownList ID="ddlOperadora2" runat="server" Width="39.5%" CssClass="textbox">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                        <asp:ListItem Value="OI">OI</asp:ListItem>
                                        <asp:ListItem Value="VIVO">VIVO</asp:ListItem>
                                        <asp:ListItem Value="TIM">TIM</asp:ListItem>
                                        <asp:ListItem Value="CLARO">CLARO</asp:ListItem>
                                    </asp:DropDownList>
                                    </asp:Panel><br /><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDDD2" runat="server" ControlToValidate="ddlDDD2" Display="Dynamic" ErrorMessage="Campo DDD do 2º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>DDD:</label>
                                    <asp:DropDownList ID="ddlDDD2" runat="server" Width="39%" CssClass="textbox">
                            
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumeroTelefone2" runat="server" ControlToValidate="txtNumeroTelefone2" Display="Dynamic" ErrorMessage="Campo Número 2º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>Número:</label>
                                    <asp:TextBox ID="txtNumeroTelefone2" runat="server" Width="39%" CssClass="txtNumeroTelefone2 textbox"></asp:TextBox><br /><br />
                                </td>
                            </tr>
                        </table>

                        <h2 style="font-size:14px">3º Telefone:</h2>
                        <table>
                            <tr>
                                <td>
                                    <label>Tipo de Telefone:</label>
                                    <asp:DropDownList ID="ddlTipoTelefone3" runat="server" Width="45.5%" AutoPostBack="True" CssClass="textbox" OnSelectedIndexChanged="ddlTipoTelefone3_SelectedIndexChanged">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                        <asp:ListItem Value="Residencial">Residencial</asp:ListItem>
                                        <asp:ListItem Value="Celular">Celular</asp:ListItem>
                                        <asp:ListItem Value="Recado">Recado</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:Panel ID="pnlOperadora3" runat="server" Visible="False">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidatorOperadora3" runat="server" ControlToValidate="ddlOperadora3" Display="Dynamic" ErrorMessage="Campo Operadora do 3º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                        <label>Operadora:</label>
                                        <asp:DropDownList ID="ddlOperadora3" runat="server" Width="39.5%" CssClass="textbox">
                                            <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                            <asp:ListItem Value="OI">OI</asp:ListItem>
                                            <asp:ListItem Value="VIVO">VIVO</asp:ListItem>
                                            <asp:ListItem Value="TIM">TIM</asp:ListItem>
                                            <asp:ListItem Value="CLARO">CLARO</asp:ListItem>
                                        </asp:DropDownList>
                                    </asp:Panel><br /><br />
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDDD3" runat="server" ControlToValidate="ddlDDD3" Display="Dynamic" ErrorMessage="Campo DDD do 3º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>DDD:</label>
                                    <asp:DropDownList ID="ddlDDD3" runat="server" Width="39%" CssClass="textbox">
                                        <asp:ListItem Value="" Text="-Selecione-" Selected="True"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorNumeroTelefone3" runat="server" ControlToValidate="txtNumeroTelefone3" Display="Dynamic" ErrorMessage="Campo Número 3º Telefone é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false" Enabled="false"></asp:RequiredFieldValidator>
                                    <label>Número:</label>
                                    <asp:TextBox ID="txtNumeroTelefone3" runat="server" Width="39%" CssClass="txtNumeroTelefone3 textbox"></asp:TextBox><br /><br />
                                </td>
                            </tr>
                        </table>
                    </fieldset>

                    <fieldset id="fieldsetEndereco" class="extfieldsetDocumentos">
                    <legend>Endereço:</legend>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorUF" runat="server" ControlToValidate="ddlUF" Display="Dynamic" ErrorMessage="Campo UF é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>UF:</label>
                    <asp:DropDownList ID="ddlUF" runat="server" Width="23%" CssClass="textbox" OnLoad="ddlUF_Load">
                        
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorEstado" runat="server" ControlToValidate="ddlEstado" Display="Dynamic" ErrorMessage="Campo Estado é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>Estado:</label>
                    <asp:DropDownList ID="ddlEstado" runat="server" Width="23%" CssClass="textbox" OnLoad="ddlEstado_Load">

                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCidade" runat="server" ControlToValidate="txtCidade" Display="Dynamic" ErrorMessage="Campo Cidade é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>Cidade:</label>
                    <asp:TextBox ID="txtCidade" runat="server" Width="23%" CssClass="textbox"></asp:TextBox><br /><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorLogradouro" runat="server" ControlToValidate="txtLogradouro" Display="Dynamic" ErrorMessage="Campo Logradouro é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>Logradouro:</label>
                    <asp:TextBox ID="txtLogradouro" runat="server" Width="34.3%" CssClass="textbox"></asp:TextBox>
                    <label>Número:</label>
                    <asp:TextBox ID="txtNumeroEnd" runat="server" Width="33%" CssClass="textbox"></asp:TextBox><br /><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTipoLogradouro" runat="server" ControlToValidate="txtDataEmissao" Display="Dynamic" ErrorMessage="Campo Tipo Logradouro é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>Tipo do Logradouro:</label><br />
                    <asp:RadioButtonList ID="rdbTipoLogradouro" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow">
                        <asp:ListItem Value="Residencial">Residencial</asp:ListItem>
                        <asp:ListItem Value="Comercial">Comercial</asp:ListItem>
                    </asp:RadioButtonList><br /><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorBairro" runat="server" ControlToValidate="txtDataEmissao" Display="Dynamic" ErrorMessage="Campo Bairro é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>Bairro:</label><br />
                    <asp:TextBox ID="txtBairro" runat="server" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                    <label>Complemento:</label><br />
                    <asp:TextBox ID="txtComplemento" runat="server" Width="99%" CssClass="textbox"></asp:TextBox><br /><br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorCEP" runat="server" ControlToValidate="txtCEP" Display="Dynamic" ErrorMessage="Campo CEP é obrigatório." Text="*" ForeColor="Red" EnableClientScript="false"></asp:RequiredFieldValidator>
                    <label>CEP:</label><br />
                    <asp:TextBox ID="txtCEP" runat="server" MaxLength="8" Width="99%" CssClass="txtCEP textbox"></asp:TextBox><br /><br />
                    <asp:Button ID="btnCadastrar" runat="server" Text="Cadastrar" CssClass="button" OnClick="btnCadastrar_Click" />
                </fieldset>
            </article>
            </ContentTemplate>
            </asp:UpdatePanel>
        </section>
    </section>
</asp:Content>
