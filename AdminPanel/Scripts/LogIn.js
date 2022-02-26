function SubmitForm()
{
	
        var Email = $('#txtEmail').val();
		var Password = $('#PassInput').val();
			if (Email!=null || Pasword!=null){
				var CustDB=
				{
				 Email : Email,
				 Password : Password
				};
					 $.ajax({
						type: 'POST',
						dataType: 'text',
						url: "Cust/LogInFunc",
						contentType: "application/json; charset=utf-8",
						data: "JsonLog=" + JSON.stringify(CustDB),
						success: function (returnPayload) {
							console && console.log("request succeeded");
						},  
						error: function (xhr, ajaxOptions, thrownError) {
							console && console.log("request failed: " + String(thrownError));
						},
						processData: false,
						async: false
					});
			}
			else {
				alert('Please fill in all fields');
			}	
}
