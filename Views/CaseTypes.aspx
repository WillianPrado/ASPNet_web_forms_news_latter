<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CaseTypes.aspx.cs" Inherits="sucesso_e_motivacao.Views.CaseTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <h2>Lista de Usuários</h2>
        <asp:GridView ID="CaseTypesView" runat="server" AutoGenerateColumns="True">
        </asp:GridView>
    </div>
</asp:Content>
