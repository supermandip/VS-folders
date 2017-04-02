<%@ Page Title="" Language="C#" MasterPageFile="~/karki.Master" AutoEventWireup="true" CodeBehind="select.aspx.cs" Inherits="final.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="dd" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dd_SelectedIndexChanged"></asp:DropDownList>
    <br /> <br />

    <asp:DetailsView ID="detail" runat="server" Height="50px" Width="125px"></asp:DetailsView>
     <br /> <br />

    <asp:GridView ID="grid" runat="server"></asp:GridView>
</asp:Content>
