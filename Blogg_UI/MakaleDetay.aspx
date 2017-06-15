<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="MakaleDetay.aspx.cs" Inherits="Blogg_UI.MakaleDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="post">
				<h2 class="title"><a href="#"><asp:Literal ID="ltrBaslik" Text="text" runat="server" ></asp:Literal> </a></h2>
				<p class="meta"><span class="date"> <asp:Literal ID="ltrTarih" runat="server"></asp:Literal></span><span class="posted">Gonderen <a href="#"> <asp:Literal ID="ltrGonderen" runat="server"></asp:Literal></a></span></p>
				<div style="clear: both;">&nbsp;</div>
				<div class="entry">
					<p>

                        <asp:Literal ID="ltrIcerik" runat="server"></asp:Literal>
					</p>
					
				</div>
			</div>

    <table style="width:100%">
        <tr>
            <th style="width: 117px">Okunma Sayisi:</th>
            <td>
                <asp:Literal ID="ltrOkunmaSayisi" runat="server"></asp:Literal> </td>
        </tr>
    </table>

    <div class="comment_list">

           <asp:Repeater ID="rptYorumlar" runat="server">
               <ItemTemplate>

                   <div class="comment">
                       <div class="comment_gravatar left">
                           <img alt="" src="images/sample-gravatar.jpg" height="32" width="32" />
                       </div>
                       <div class="comment_author left">
                           <a href="#"><%# Eval("AdSoyad") %></a>
                           <div class="comment_date">
                               <a href="#"><%# Eval("yorumTarihi") %></a>
                           </div>

                           <div class="clearer">&nbsp;</div>

                           <div class="comment_body">
                               <p><%# Eval("YorumIcerik") %></p>
                           </div>

                       </div>

                   </div>

               </ItemTemplate>

               <SeparatorTemplate>
                   <hr />
               </SeparatorTemplate>

           </asp:Repeater>


    </div>
 



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
            <asp:LinkButton ID="lnkKaydet" runat="server" OnClick="lnkKaydet_Click" OnClientClick="return confirm(&quot;Kaydetmek istiyor musunuz?&quot;)">Kaydet</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td style="width: 131px">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>


</asp:Content>