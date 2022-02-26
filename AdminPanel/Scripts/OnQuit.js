$(document).ready(function() {
    SetUserName();
});

function SetUserName(){
$.ajax({
	type: 'GET',
	dataType: 'text',
	url: "Cust/GetDataForProfile",
	data: null,
	success: function (returnPayload, retJson) {		
		if(retJson == "success"){
			var Datas = JSON.parse(returnPayload);			
			var i=0;			
			$("span.admin_name").text(Datas[0].UName);			
		}
	}	               	
}	
);
}