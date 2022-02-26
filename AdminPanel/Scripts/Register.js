$( document ).ready(function() {
    BindStates();
    GetAccTypes();
    $('#CityDDL').empty();
    $("#CityDDL").append('<option selected="selected" value="0" >Select City</option>');
});

function BindStates(){
        $.ajax({
            type: 'GET',
            dataType: 'text',
            url: "Cust/GetDataForStateDD",
            data: null,
            success: function (returnPayload, retJson) {
                if(retJson == "success")
                {
                    var Datas = JSON.parse(returnPayload);
                    //var x = document.getElementById('StateDDL');
                    $('#StateDDL').empty();
                    $("#StateDDL").append('<option selected="selected" value="0" >Select State</option>');
                    for (i=0; i<=Datas.length; i++) {
                        $("#StateDDL").append($('<option />').val(Datas[i].id).text(Datas[i].StateName));                        
                    }
                }
            }                
            });
}

function GetAccTypes(){
        $.ajax({
            type: 'GET',
            dataType: 'text',
            url: "Cust/GetAccTypes",
            data: null,
            success: function (returnPayload, retJson) {
                if(retJson == "success")
                {
                    var Datas = JSON.parse(returnPayload);
                    //var x = document.getElementById("#AccTypeInput');
                    $('#AccTypeInput').empty();
                    for (i=0; i<=Datas.length; i++) {
			if (Datas[i].AccType == "User") { $("#AccTypeInput").append($('<option selected/>').val(Datas[i].id).text(Datas[i].AccType));}
			else {
                        $("#AccTypeInput").append($('<option />').val(Datas[i].id).text(Datas[i].AccType)); }
                    }
                }
            }                
            });
}

function GetCity(){	
			 $.ajax({
                type: 'POST',
                dataType: 'text',
                url: "Cust/GetCity",
                data: "StateId=" + $('#StateDDL').val(),
                success: function (returnPayload, retJson) {
                    if (retJson=="success"){ 
						var Datas = JSON.parse(returnPayload);
						var CityDDLVar = document.getElementById('CityDDL');
						$('#CityDDL').empty(); // <<<<<< No more issue here
						$("#CityDDL").append('<option selected="selected" value="0" >Select City</option>');
							for (i=0; i<=Datas.length; i++) {
							$("#CityDDL").append("<option selected='selected' value=" + Datas[i].Id + "> " + Datas[i].CityName + "</option>");
						}
				}
				},
				
                error: function (xhr, ajaxOptions, thrownError) {
                    console && console.log("request failed");
                },
            });        
}

function SubmitForm()
{     		
        var Fname = $('#txtFname').val();
        var Lname = $('#txtLname').val();
        var Age = $('#txtAge').val();
        var Number = $('#txtNum').val();
        var Email = $('#txtEmail').val();
        var Password =$('#PassInput').val();
        var AccType = $('#AccTypeInput option:selected').text();
        var UName = $('#UNameInput').val();
        var City = $('#CityDDL option:selected').text();
        var State = $('#StateDDL option:selected').text();
			if (Fname!=null || Lname!=null || Age!=null || Number!=null || City!=null || AccType!=null || State!=null || Email!=null || Pasword!=null){
				var CustDB=
				{
				Fname: Fname,
				Lname: Lname,
				Age: Age,
				Number: Number,
				Email: Email,
				Password: Password,
				AccType: AccType,
				City: City,
				State: State,
				UName: UName
				};
					 $.ajax({
						type: 'POST',
						dataType: 'text',
						url: "Cust/InsertCustReg",
						data: "JsonLog=" + JSON.stringify(CustDB),
						success: function (returnPayload) {
							window.location.href = "~/Dashboard.aspx";
						},  
						processData: false,
						async: false
					});        
			}			
			else {
				alert('Please fill in all fields');
			}	
}


function EditDetails()
{
        var formEl = document.forms.RegisterForm;
        var formData = new FormData(formEl);
	
        var Fname = $('#txtFname').val();
        var Lname = $('#txtLname').val();
        var Age = $('#txtAge').val();
        var Number = $('#txtNum').val();
        var Email = $('#txtEmail').val();
        var Password =$('#PassInput').val();
        var AccType = $('#AccTypeInput option:selected').text();
        var UName = $('#UNameInput').val();
        var City = $('#CityDDL option:selected').text();
        var State = $('#StateDDL option:selected').text();

 	    var CustDB=
        {
        Fname: Fname,
        Lname: Lname,
        Age: Age,
        Number: Number,
        Email: Email,
        Password: Password,
        AccType: AccType,
        City: City,
        State: State,
		UName: UName
        };
             $.ajax({
                type: 'POST',
                dataType: 'text',
                url: "Cust/UpdateUser",
                data: "JsonLog=" + JSON.stringify(CustDB),
                success: function (returnPayload) {
					console.log('Success');					
                },  
                processData: false,
                async: false
            });        
}