<%@ Page Title="" Language="C#" MasterPageFile="~/karki.Master" AutoEventWireup="true" CodeBehind="picture.aspx.cs" Inherits="final.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:DropDownList ID="pdd" runat="server" OnSelectedIndexChanged="pdd_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
     <asp:Image ID="rpic" runat="server"  Width ="100px" ></asp:Image>
   
</asp:Content>
