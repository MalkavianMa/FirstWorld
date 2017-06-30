function checkpass() {
    document.getElementById("ckpass").className = "";
    var pass = document.getElementById("pass").value;
    var imgpass = document.getElementById("imgpass");
    if (pass.length == 0) {
        imgpass.src = "../images/wrong_icon.png";
        document.getElementById("sppass").innerHTML = "请输入新密码！";
        return false;
    }
    if (pass.length < 6 || pass.length > 16) {
        imgpass.src = "../images/wrong_icon.png";
        document.getElementById("sppass").innerHTML = "密码格式不正确！";
        return false;
    }
    imgpass.src = "../images/right_icon.png";
    document.getElementById("sppass").innerHTML = "";
    return true;
}
function checkrepass() {
    document.getElementById("ckrepass").className = "";
    var pass = document.getElementById("pass").value;
    var repass = document.getElementById("rpass").value;
    var imgrepass = document.getElementById("imgrepass");
    if (repass.length == 0) {
        imgrepass.src = "../images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "输入确认密码！";
        return false;
    }
    if (repass.length < 6 || repass.length > 16) {

        imgrepass.src = "../images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "位数不正确！";
        return false;
    }
    if (repass != pass) {
        imgrepass.src = "../images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "两次密码不一致！";
        return false;
    }

    imgrepass.src = "../images/right_icon.png";
    document.getElementById("sprepass").innerHTML = "";
    return true;
}
function tOver(i) {
    i.style.color = "white";
}
function tOut(i) {
    i.style.color = "";
}
function checkall() {
    if (checkuserName() && checkRealName() && checkpass() && checkrepass() && checkemail() && checkchbox()) {
        var isexists = document.getElementById("spname").innerHTML;
        if (isexists != "") {
            return false;
        }
        else {
            return true;
        }

    }
    else {
        return false;
    }
}


