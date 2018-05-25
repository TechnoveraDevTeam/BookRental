<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentYourBook.aspx.cs" Inherits="BookrentalTest.RentYourBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style="height: 60px; " class="text-center">Rent Your Book</td>
        </tr>
        <tr>
            <td style="height: 60px; width: 298px;" class="text-left">Book Category</td>
            <td style="height: 60px; " class="text-justify">
                <asp:TextBox ID="category" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 60px; width: 298px;" class="text-left">Book Title</td>
            <td style="height: 60px; " class="text-justify">
                <asp:TextBox ID="title" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 60px; width: 298px" class="text-left">
                <asp:Label ID="Label1" runat="server" Text="Author Name"></asp:Label>
            </td>
            <td style="height: 60px">
                <asp:TextBox ID="aName" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 41px; width: 298px" class="text-left">
                <asp:Label ID="Label2" runat="server" Text="Publisher Name"></asp:Label>
            </td>
            <td style="height: 41px">
                <asp:TextBox ID="pName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 41px; width: 298px" class="text-left">
                <asp:Label ID="Label3" runat="server" Text="Publisher Date"></asp:Label>
            </td>
            <td style="height: 41px">
                <asp:TextBox ID="pDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 40px; width: 298px" class="text-left">
                <asp:Label ID="Label4" runat="server" Text="ISBN"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="isbn" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 38px; width: 298px" class="text-left">
                <asp:Label ID="Label5" runat="server" Text="Uploud picture"></asp:Label>
            </td>
            <td style="height: 38px">
                <asp:TextBox ID="TextBox5" runat="server" Height="28px" Width="216px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" style="margin-left: 31px" Text="Uploud Picture" Width="145px" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td style="text-align: left; width: 298px" class="modal-sm">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: left; width: 298px" class="modal-sm">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>
