function SubmitForm()
{
        var formEl = document.forms.form1;
        var formData = new FormData(formEl);
        var CustDB=
        {
        Email: formData.get('email'),
        Password: formData.get('password')
        };
             $.ajax({
                type: 'POST',
                dataType: 'text',
                url: "Cust/LogInFunc",
                data: "JsonLog=" + JSON.stringify(CustDB),
                success: function (returnPayload) {
                    console && console.log("request succeeded");
                },  
                error: function (xhr, ajaxOptions, thrownError) {
                    console && console.log("request failed");
                },
            });        
}
