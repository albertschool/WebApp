<%@ Page Title="" Language="C#" MasterPageFile="~/Webforms/Site1.Master" AutoEventWireup="true" CodeBehind="PageRegLog.aspx.cs" Inherits="WebApp.Webforms.PageRegLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Style/PageRegLog.css" rel="stylesheet" />
    <script src="../Code/RegLog.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="logTable">
        <tr>
            <td id="td1">שם משתמש</td>
            <td id="td2">
                <input type="text" name="userName" id="userName" onchange="userNameVal()" />
            </td>
            <td id="userNameMsg" class="valMsg"></td>
        </tr>
        <tr>
            <td id="td1">סיסמה</td>
            <td id="td2">
                <input type="password" name="password" id="password" onchange="passwordVal()" />
            </td>
            <td id="passwordMsg" class="valMsg"></td>
        </tr>
        <tr id="reg1">
            <td id="td1">אימות סיסמה</td>
            <td id="td2">
                <input type="password" name="confirm" id="confirm" onchange="confirmFun()" />
            </td>
            <td id="confirmMsg" class="valMsg"></td>
        </tr>
        <tr id="reg2" visibility="collapse">
            <td id="td1">שם פרטי</td>
            <td id="td2">
                <input type="text" name="fName" id="fName" oninput="confirmfName()" />
            </td>
            <td id="fNameMsg" class="valMsg"></td>
        </tr>
        <tr id="reg3" visibility="collapse">
            <td id="td1">שם משפחה</td>
            <td id="td2">
                <input type="text" name="lName" id="lName" oninput="confirmlName()" />
            </td>
            <td id="lNameMsg" class="valMsg"></td>
        </tr>
        <tr id="reg4" visibility="collapse">
            <td id="td1">טלפון</td>
            <td id="td2">
                <input type="text" name="phone" id="phone" oninput="confirmPhone()" />
            </td>
            <td id="phoneMsg" class="valMsg"></td>
        </tr>
        <tr id="reg5" visibility="collapse">
            <td id="td1">דואר אלקטרוני</td>
            <td id="td2">
                <input type="text" name="email" id="email" onchange="confirmemail()" />
            </td>
            <td id="emailMsg" class="valMsg"></td>
        </tr>
        <tr id="reg6" visibility="collapse">
            <td id="td1">מגדר</td>
            <td id="td2">
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
                <input type="button" id="login" value="Register" onclick="logOrReg()" /> &nbsp; &nbsp;
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
