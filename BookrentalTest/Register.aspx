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
                <asp:TextBox ID="txtName" runat="server" Height="31px"  Width="362px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName" ErrorMessage="Please provide First Name" SetFocusOnError="True" ToolTip="Please provide First Name">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 37px; width: 97px">
                <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
            </td>
            <td style="height: 37px">
                <asp:TextBox ID="txtSurname" runat="server" Height="29px" Width="362px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSurname" ErrorMessage="Please provide Last Name" ToolTip="Please provide Last Name">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 40px; width: 97px">
                <asp:Label ID="Label4" runat="server" Text="Contact"></asp:Label>
            </td>
            <td style="height: 40px">
                <asp:TextBox ID="txtContact" runat="server" Height="28px" Width="360px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtContact" ErrorMessage="Please provide Contact details" ToolTip="Please provide Contact details">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 32px; width: 97px">
                <asp:Label ID="Label5" runat="server" Text="Username"></asp:Label>
            </td>
            <td style="height: 32px">
                <asp:TextBox ID="txtUsername" runat="server" Height="32px" Width="359px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtUsername" ErrorMessage="Please provide Email " ToolTip="Please provide Email ">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 36px; width: 97px">
                <asp:Label ID="Label6" runat="server" Text="Password"></asp:Label>
            </td>
            <td style="height: 36px">
                <asp:TextBox ID="txtPassword" runat="server" Height="29px" Width="358px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtPassword" ErrorMessage="Please provide Password" ToolTip="Please provide Password">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="text-center" style="height: 37px; width: 97px">
                Account Type</td>
            <td style="height: 37px">
                <asp:DropDownList ID="dropdownRole" runat="server" Height="28px" Width="366px">
                    <asp:ListItem Value="-1">Select Role</asp:ListItem>
                    <asp:ListItem Value="1">Admin</asp:ListItem>
                    <asp:ListItem Value="2">Client</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="height: 66px">&nbsp;</td>
            <td style="height: 66px">
                <asp:Button ID="btnRegister" runat="server" Font-Bold="True" Font-Size="Medium" Height="40px" OnClick="btnRegister_Click"  Text="Register" Width="214px" />
            </td>
        </tr>
    </table>
</asp:Content>
