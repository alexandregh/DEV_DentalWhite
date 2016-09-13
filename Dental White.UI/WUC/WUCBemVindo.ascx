<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="WUCBemVindo.ascx.cs" Inherits="Dental_White.UI.WUC.WUCBemVindo" %>

<aside id="bemVindo">
    <label id="txtBemVindo">Bem-vindo <asp:Literal ID="txtVisitante" runat="server" Text="Visitante"></asp:Literal>.</label><br />
    <asp:Panel ID="pnlPerfilLogout" runat="server" Visible="false">
        <label class="txtPerfil">Perfil: <asp:Literal ID="txtPerfil" runat="server"></asp:Literal></label><br />
        <asp:LinkButton ID="linkLogout" runat="server" CssClass="txtLogout" OnClick="linkLogout_Click">Logout</asp:LinkButton>
    </asp:Panel>
</aside>