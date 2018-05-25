<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookrentalTest.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 117px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="text-justify" colspan="2" style="height: 43px">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Sign In"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="text-justify" style="width: 117px; height: 48px">
                <asp:Label ID="txtUsername" runat="server" Font-Size="Medium" Text="Username"></asp:Label>
            </td>
            <td style="height: 48px">
                <asp:TextBox ID="txtLogUsername" runat="server" CssClass="col-xs-offset-0" Height="26px" Width="287px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-justify" style="width: 117px; height: 37px">
                <asp:Label ID="txtPassword" runat="server" Font-Size="Medium" Text="Password"></asp:Label>
            </td>
            <td style="height: 37px">
                <asp:TextBox ID="txtLogPassword" runat="server" Height="26px" Width="289px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="height: 17px; width: 117px">&nbsp;</td>
            <td style="height: 17px">
                <asp:CheckBox ID="ckRemember" runat="server" Text="Remember Me" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblForgot" runat="server" Text="Forgot Password"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 117px; height: 46px"></td>
            <td style="height: 46px">
                <asp:Button ID="btnLogin" runat="server" Font-Bold="True" Font-Size="Medium" Height="35px" OnClick="btnLogin_Click" Text="Sign In" Width="290px" />
            </td>
        </tr>
        <tr>
            <td style="width: 117px; height: 34px"></td>
            <td class="text-left" style="height: 34px">&nbsp;<asp:Label ID="Label2" runat="server" Text="Dont have an account?"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblRegister" runat="server" BorderColor="Black" Font-Bold="True" Font-Size="Medium" ForeColor="Blue" Text="Register"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 117px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
