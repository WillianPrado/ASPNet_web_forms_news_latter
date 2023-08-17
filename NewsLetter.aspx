<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewsLetter.aspx.cs" Inherits="sucesso_e_motivacao.NewsLetter" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="noticias" class="container-fluid">
        <div id="index3" class="row">
             <!-- Use o controle Literal para renderizar o conteúdo -->
            <asp:Literal ID="LiteralResponseText" runat="server"></asp:Literal>
        </div>       
    </div>
</asp:Content>
