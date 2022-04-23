<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Site1.Master" AutoEventWireup="true" CodeBehind="PageUsers.aspx.cs" Inherits="WebApp.Webforms.PageUsers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/PageUsers.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="header">
        <h1>רשימת משתמשים</h1>
    </div>
    <div id="tableDiv" class="tableDiv" runat="server">

    </div>
</asp:Content>
