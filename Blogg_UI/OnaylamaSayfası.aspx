<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="OnaylamaSayfası.aspx.cs" Inherits="Blogg_UI.OnaylamaSayfası" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="view1" runat="server">
            <table class="auto-style1">
        <tr>
            <td style="width: 131px">Ad Soyad:</td>
            <td>
                <asp:TextBox ID="txtAdsoyad" runat="server" Height="20px" Width="193px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server" Width="191px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">Website:</td>
            <td>
                <asp:TextBox ID="txtWebsite" runat="server" Height="20px" Width="194px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">Yorum:</td>
            <td>
                <asp:TextBox ID="txtYorum" runat="server" Height="111px" TextMode="MultiLine" Width="284px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>
                <asp:LinkButton ID="btnOnayla" runat="server" OnClick="btnOnayla_Click" OnClientClick="return confirm(&quot;Onaylamak istiyor musunuz?&quot;)">Onayla</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td style="width: 131px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

        </asp:View>
        <asp:View ID="view2" runat="server">

            <a href="../default.aspx">Yorum Onaylanmıştır. Ana sayfa için Tıklayın</a>
        </asp:View>

    </asp:MultiView>


    
</asp:Content>
