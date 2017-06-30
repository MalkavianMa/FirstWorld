//序列操作部分的Js
function InputNull()
{
   if($(":input").val() == "")
      {
          alert("不能为空！");
      }
}


 
 

// //并列条件
// function AddBinglie(id){
//     type="<option value='开关'>开关</option><option value='刀闸'>刀闸</option><option value='手车'>手车</option><option value='母线'>母线</option>";
//         state="<option value='合位'>合位</option><option value='分位'>分位</option><option value='有电压'>有电压</option><option value='无电压'>无电压</option>";
//       var  html="<div class='yuanjian'>元件名称：<input type='text'  value=''/>  元件类型：<select >"+type+"</select>  元件状态：<select >"+state+"</select>&nbsp;&nbsp;&nbsp;<a href='#' onclick='RemoveCon(this)'>移除</a></div>"
//         $(id).parent().append(html);
// }
 //新建方案中，添加条件
 function AddCon(part){
      var binglieid=$("#binglieid").val();
      var type="";
      var state="";
      var html="";
      switch (part)
      {
         case 1:{
         type="<option value='开关'>开关</option><option value='刀闸'>刀闸</option><option value='手车'>手车</option><option value='母线'>母线</option>";
         state="<option value='合位'>合位</option><option value='分位'>分位</option><option value='有电压'>有电压</option><option value='无电压'>无电压</option>";
         break;
         }
         case 2:{
         type="<option value='开关'>开关</option><option value='刀闸'>主变高压侧刀闸</option><option value='主变高压侧开关'>主变高压侧开关</option><option value='主变中压侧开关'>主变中压侧开关</option><option value='主变低压侧开关'>主变低压侧开关</option>";
         state="<option value='有负荷'>有负荷</option><option value='无负荷'>无负荷</option>";
         break;
         }
         case 3:{
           html="<div class='yuanjian' >"
                    +"<div style='border: 1px solid #B4C9C6;width:780px;margin:0 auto; '><input style='width:60px' type='text' value=''/><select style='width:90px'><option value='主变$高压侧'>主变高压侧</option><option value='主变$中压侧'>主变中压侧</option><option value='主变$低压侧'>主变低压侧</option></select>电流<select><option>选择</option><option value='+'>+</option></select>"
                     +"<input style='width:60px'type='text' value=''/><select style='width:90px'><option value='主变$高压侧'>主变高压侧</option><option value='主变$中压侧'>主变中压侧</option><option value='主变$低压侧'>主变低压侧</option></select>电流<select><option>选择</option><option value='+'>+</option></select>"
                     +"<input style='width:60px'type='text' value=''/><select style='width:90px'><option value='主变$高压侧'>主变高压侧</option><option value='主变$中压侧'>主变中压侧</option><option value='主变$低压侧'>主变低压侧</option></select>电流<select style='display:none'><option>选择</option><option value='+'>+</option></select>"
                     +"<br /><b>小于</b><br /><input type='text' value=''/><select style='width:100px'><option value='主变$高压侧'>主变高压侧</option><option value='主变$中压侧'>主变中压侧</option><option value='主变$低压侧'>主变低压侧</option></select>额定电流(Amps)<select style='display:none'><option>选择</option><option value='+'>+</option></select>"
                     +"</div>&nbsp;&nbsp;&nbsp;<a href='#' onclick='RemoveCon(this)'>移除</a></div>";
                   $("#guozaidiv").append(html);
                   //$("#tempid").val(parseInt($("#tempid").val())+1); //每增加一个过载div，隐藏域+1
                   break;
         }
         case 4:{
             html="<select name='SelectOption' id='SelectOption'  onchange='Op(this)'><option value='1'>---请选择---</option><option value='1'>操作开关</option><option value='2'>检测主变档位</option></select>"
             $("#zhixingdiv").append(html);
         break;
         }
          case 5:{
         type="<option value='开关'>开关</option>";
         state="<option value='合位'>合位</option><option value='分位'>分位</option>";
         break;
         }
          case 6:{
             if($("#binglieid").val() == "0")
             {
              html="<div class='yuanjian' id="+binglieid+" style='border: 1px solid #B4C9C6;width:660px;margin:0 auto; '>"
              +"<input type='text'class='hide' value='!'/><select class='hide'><option value='!'>!</option></select><select class='hide'><option value='!'>!</option></select>"
             + "<div style='border: 1px solid #B4C9C6;width:640px;margin:0 auto; '><div id='addfuhe' class='buttonbinglie' onclick='AddBinglie(this)'></div></div>"
             +"<div><b>或</b><input type='text'class='hide' value='|'/><select class='hide'><option value='|'>|</option></select><select class='hide'><option value='|'>|</option></select></div>"
             + "<div style='border: 1px solid #B4C9C6;width:640px;margin:0 auto; '><div id='addfuhe' class='buttonbinglie' onclick='AddBinglie(this)'></div></div>"
             +"<div><b>或</b><input type='text'class='hide' value='|'/><select class='hide'><option value='|'>|</option></select><select class='hide'><option value='|'>|</option></select></div>"
             + "<div style='border: 1px solid #B4C9C6;width:640px;margin:0 auto; '><div id='addfuhe' class='buttonbinglie' onclick='AddBinglie(this)'></div></div>"
              +"<div><b>或</b><input type='text'class='hide' value='|'/><select class='hide'><option value='|'>|</option></select><select class='hide'><option value='|'>|</option></select></div>"
             + "<div style='border: 1px solid #B4C9C6;width:640px;margin:0 auto; '><div id='addfuhe' class='buttonbinglie' onclick='AddBinglie(this)'></div></div>"
             +"<input type='text'class='hide'  value='!'/><select class='hide'><option value='!'>!</option></select><select class='hide'><option value='!'>!</option></select>"
             +"<a href='#' onclick='RemoveConBinglie(this)'style='color:#6489bf'>移除该组并列条件</a></div>";
                   $("#chushidiv").append(html);
                   $("#binglieid").val(parseInt($("#binglieid").val())+1); //每增加一个过载div，隐藏域+1
             }
             else
             {
               alert("只能添加一组并列条件！");
             }
            
                   break;
         }
        
         
         
      }
      html="<div class='yuanjian'>元件名称：<input type='text'  value=''/>  元件类型：<select >"+type+"</select>  元件状态：<select >"+state+"</select>&nbsp;&nbsp;&nbsp;<a href='#' onclick='RemoveCon(this)'>移除</a></div>"
      switch (part)
      {
          case 1:
              {
                 
                  $("#chushidiv").append(html);
                  break;
              }
         case 2:{
         $("#fuhediv").append(html);
         break;
         }
         case 5:{
          $("#querendiv").append(html);
         break;
         }
      }
 }
 
 //移除当前div
function RemoveCon(id){
      id.parentNode.parentNode.removeChild(id.parentNode);
      //$("#tempid").val(parseInt($("#tempid").val())-1);
}

function RemoveConBinglie(id){
      id.parentNode.parentNode.removeChild(id.parentNode);
       $("#binglieid").val(parseInt($("#binglieid").val())-1);
      //$("#tempid").val(parseInt($("#tempid").val())-1);
}



 
 

  


