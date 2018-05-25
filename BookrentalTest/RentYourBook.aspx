<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentYourBook.aspx.cs" Inherits="BookrentalTest.RentYourBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2" style="height: 60px; text-align: center">Rent Your Book</td>
        </tr>
        <tr>
            <td style="height: 60px; text-align: right; width: 639px">
                <asp:Label ID="Label1" runat="server" Text="Author Name"></asp:Label>
            </td>
            <td style="height: 60px">
                <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 0px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 41px; text-align: right; width: 639px">
                <asp:Label ID="Label2" runat="server" Text="Publisher Name"></asp:Label>
            </td>
            <td style="height: 41px">
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 41px; text-align: right; width: 639px">
                <asp:Label ID="Label3" runat="server" Text="Publisher Date"></asp:Label>
            </td>
            <td style="height: 41px">
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 40px; text-align: right; width: 639px">
                <asp:Label ID="Label4" runat="server" Text="ISBN"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 38px; text-align: right; width: 639px">
                <asp:Label ID="Label5" runat="server" Text="Uploud picture"></asp:Label>
            </td>
            <td style="height: 38px">
                <asp:TextBox ID="TextBox5" runat="server" Height="28px" Width="216px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" style="margin-left: 31px" Text="Uploud Picture" Width="145px" />
            </td>
        </tr>
        <tr>
            <td style="text-align: right; width: 639px">&nbsp;</td>
            <td style="text-align: center">&nbsp;</td>
        </tr>
        <tr>
            <td style="text-align: center; width: 639px">&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" />
            </td>
        </tr>
    </table>
</asp:Content>
