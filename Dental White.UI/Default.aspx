<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Default.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dental_White.UI.Default1" Buffer="true" Trace="false" EnableTheming="false" %>

<%@ Register Src="~/WUC/WUCBemVindo.ascx" TagPrefix="uc1" TagName="WUCBemVindo" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Recursos/css/cssreset/cssreset.css" media="screen" />
    <link rel="stylesheet" href="Recursos/css/DentalWhite/DentalWhite.css" media="screen" />
    <link rel="stylesheet" href="Recursos/css/bodyPrincipal/bodyPrincipal.css" media="screen" />
    <link rel="stylesheet" href="Recursos/css/textos/textos.css" media="screen" />
    <link rel="stylesheet" href="Recursos/jq/coin-slider-footer/coin-slider-styles-body.css" media="screen" />
    <link rel="stylesheet" href="Recursos/jq/coin-slider-footer/coin-slider-styles-footer.css" media="screen" />
    <link rel="stylesheet" href="Recursos/jq/SimplejQueryDropdowns/css/style.css" media="screen" />
    <script src="Recursos/jq/jquery-2.1.4.min.js" type="text/javascript"></script>
    <script src="Recursos/jq/coin-slider-body/coin-slider-body.js" type="text/javascript"></script>
    <script src="Recursos/jq/coin-slider-body/scriptcoin-slider-body.js" type="text/javascript"></script>
    <script src="Recursos/jq/coin-slider-footer/coin-slider-footer.js" type="text/javascript"></script>
    <script src="Recursos/jq/coin-slider-footer/scriptcoin-slider-footer.js" type="text/javascript"></script>
    <script src="Recursos/jq/SimplejQueryDropdowns/js/jquery.dropdownPlain.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderSectionBody" runat="server">
    <section id="sectionBody">
        <section id="contentBody">
            <uc1:WUCBemVindo runat="server" id="WUCBemVindo" />
            <article id="boxBemVindo">
                <h1>Bem-vindo(a) ao Dental White.</h1><br />
                <p class="paragrafo">
                    Oferecemos o melhor serviço e comodidade à você e sua família.
                </p>
                <p class="paragrafo">
                    Contate-nos ou fale com um dos nossos representantes da Dental White e venha fazer parte de mais um
                    de nossos clientes satisfeitos. Oferecemos todos os serviços odontológicos para você e sua família
                    com os profissionais mais renomados da área para sua segurança, além de contar com as tecnologias e
                    aparelhos mais avançados até o momento aparelhos.
                </p>
                <p class="paragrafo">
                    Venha conferir e se apaixone-se pelos nossos serviços.
                </p>
            </article>
            <aside id="boxSlidePrincipal">
                <div id="coin-slider-body">
                    <img class="figurasAntesDepois" src="Recursos/imagens/dentalwhite/dentista1.jpg">
                    <img class="figurasAntesDepois" src="Recursos/imagens/dentalwhite/dentista2.jpg">
                    <img class="figurasAntesDepois" src="Recursos/imagens/dentalwhite/dentista3.jpg">
                    <img class="figurasAntesDepois" src="Recursos/imagens/dentalwhite/dentista4.jpg">
                </div>
            </aside>
            <article id="boxServicosProfissionais">
                <h2>Serviços Profissionais.</h2><br />
                <p class="paragrafo">
                    Disponibilizamos aos nossos clientes (pacientes e/ou dependentes) os melhores serviços odontológicos
                    com a qualidade e satisfação que merecem.
                </p>
                <p class="paragrafo">
                    Dentre alguns de nossos Serviços Profissionais incluem:<br />
                    <ul class="lista">
                        <li>Odontopediatria;</li>
                        <li>Ortodontia;</li>
                        <li>Endodontia;</li>
                        <li>Prótese Dentária</li>
                    </ul>
                </p>
                <p class="paragrafo">
                    <a href="#">Mais+</a>
                </p>
            </article>
        </section>
    </section>
</asp:Content>
