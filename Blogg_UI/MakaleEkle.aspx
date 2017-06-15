<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="MakaleEkle.aspx.cs" Inherits="Blogg_UI.MakaleEkle" ValidateRequest="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="auto-style1">
        <tr>
            <td style="width: 168px">Kategorisi:</td>
            <td>
                <asp:DropDownList ID="ddlKategoriler" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="width: 168px; height: 19px">Başlık</td>
            <td style="height: 19px">
                <asp:TextBox ID="txtBaslik" runat="server" Height="64px" TextMode="MultiLine" Width="221px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 168px">Makale İçerik:</td>
            <td>
                <textarea class="ckeditor" id="editor1" name="S1" style="width: 384px; height: 207px" runat="server"></textarea></td>
        </tr>
        <tr>
            <td style="width: 168px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 168px">&nbsp;</td>
            <td>
                <asp:Button ID="btnMakaleKaydet" runat="server" Text="Makale Kaydet" OnClick="btnMakaleKaydet_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 168px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>