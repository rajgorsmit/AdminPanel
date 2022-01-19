$( document ).ready(function() {
   	LogOutFunc();
});

function LogOutFunc() {
	$.ajax({
            type: 'GET',
            dataType: 'text',
            url: "Cust/LogOutFunc",
            data: null,
            success: function (returnPayload, retJson) {
				window.location = "/RegisterForm.aspx";				
			}
            });
}
