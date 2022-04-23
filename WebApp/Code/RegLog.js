
function isDigit(ch) {
    if (ch >= "0" && ch <= "9")
        true;
    false;
}

function isLetter(ch) {
    if ((ch >= "a" && ch <= "z") || (ch >= "A" && ch <= "Z"))
        return true;
    return false;
}

function validateForm() {
    var btn = document.getElementById("login");
    var res = true;
    res = userNameVal() && res;
    res = passwordVal() && res;
    if (btn.value == "Login") {
        res = confirmFun() && res;
        res = confirmfName() && res;
        res = confirmlName() && res;
        res = confirmemail() && res;
        res = confirmPhone() && res;
    }
    return res;
}

function logOrReg() {
    var btn = document.getElementById("login");

    if (btn.value == "Register") {
        document.getElementById("reg1").style.visibility = "visible";
        document.getElementById("reg2").style.visibility = "visible";
        document.getElementById("reg3").style.visibility = "visible";
        document.getElementById("reg4").style.visibility = "visible";
        document.getElementById("reg5").style.visibility = "visible";
        document.getElementById("reg6").style.visibility = "visible";
        btn.value = "Login";
    } else {
        document.getElementById("reg1").style.visibility = "collapse";
        document.getElementById("reg2").style.visibility = "collapse";
        document.getElementById("reg3").style.visibility = "collapse";
        document.getElementById("reg4").style.visibility = "collapse";
        document.getElementById("reg5").style.visibility = "collapse";
        document.getElementById("reg6").style.visibility = "collapse";
        btn.value = "Register";
    }
}

function userNameVal() {
    var userName = document.getElementById("userName").value;
    var msgBox = document.getElementById("userNameMsg");
    if (userName.length != 6) {
        msgBox.innerHTML = "User name must contain 6 characters";
        return false;
    }
    if (!isLetter(userName[0])) {
        msgBox.innerHTML = "User name must start with a letter";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function passwordVal() {
    var pass = document.getElementById("password").value;
    var msgBox = document.getElementById("passwordMsg");
    if (pass.length < 8) {
        msgBox.innerHTML = "Password must contain at least 8 characters";
        return false;
    }
    if (!isLetter(pass[0])) {
        msgBox.innerHTML = "Password must start with a letter";
        return false;
    }
    var numChar = /[0-9]/;
    if (!numChar.test(pass)) {
        msgBox.innerHTML = "Password must contain one digit character";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function confirmfName() {
    var pass = document.getElementById("fName").value;
    var msgBox = document.getElementById("fNameMsg");
    var numChar = /[0-9]/;
    if (numChar.test(pass)) {
        msgBox.innerHTML = "First name can't contain digit";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function confirmlName() {
    var pass = document.getElementById("lName").value;
    var msgBox = document.getElementById("lNameMsg");
    var numChar = /[0-9]/;
    if (numChar.test(pass)) {
        msgBox.innerHTML = "Last name can't contain digit";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function confirmFun() {
    var pass = document.getElementById("password").value;
    var confirm = document.getElementById("confirm").value;
    var msgBox = document.getElementById("confirmMsg");

    if (pass != confirm) {
        msgBox.innerHTML = "Confirm password doesn't mutch password";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function confirmPhone() {
    var phone = document.getElementById("phone").value;
    var msgBox = document.getElementById("phoneMsg");

    var reg = /^0{1}(2|3|4|6|8|9|5[0|(2-8)]|73)-?[1-9]\d{6}$/;
    if (!reg.test(phone)) {
        msgBox.innerHTML = "Phone number is illegal";
        return false;
    }
    msgBox.innerHTML = "";
    return true;
}

function confirmemail() {
    var email = document.getElementById("email").value;
    var msgBox = document.getElementById("emailMsg");

    var reg = /^\w+/;
    if (!reg.test(email)) {
        msgBox.innerHTML = "email must start with letter or digit";
        return false;
    }
    msgBox.innerHTML = "";
    reg = /^\w+([\.-]?\w+)/;
    if (!reg.test(email)) {
        msgBox.innerHTML = "email can have only one [. or -] following letter";
        return false;
    }
    msgBox.innerHTML = "";
    reg = /^\w+([\.-]?\w+)*@/;
    if (!reg.test(email)) {
        msgBox.innerHTML = "email must have @";
        return false;
    }
    msgBox.innerHTML = "";
    reg = /^\w+([\.-]?\w+)*@\w+/;
    if (!reg.test(email)) {
        msgBox.innerHTML = "email must have letters after @";
        return false;
    }
    msgBox.innerHTML = "";

    reg = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/;
    if (!reg.test(email)) {
        msgBox.innerHTML = "Invalid email";
        return false;
    }

    msgBox.innerHTML = "";
    return true;
}
