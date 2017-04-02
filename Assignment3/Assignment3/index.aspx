<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Assignment3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="left">
        <label>Mandip</label><br />
        <font color="white">Please Choose a Movie: </font> <br /> 
        <asp:DropDownList ID="movieDD" runat="server" AutoPostBack="True" OnSelectedIndexChanged="movieDD_SelectedIndexChanged" Height="23px" Width="130px"></asp:DropDownList>
    </div>
    <div class="right">
        <asp:DetailsView ID="movieDetail" runat="server" Height="156px" Width="202px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <EditRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
        </asp:DetailsView>

    </div>
    <hr style="clear:both" />

</asp:Content>
