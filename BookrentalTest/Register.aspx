<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookrentalTest.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 97px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="2" style="height: 58px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Create Account"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 33px; width: 97px">
                <asp:Label ID="Label2" runat="server" Text="Fisrt Name"></asp:Label>
            </td>
            <td style="height: 33px">
                <asp:TextBox ID="txtName" runat="server" Height="31px" style="margin-left: 55" Width="362px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 37px; width: 97px">
                <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td style="height: 37px">
                <asp:TextBox ID="txtSurname" runat="server" Height="29px" Width="362px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 40px; width: 97px">
                <asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="txtContact" runat="server" Height="28px" Width="360px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 32px; width: 97px">
                <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>
            </td>
            <td style="height: 32px">
                <asp:TextBox ID="txtUsername" runat="server" Height="32px" Width="359px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 36px; width: 97px">
                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="height: 36px">
                <asp:TextBox ID="txtPassword" runat="server" Height="29px" Width="358px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 37px; width: 97px">
                <asp:Label ID="Label7" runat="server" Text="Role"></asp:Label>
            </td>
            <td style="height: 37px">
                <asp:TextBox ID="txtRole" runat="server" Height="32px" style="margin-left: 31" Width="362px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 66px">&nbsp;</td>
            <td style="height: 66px">
                <asp:Button ID="btnRegister" runat="server" Font-Bold="True" Font-Size="Medium" Height="40px" OnClick="btnRegister_Click" style="margin-right: 59" Text="Register" Width="214px" />
            </td>
        </tr>
    </table>
</asp:Content>
