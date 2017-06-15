<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="UyeKayit.aspx.cs" Inherits="Blogg_UI.UyeKayit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 242px;
        }
        th {
        font-weight: bold;
        font-size: 11px;
        font-family: Trebuchet MS,Verdana,Arial, Helvetica, sans-serif;
        color:#4f6b72;
        border: 1px solid #C1DAD7;
        letter-spacing: 2px;
        padding: 5px;
        text-align: left;
        background-color:#CAE8EA;

        
        }
        td
        {
            border-right: 1px solid #C1DAD7;
            border-bottom: 1px solid #C1DAD7;
            padding: 6px;
            color:#4f6b72;
            background-color:#fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="true"></asp:ScriptManager>

    <asp:CalendarExtender ID="CalendarExtender1" runat="server" PopupPosition="Right" TargetControlID="txtDogumTarih"> 


    </asp:CalendarExtender>
    
    
     <table class="auto-style1">

        <thead>
            <tr>
                <th>Üye Kayıt</th>
            </tr>
        </thead>

        <tr>
            <td class="auto-style2">KullanıcıAdı:</td>
            <td>
                <asp:TextBox ID="txtKullaniciAdi" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Şifre:</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">ŞifreTekrar:</td>
            <td>
                <asp:TextBox ID="txtSifreTekrar" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Adı:</td>
            <td>
                <asp:TextBox ID="txtAd" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Soyadı:</td>
            <td>
                <asp:TextBox ID="txtSoyad" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">DogumTarihi:</td>
            <td>
                <asp:TextBox ID="txtDogumTarih" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Cinsiyet:</td>
            <td>
                <asp:RadioButton ID="rdbBay" Text="Bay" runat="server" GroupName="Cinsiyet" />
                <asp:RadioButton ID="rdbBayan" Text="Bayan" runat="server" GroupName="Cinsiyet" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Telefon:</td>
            <td>
                <asp:TextBox ID="txtTelefon" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sehir:</td>
            <td>
                <asp:DropDownList ID="ddlSehirler" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSehirler_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Ilce:</td>
            <td>
                <asp:DropDownList ID="ddlIlceler" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Adres:</td>
            <td>
                <asp:TextBox ID="txtAdres" runat="server" Height="98px" TextMode="MultiLine" Width="274px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="btnKaydet" runat="server" Text="Kaydet" OnClick="btnKaydet_Click" />
            </td>
        </tr>
    </table>



</asp:Content>
