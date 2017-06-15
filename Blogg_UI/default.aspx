<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Blogg_UI._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <asp:Repeater ID="rptArticles" runat="server">
        <ItemTemplate>

            <div class="post">
				<h2 class="title"><a href='MakaleDetay.aspx?mid=<%# Eval("MakaleID") %>'> <%# Eval("Baslik") %> </a></h2>
                <br />
				<p class="meta"><span class="date"><%# Eval("KayitTarihi") %></span><span class="posted">Gönderen <a href="#"><%# Eval("Gonderen") %></a></span></p>
				<div style="clear: both;">&nbsp;</div>
				<div class="entry">
					<p>
                        <%# Eval("Icerik").ToString().Length>400 ? Eval("Icerik").ToString().Substring(0,400): Eval("Icerik").ToString() %>
					</p>
                    <p class="links">
                    <a href='MakaleDetay.aspx?mid=<%# Eval("MakaleID") %>'>...Fazlası</a>
                    <br />
                    <a href='MakaleDetay.aspx?mid=<%# Eval("MakaleID") %>'>Yorumlar(<%# Eval("YorumSayisi") %>)</a>
                    </p>
				</div>
			</div>


        </ItemTemplate>


    </asp:Repeater>

</asp:Content>
