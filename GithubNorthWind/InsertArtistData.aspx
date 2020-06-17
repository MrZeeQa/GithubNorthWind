<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InsertArtistData.aspx.cs" Inherits="InsertArtistData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <h2>Voeg een nieuwe artiest toe</h2><br />
    <asp:Panel ID="PanelFormInsert" runat="server">
 Vul de artiestennaam in:<br />
 <asp:TextBox ID="TextBoxArtistName" runat="server" />
 <br />
 <asp:Button ID="ButtonSubmit" Text="Verzenden" runat="server" OnClick="ButtonSubmit_Click" />
    <asp:Label ID="LabelErrorMessage" runat="server" />

    </asp:Panel>
    <asp:Panel ID="PanelUserMessage" runat="server">
        De gegevens werden correct opgeslagen.
    </asp:Panel>
</asp:Content>

