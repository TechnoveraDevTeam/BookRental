<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RentBook.aspx.cs" Inherits="BookrentalTest.RentBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        <table class="nav-justified">
            <tr>
                <td style="width: 602px">
                    <asp:Panel ID="Panel1" runat="server" Height="399px" Width="590px">
                        <table class="nav-justified">
                            <tr>
                                <td style="width: 237px">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="width: 237px; height: 232px;">
                                    <asp:Image ID="Image1" runat="server" Height="178px" Width="208px" />
                                </td>
                                <td style="height: 232px">&nbsp;<table class="nav-justified" style="height: 153px">
                                        <tr>
                                            <td style="width: 127px">
                                                &nbsp;
                                                <asp:Label ID="Label1" runat="server" Text="Book Title"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lbl_bookTitle" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 127px">
                                                &nbsp;
                                                <asp:Label ID="Label2" runat="server" Text="Author"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lbl_author" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 127px; height: 23px;">
                                                &nbsp;
                                                <asp:Label ID="Label3" runat="server" Text="Publisher"></asp:Label>
                                            </td>
                                            <td style="height: 23px">
                                                <asp:Label ID="lbl_publisher" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 127px; height: 37px;">
                                                &nbsp;
                                                <asp:Label ID="Label4" runat="server" Text="Publication Date"></asp:Label>
                                            </td>
                                            <td style="height: 37px">
                                                <asp:Label ID="lbl_publicationDate" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 127px">
                                                &nbsp;
                                                <asp:Label ID="Label5" runat="server" Text="ISBN"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lbl_isbn" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 127px">
                                                &nbsp;
                                                <asp:Label ID="Label6" runat="server" Text="Status"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="lbl_status" runat="server" Text="Label"></asp:Label>
                                            </td>
                                        </tr>
                                        
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Height="406px" style="margin-left: 0px">
                        <table style="width: 100%">
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#6699FF" Text="Rent this  book now"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <table style="width: 100%">
                                        <tr>
                                            <td style="width: 205px; height: 28px">&nbsp;&nbsp;
                                                <asp:RadioButton ID="day7" runat="server" GroupName="Days" OnCheckedChanged="day7_CheckedChanged" Text=" 7 Days" AutoPostBack="True" />
                                            </td>
                                            <td style="height: 28px">
                                                <asp:Label ID="Label10" runat="server" Text="R 25.00"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px; height: 32px">&nbsp;&nbsp;
                                                <asp:RadioButton ID="day14" runat="server" GroupName="Days" OnCheckedChanged="day14_CheckedChanged" Text="14 Days" AutoPostBack="True" />
                                            </td>
                                            <td style="height: 32px">
                                                <asp:Label ID="Label11" runat="server" Text="R 45.00"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px; height: 32px">&nbsp;&nbsp;
                                                <asp:RadioButton ID="day21" runat="server" GroupName="Days" Text="21 Days" OnCheckedChanged="day21_CheckedChanged" AutoPostBack="True" />
                                            </td>
                                            <td style="height: 32px">
                                                <asp:Label ID="Label12" runat="server" Text="R 65.00"></asp:Label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px; height: 27px;">&nbsp;&nbsp;
                                                <asp:RadioButton ID="dayCustom" runat="server" GroupName="Days" OnCheckedChanged="dayCustom_CheckedChanged" Text="Custom Days" AutoPostBack="True" />
                                            </td>
                                            <td style="height: 27px"></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 20px"></td>
                                            <td style="height: 20px"></td>
                                        </tr>
                                        <tr>
                                            <td style="height: 20px">&nbsp;&nbsp;
                                                <asp:TextBox ID="TextBox1" runat="server" Width="130px">Start Date</asp:TextBox>
                                                &nbsp;</td>
                                            <td style="height: 20px">
                                                <asp:TextBox ID="TextBox2" runat="server">End Date</asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="height: 20px">&nbsp;</td>
                                            <td style="height: 20px">&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px">&nbsp;&nbsp;
                                                <asp:Label ID="Label13" runat="server" Text="TOTAL PRICE"></asp:Label>
                                            </td>
                                            <td>R
                                                <asp:Label ID="lbl_totalPrice" runat="server" Text="20.00"></asp:Label>
                                            </td>
                                        </tr>
                                       
                                        <tr>
                                            <td style="width: 205px">&nbsp;</td>
                                            <td>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px">&nbsp; &nbsp;<asp:Label ID="Label14" runat="server" Text="Select the location"></asp:Label>
                                            </td>
                                            <td>
                                                <asp:DropDownList ID="Drp_LocationList" runat="server" Height="18px" Width="131px" OnSelectedIndexChanged="Drp_LocationList_SelectedIndexChanged">
                                                </asp:DropDownList>
                                                
                                            </td>
                                        </tr>
                                        <tr>
                                            <td style="width: 205px">&nbsp;</td>
                                            <td>
                                                <asp:Button ID="Btn_addToCart" runat="server" OnClick="Btn_addToCart_Click" Text="Add To Cart" Width="82px" />
                                            </td>
                                        </tr>
                                       
                                    </table>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
        </table>
    </p>
</asp:Content>
