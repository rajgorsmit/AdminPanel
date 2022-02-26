$( document ).ready(function() {
	GetProfileData();
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
			var i=0;			
			$('#UNameInput').val(Datas[0].UName);
			$('#txtLname').val(Datas[0].LastName);
			$('#txtFname').val(Datas[0].FirstName);
			$('#txtAge').val(Datas[0].Age);
			
			$('#txtNum').val(Datas[0].Number);
			$('#txtEmail').val(Datas[0].Email);
			$('#CityDDL option:selected').val(Datas[0].City).change();
			$('#StateDDL option:selected').val(Datas[0].State).change(); 
							
			$('#PassInput').val(Datas[0].Password); 
			$('#AccTypeInput option:selected').val(Datas[0].AccountType).change(); 												
		}
	}
	}                
	)};
