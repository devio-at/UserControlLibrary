<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="MyCtrlWeb._Default" %>
<%@ Register TagPrefix="my" Assembly="MyWebCtrls" Namespace="MyWebCtrls"  %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">

this is my page

<h2>hi</h2>
<my:mySimple runat="server" id="c1"></my:mySimple>

<h2>hey</h2>
<my:myLabel runat="server" id="c2"></my:myLabel>

<h2>bye</h2>
</asp:Content>
