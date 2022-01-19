$( document ).ready(function() {
    GetProfileData();
	console.log("Script Included");
});

function GetProfileData()
{	
 $.ajax({
	type: 'GET',
	dataType: 'text',
	url: "Cust/GetDataForProfile",
	data: null,
	success: function (returnPayload, retJson) {		
		if(retJson == "success"){
			var Datas = JSON.parse(returnPayload);
			var table = document.getElementById("UserDetails");
			var i=0;
			
			$("#UserDetails").append("<tbody>");
			for (i=0; i<=Datas.length; i++){
			  var tr = "<tr>";			 			 
				tr += "<td>=></td>";
				tr += "<td>"+ Datas[i].UName +"</td>";
				tr += "<td>"+ Datas[i].FirstName +"</td>";
				tr += "<td>"+ Datas[i].LastName +"</td>";
				tr += "<td>"+ Datas[i].Age +"</td>";
				
				tr += "<td>"+ Datas[i].Number +"</td>";
				tr += "<td>"+ Datas[i].Email+"</td>";
				tr += "<td>"+ Datas[i].City +"</td>";
				tr += "<td>"+ Datas[i].State +"</td>";
				
				tr += "<td>"+ Datas[i].Date +"</td>";
				tr += "<td>"+ Datas[i].Password +"</td>";
				tr += "<td>"+ Datas[i].AccountType +"</td>";
				tr += "<td>"+ Datas[i].Reported +"</td>";
				tr += "<td>"+ Datas[i].IsActive +"</td>";				
			  
				tr += "</tr>";
				$("#UserDetails").append(tr);
			}
			$("#UserDetails").append("</tbody>");
				
		}
	}
	}                
	)};

 
function DeleteUser(){
	$.ajax({
		type: 'GET',
		dataType: 'text',
		url: "Cust/DeleteUserProfile",
		data: null,
		success: function (returnPayload, retJson) {				
			window.location.href = "https://localhost:44371/RegisterForm.aspx";		
		}	
	})
	window.location.href = "https://localhost:44371/RegisterForm.aspx";		
}

function EditUser(){
	window.location.href = "https://localhost:44371/EditDetails.aspx";			
}

function ReportUser(){
	console.log("ReportUser");		
	$.ajax({
		type: 'GET',
		dataType: 'text',
		url: "Cust/ReportUser",
		data: null,
		success: function (returnPayload, retJson) {				
			window.location.href = "https://localhost:44371/profile.aspx";		
		}	
	})
}
