//拉路控制部分js
function checkround() {
      $("#code1").load("LL_NewTable.aspx",{round:$("tr").find("[name='round']").val()},function(data){
             if (data == "nook") {
             alert("该轮号已存在，请检查后填写！");
             return false;
             }
             else{
             return true;
             }
      });
}



