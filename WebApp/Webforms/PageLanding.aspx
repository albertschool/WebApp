<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Site1.Master" AutoEventWireup="true" CodeBehind="PageLanding.aspx.cs" Inherits="WebApp.Webforms.PageLanding" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/PageLanding.css" rel="stylesheet" />
    <script src="../Code/Landing.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="header">
        <h1>ברוכים הבאים</h1>
        <input id="btnEnter" type="button" value="כניסה" onclick="passInside()" />
    </div>
</asp:Content>
