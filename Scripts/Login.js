function tOver(i) {
    i.style.color = "white";
}
function tOut(i) {
    i.style.color = "";
}
function checkname() {
    document.getElementById("ckname").className = "";
    var name = document.getElementById("uname").value;
    var imgname = document.getElementById("imgname");
    if (name.length == 0) {
        imgname.src = "images/wrong_icon.png";
        document.getElementById("uname").style.borderColor ="red" ;
        return false;
    }
    else {
    document.getElementById("uname").style.borderColor ="" ;
        document.getElementById("ckname").className = "hide";
        return true;
    }
}
function checkpass() {
    document.getElementById("ckpass").className = "";
    var pass = document.getElementById("pass").value;
    var imgpass = document.getElementById("imgpass");
    var sppass = document.getElementById("sppass");

    if (pass.length == 0) {
        imgpass.src = "images/wrong_icon.png";
        document.getElementById("pass").style.borderColor ="red" ;
        return false;
    }
    else {
        document.getElementById("ckpass").className = "hide";
        document.getElementById("pass").style.borderColor ="" ;
        return true;
    }
}
function checkall() {
    if (checkname() && checkpass() ) {
        return true;
    }
    else {
        return false;
    }
}

function txtOver(i) {
    i.style.borderColor = "#0FF"; i.style.backgroundColor = "#FFFFC8"
}
function txtOut(i) {
    i.style.borderColor = "#999"; i.style.backgroundColor = "#FFF"
}
function suggest(sug) {
    switch (sug) {
        case 1: { document.getElementById("tipsname").className = "sugBlack"; break; }
        case 2: { document.getElementById("tipspass").className = "sugBlack"; break; }
        case 3: { document.getElementById("tipsrepass").className = "sugBlack"; break; }
        case 4: { document.getElementById("tipsquestion").className = "sugBlack"; break; }
        case 5: { document.getElementById("tipsanswer").className = "sugBlack"; break; }
        case 6: { document.getElementById("tipsemail").className = "sugBlack"; break; }
        case 7: { document.getElementById("regimg").className = "sugBlack"; break; }
        case 8: { document.getElementById("tipsideal").className = "sugBlack"; break; }
        case 9: { document.getElementById("tipsutype").className = "sugBlack"; break; }
    }
}
function sugback(sug) {
    switch (sug) {
        case 1: { document.getElementById("tipsname").className = "suggesttxt"; break; }
        case 2: { document.getElementById("tipspass").className = "suggesttxt"; break; }
        case 3: { document.getElementById("tipsrepass").className = "suggesttxt"; break; }
        case 4: { document.getElementById("tipsquestion").className = "suggesttxt"; break; }
        case 5: { document.getElementById("tipsanswer").className = "suggesttxt"; break; }
        case 6: { document.getElementById("tipsemail").className = "suggesttxt"; break; }
        case 7: { document.getElementById("regimg").className = "suggesttxt"; break; }
        case 8: { document.getElementById("tipsideal").className = "suggesttxt"; break; }
        case 9: { document.getElementById("tipsutype").className = "suggesttxt"; break; }
    }
}