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
        case 6: { document.getElementById("tipsemail").className = "sugBlack"; break; }
        case 7: { document.getElementById("usernametip").className = "sugBlack"; break; }


    }
}
function sugback(sug) {
    switch (sug) {
        case 1: { document.getElementById("tipsname").className = "suggesttxt"; break; }
        case 2: { document.getElementById("tipspass").className = "suggesttxt"; break; }
        case 3: { document.getElementById("tipsrepass").className = "suggesttxt"; break; }
        case 6: { document.getElementById("tipsemail").className = "suggesttxt"; break; }
        case 7: { document.getElementById("usernametip").className = "suggesttxt"; break; }

    }
}

function tOver(i) {
    i.style.color = "white";
}
function tOut(i) {
    i.style.color = "";
}
