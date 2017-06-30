function checkuserName(){
       document.getElementById("ckname").className = "";
    var uname = document.getElementById("uname").value;
    var image = document.getElementById("imgname");
    if (uname.length == 0) {
        image.src = "images/wrong_icon.png";
        document.getElementById("spname").innerHTML = "请输入用户名！";
        return false;
    }
//    if (uname.length < 6 || pass.length > 20) {
//        image.src = "images/wrong_icon.png";
//        document.getElementById("spname").innerHTML = "用户名长度不正确！";
//        return false;
//    }
   var patrn=/^(\w){6,20}$/;   
   if (!patrn.exec(uname)) {
   image.src = "images/wrong_icon.png";
   document.getElementById("spname").innerHTML = "用户名格式不正确！";
   return false;
   }

         //ajax判断用户名是否存在
          var xmlHttpname;
          sendname();
          return true;

}
function sendname() {
    if (window.ActiveXObject)//IE
    {
        xmlHttpname = new ActiveXObject("Microsoft.XMLHTTP");
    }
    else if (window.XMLHttpRequest)//非IE
    {
        xmlHttpname = new XMLHttpRequest();
    }
    var url = "CheckUser.ashx";
    xmlHttpname.onreadystatechange = onResult1;
    var nname = document.getElementById("uname").value;
    xmlHttpname.open("post", url, true);
    xmlHttpname.setRequestHeader("Content-Type", "application/x-www-form-urlencoded;");
    xmlHttpname.send("uname=" + nname);
}
function onResult1() {
    if (xmlHttpname.readyState == 4) {
        if (xmlHttpname.status == 200) {
            var nameget = xmlHttpname.responseText;
            //            alert(nameget);
            if (nameget == "exist") {
                document.getElementById("imgname").src = "images/wrong_icon.png";
                document.getElementById("spname").innerHTML = "该用户名已存在！";
               // return false;
            }
            else {
                document.getElementById("imgname").src = "images/right_icon.png";
                document.getElementById("spname").innerHTML = "";
               // return true;
            }
        }
    }
}

function checkRealName() {
    document.getElementById("ckusername").className = "";
    var uname = document.getElementById("username").value;
    var image = document.getElementById("imgusername");
    var ischi = true;
    for (var i = 0; i < uname.length; i++) {
        ischi = ischi && (uname.charCodeAt(i) >= 10000);
    }
    if (ischi == false) {
        image.src = "images/wrong_icon.png";
        document.getElementById("spusername").innerHTML = "请输入汉字！";
        return false;
    }
    else {
        if (uname.length < 2) {
            if (uname.length == 0) {
                image.src = "images/wrong_icon.png";
                document.getElementById("spusername").innerHTML = "请输入您的姓名！";
                return false;
            }
            else {
                image.src = "images/wrong_icon.png";
                document.getElementById("spusername").innerHTML = "请输入真实姓名！";
                return false;
            }
        }
        else {

            var checkname = "赵钱孙李周吴郑王冯陈褚卫蒋沈韩杨朱秦尤许何吕施张孔曹严华金魏陶姜戚谢邹喻柏水窦章云苏潘葛奚范彭郎鲁韦昌马苗凤花方俞任袁柳酆鲍史唐费廉岑薛雷贺倪汤滕殷罗毕郝邬安常乐于时傅皮卞齐康伍余元卜顾孟平黄和穆萧尹姚邵堪汪祁毛禹狄米贝明臧计伏成戴谈宋茅庞熊纪舒屈项祝董粱杜阮蓝闵席季麻强贾路娄危江童颜郭梅盛林刁钟徐邱骆高夏蔡田樊胡凌霍虞万支柯咎管卢莫经房裘缪干解应宗宣丁贲邓郁单杭洪包诸左石崔吉钮龚程嵇邢滑裴陆荣翁荀羊於惠甄魏加封芮羿储靳汲邴糜松井段富巫乌焦巴弓牧隗山谷车侯宓蓬全郗班仰秋仲伊宫宁仇栾暴甘钭厉戎祖武符刘姜詹束龙叶幸司韶郜黎蓟薄印宿白怀蒲台从鄂索咸籍赖卓蔺屠蒙池乔阴郁胥能苍双闻莘党翟谭贡劳逄姬申扶堵冉宰郦雍郤璩桑桂濮牛寿通边扈燕冀郏浦尚农温别庄晏柴瞿阎充慕连茹习宦艾鱼容向古易慎戈廖庚终暨居衡步都耿满弘匡国文寇广禄阙东殴殳沃利蔚越夔隆师巩厍聂晁勾敖融冷訾辛阚那简饶空曾毋沙乜养鞠须丰巢关蒯相查后荆红游竺权逯盖益桓公万俟司马上官欧阳夏侯诸葛闻人东方赫连皇甫尉迟公羊澹台公冶宗政濮阳淳于仲孙太叔申屠公孙乐正轩辕令狐钟离闾丘长孙慕容鲜于宇文司徒司空亓官司寇仉督子车颛孙端木巫马公西漆雕乐正壤驷公良拓拔夹谷宰父谷粱晋楚闫法汝鄢涂钦段干百里东郭南门呼延妫海羊舌微生岳帅缑亢况後有琴梁丘左丘东门西门商牟佘佴伯赏南宫墨哈谯笪年爱阳佟第五言福百家姓续";
            var sin; var dou;
            if (uname.length > 3) {
                dou = uname.substring(0, 2);
                if (checkname.indexOf(dou) == -1) {
                    image.src = "images/wrong_icon.png";
                    document.getElementById("spusername").innerHTML = "请输入真实姓名！";
                    return false;
                }
            }
            else {
                sin = uname.substring(0, 1);
                if (checkname.indexOf(sin) == -1) {
                    image.src = "images/wrong_icon.png";
                    document.getElementById("spusername").innerHTML = "请输入真实姓名！";
                    return false;
                }
            }

        }

    }
    image.src = "images/right_icon.png";
    document.getElementById("spusername").innerHTML = "";
    return true;

}


function checkpass() {
    document.getElementById("ckpass").className = "";
    var pass = document.getElementById("pass").value;
    var imgpass = document.getElementById("imgpass");
    if (pass.length == 0) {
        imgpass.src = "images/wrong_icon.png";
        document.getElementById("sppass").innerHTML = "请输入密码！";
        return false;
    }
    if (pass.length < 6 || pass.length > 16) {
        imgpass.src = "images/wrong_icon.png";
        document.getElementById("sppass").innerHTML = "密码格式不正确！";
        return false;
    }
    imgpass.src = "images/right_icon.png";
    document.getElementById("sppass").innerHTML = "";
    return true;
}
function checkrepass() {
    document.getElementById("ckrepass").className = "";
    var pass = document.getElementById("pass").value;
    var repass = document.getElementById("rpass").value;
    var imgrepass = document.getElementById("imgrepass");
    if (repass.length == 0) {
        imgrepass.src = "images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "输入确认密码！";
        return false;
    }
    if (repass.length < 6 || repass.length > 16) {

        imgrepass.src = "images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "位数不正确！";
        return false;
    }
    if (repass != pass) {
        imgrepass.src = "images/wrong_icon.png";
        document.getElementById("sprepass").innerHTML = "两次密码不一致！";
        return false;
    }

    imgrepass.src = "images/right_icon.png";
    document.getElementById("sprepass").innerHTML = "";
    return true;
}
function checkemail() {
    document.getElementById("ckemail").className = "";
    var email = document.getElementById("emai").value;
    var imgemail = document.getElementById("imgemail");
    var spemail = document.getElementById("spemail");
    var val = /^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$/;
    if (!val.exec(email)) {
        imgemail.src = "images/wrong_icon.png";
        spemail.innerHTML = "邮箱格式不正确！";
        return false;
    }
    imgemail.src = "images/right_icon.png";
    spemail.innerHTML = "";
    return true;
} 

function checkchbox() {
    document.getElementById("ckbox").className = "";
    var box = document.getElementById("agree");
    if (box.checked == false) {
        document.getElementById("imgbox").src = "images/wrong_icon.png";
        return false;
    }
    else {
        document.getElementById("ckbox").className = "hide";
        return true;
    }
}
function tOver(i) {
    i.style.color = "white";
}
function tOut(i) {
    i.style.color = "";
}
function checkall() {
    if (checkuserName() && checkRealName() && checkpass() && checkrepass()  && checkemail()  && checkchbox()) {
            var isexists=document.getElementById("spname").innerHTML;
            if(isexists!="")
            {
                return false;
            }
            else
            {
            return true;
            }
          
    }
    else {
        return false;
    }
}



     function checkuserName() {
     alert( $("#uname").val());
     if ( $("#uname").val() == "") {
       document.getElementById("ckname").className = "";
    var uname = document.getElementById("uname").value;
    var image = document.getElementById("imgname");
    if (uname.length == 0) {
        image.src = "../images/wrong_icon.png";
        document.getElementById("spname").innerHTML = "请输入原始密码！";
        return false;
     }
     }
     else {
     
         $("#code2").load("Selfinfo.aspx", { uname: $("#uname").val() }, function(data) {
             if (data == "0") {
                 document.getElementById("ckname").className = "";
                 var uname = document.getElementById("uname").value;
                 var image = document.getElementById("imgname");
                 if (uname.length == 0) {
                     image.src = "../images/wrong_icon.png";
                     document.getElementById("spname").innerHTML = "原始密码错误！";
                     return false;
                 }
             }
             else if (data == "1") {
                 document.getElementById("imgname").src = "../images/right_icon.png";
                 document.getElementById("spname").innerHTML = "";
             }
         });
     }

     }
