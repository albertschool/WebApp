<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Site1.Master" AutoEventWireup="true" CodeBehind="PageRegLog.aspx.cs" Inherits="WebApp.Webforms.PageRegLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/PageRegLog.css" rel="stylesheet" />
    <script src="../Code/RegLog.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="logTable">
        <tr>
            <td class="td1">שם משתמש</td>
            <td class="td2">
                <input type="text" name="userName" id="userName" onchange="userNameVal()" />
            </td>
            <td id="userNameMsg" class="valMsg"></td>
        </tr>
        <tr>
            <td class="td1">סיסמה</td>
            <td class="td2">
                <input type="password" name="password" id="password" onchange="passwordVal()" />
            </td>
            <td id="passwordMsg" class="valMsg"></td>
        </tr>
        <tr id="reg1" runat="server">
            <td class="td1">אימות סיסמה</td>
            <td class="td2">
                <input type="password" name="confirm" id="confirm" onchange="confirmFun()" />
            </td>
            <td id="confirmMsg" class="valMsg"></td>
        </tr>
        <tr id="reg2" runat="server">
            <td class="td1">שם פרטי</td>
            <td class="td2">
                <input type="text" name="fName" id="fName" oninput="confirmfName()" />
            </td>
            <td id="fNameMsg" class="valMsg"></td>
        </tr>
        <tr id="reg3" runat="server">
            <td class="td1">שם משפחה</td>
            <td class="td2">
                <input type="text" name="lName" id="lName" oninput="confirmlName()" />
            </td>
            <td id="lNameMsg" class="valMsg"></td>
        </tr>
        <tr id="reg4" runat="server">
            <td class="td1">טלפון</td>
            <td class="td2">
                <input type="text" name="phone" id="phone" oninput="confirmPhone()" />
            </td>
            <td id="phoneMsg" class="valMsg"></td>
        </tr>
        <tr id="reg5" runat="server">
            <td class="td1">דואר אלקטרוני</td>
            <td class="td2">
                <input type="text" name="email" id="email" onchange="confirmemail()" />
            </td>
            <td id="emailMsg" class="valMsg"></td>
        </tr>
        <tr id="reg6" runat="server">
            <td class="td1">מגדר</td>
            <td class="td2">
                <select name="gender" id="gender">
                    <option value="other">אחר</option>
                    <option value="female">אישה</option>
                    <option value="male">גבר</option>
                </select>
            </td>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td style="text-align:center">
                <input type="button" id="btnLogin" name="btnLogin" value="Register" onserverclick="logOrReg" runat="server"/> &nbsp; &nbsp;
                <input type="submit" class="Submit" name="Submit" /> &nbsp; &nbsp;
                <input type="reset" name="Reset" />
            </td>
            <td></td>
        </tr>
    </table>
    <br />
    <div id="msgRslt" name="msgRslt" class="msgRslt" runat="server">
    </div>
</asp:Content>
