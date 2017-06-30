function InputNull()
{
   if($(":input").val() == "")
      {
          alert("不能为空！");
      }
}

function Goto(menu){
    switch(menu)
    {
       case 1:{window.location="MainFrame.aspx?menu=1";break;}
       case 2:{window.location="MainFrame.aspx?menu=2";break;}
       case 3:{window.location="MainFrame.aspx?menu=3";break;}
       case 4: { window.location = "MainFrame.aspx?menu=4"; break; }
    }
} 




//序列操作部分
function Check(part){
    switch(part)
    { 
    
      case 1 :{
         if($("#uname").val() == ""){
             $("#ckname").attr("class","");
             $("#imgname").attr("src","../images/wrong_icon.png");
             $("#spname").html("路径不能为空！");
             $("#uname").css("border-color","red");
              return false;
         }
         else{
             $("#imgname").attr("src","../images/right_icon.png");
             $("#spname").html("");
              $("#uname").css("border-color","");
             return true;
         }
         break;
      }
      case 2 :{
      if($("#pass").val() == ""){
             $("#ckpass").attr("class","");
             $("#imgpass").attr("src","../images/wrong_icon.png");
             $("#sppass").html("路径不能为空！");
             $("#pass").css("border-color","red");
              return false;
         }
         else
         {
             $("#imgpass").attr("src","../images/right_icon.png");
             $("#sppass").html("");
             $("#pass").css("border-color","");
             return true;
         }
      break;
      }
    }
}

function Checkpath(){
     if(Check(1) && Check(2))
     {
      $("#tmp").load("XL_Settings.aspx",{newxml:$("#pass").val()},function(data){
//             alert(data);
              if(data == "2")
              {
               $("#ckname").attr("class","");
                $("#ckpass").attr("class","");
                  $("#Span1").attr("class","");
               $("#imgname").attr("src","../images/right_icon.png");
               $("#imgpass").attr("src","../images/right_icon.png");
                  $("#img1").attr("src","../images/right_icon.png");
                  $("#Span2").html("保存成功！");
              }
              else if(data == "3")
              { 
                //$("#ckname").attr("class","");
                $("#ckpass").attr("class","");
                //$("#imgname").attr("src","../images/wrong_icon.png");
                //$("#spname").html("您设置的路径不存在！");
                //$("#uname").css("border-color","red");
                $("#imgpass").attr("src","../images/wrong_icon.png");
                $("#sppass").html("您设置的路径不存在！");
                $("#pass").css("border-color","red");
              }
//              else if(data.indexOf ("13") != -1)
//              {
//               $("#ckpass").attr("class","");
//                   $("#imgpass").attr("src","../images/wrong_icon.png");
//                   $("#sppass").html("您设置的路径不存在！");
//                   $("#pass").css("border-color","red");
//              }
//              else if(data.indexOf ("02") != -1)
//              {
//                  $("#ckname").attr("class","");
//                $("#imgname").attr("src","../images/wrong_icon.png");
//                $("#spname").html("您设置的路径不存在！");
//                $("#uname").css("border-color","red");
//  
//              }
              
       });
     }
}
