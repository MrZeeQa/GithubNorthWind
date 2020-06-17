<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InsertCustomerData.aspx.cs" Inherits="InsertCustomerData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="PanelFormInsert" runat="server">
    <table cellpadding="0" cellspacing="0" border="0">
 <tr height="26">
 <td>Voornaam:</td>
 <td><asp:TextBox ID="TextBoxFirstName" runat="server" /></td>
 </tr>
 <tr height="26">
 <td>Achternaam: </td>
 <td><asp:TextBox ID="TextBoxLastName" runat="server" /></td>
 </tr>
 <tr height="26">
 <td>Bedrijfsnaam: </td>
 <td><asp:TextBox ID="TextBoxCompanyName" runat="server" /></td>
 </tr>
 <tr height="26">
 <td>Stad: </td>
 <td><asp:TextBox ID="TextBoxCity" runat="server" /></td>


 <tr height="26">
 <td><asp:Button ID="ButtonSubmit" Text="Verzenden" runat="server"
 onclick="ButtonSubmit_Click" /></td>
 </tr>
 </table>
 <asp:Label ID="LabelErrorMessage" runat="server" />
    </asp:Panel>
    <asp:Panel ID="PanelUserMessage" runat="server">
        De gegevens werden correct opgeslagen.
    </asp:Panel>
</asp:Content>

