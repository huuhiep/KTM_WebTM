<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="tList.aspx.cs" Inherits="KTM_WebTM.tList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section><div>
<hgroup>
<h2><%: Page.Title %></h2>
</hgroup>
<asp:ListView ID="bookList" runat="server" DataKeyNames="TIN_ID"
GroupItemCount="4"
ItemType="KTM_WebTM.THONGTIN.TINTUC" SelectMethod="GetBooks">
<EmptyDataTemplate>
<table >
<tr>
<td>No data was returned.</td>
</tr>
</table>
</EmptyDataTemplate>
<EmptyItemTemplate>
<td/>
</EmptyItemTemplate>
<GroupTemplate>
<tr id="itemPlaceholderContainer" runat="server">
<td id="itemPlaceholder" runat="server"></td>
</tr>
</GroupTemplate>
<ItemTemplate>
<td runat="server">
<table>
<tr>
<td>
<a href="tDetails.aspx?TIN_ID=<%#:Item.TIN_ID%>">
<img src ="/Images/<%#:Item.HINHANH%>"
width="150" height="225" style="border:solid" /></a>
</td>
</tr>
<tr>
<td>
<a href="tDetails.aspx?TIN_ID=<%#:Item.TIN_ID%>">
<span>
<%#:Item.TIEUDE%>
</span>
</a>
<br />
<span>

</span><br />
</td>
</tr>
<tr>
<td>&nbsp;</td>
</tr>
</table>
</p>
</td>
</ItemTemplate>
<LayoutTemplate>
<table style="width:100%;">
<tbody>
<tr>
<td>
<table id="groupPlaceholderContainer" runat="server"
style="width:100%">
<tr id="groupPlaceholder"></tr>
</table>
</td>
</tr>
<tr>
<td></td>
</tr>
<tr></tr>
</tbody>
</table>
</LayoutTemplate>
</asp:ListView>
</div>
</section>

</asp:Content>
