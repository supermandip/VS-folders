<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UpdatePage.aspx.cs" Inherits="Assignment3.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div>
         <label>Mandip</label><br />
        <font color="white">Shows all the movie and information in the Database. </font> <br /> 
        <asp:GridView align="center" ID="allGrid" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
          </asp:GridView>

    </div>
    <br />
    <hr style="clear:both" />
    <div class="col3">
       
        <font color="white">Fill in all information to add a movie to Database.</font> <br /> 
        <label>New Movie ID:</label>
        <input type ="text" id ="bid" runat="server" />
        <br />
        <label>Movie Name :   </label>&nbsp;
        <input type ="text" id ="bname" runat="server" /><br />
        <label>Date:</label>
        <input type ="text" id ="dDate" runat="server" />
        <h4>Director List:</h4>
        <asp:ListBox ID="dList" runat="server"></asp:ListBox>
        <br />
        <h4>Genre List:</h4>
        <asp:ListBox ID="gList" runat="server"></asp:ListBox>
        <br /><br />
        <asp:Button ID="Button1" runat="server" Text="Add a Movie" OnClick="add_Click" />
            
    </div>
    <div class="col3">
       <h3>Delete</h3>
        <div class ="left">
            <asp:DropDownList ID="movieDD" runat="server" AutoPostBack="true" OnSelectedIndexChanged="movieDD_SelectedIndexChanged"></asp:DropDownList>
        </div>
        <div class="right">
            <asp:DetailsView ID="movieDetail" runat="server" Height="50px" Width="125px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#FFFFC0" Font-Bold="True" />
                <FieldHeaderStyle BackColor="#FFFF99" Font-Bold="True" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            </asp:DetailsView>

        </div>
        <hr style="clear:both" />
        <p>
            <asp:Button ID="delete" runat="server" Text="Delete Movie"  OnClick="delete_Click"/>
        </p>
            </div>
</asp:Content>
