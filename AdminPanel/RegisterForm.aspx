<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="AdminPanel.RegisterForm" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <style>
        body {
            background: #a8c0ff; 
            background: -webkit-linear-gradient(to right, #3f2b96, #a8c0ff); 
            background: linear-gradient(to right, #3f2b96, #a8c0ff); 
        }
    </style>
<link rel="stylesheet" href=
"https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css" />
    <link rel="stylesheet" href=
"https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"
        integrity=
"sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"
        crossorigin="anonymous">    
<script src="../../plugins/jquery/jquery.min.js"></script>

<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<script src="Scripts/Register.js"></script>

<script src="../../dist/js/adminlte.min.js"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <title>AdminLTE 3 | Registration Page (v2)</title>
  
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback">
  
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css">

  <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css">

  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>
<body class="hold-transition">
    <form ruant="server" >
    <section class="content">
      <div class="container-fluid">
<div class="row" style="justify-content: center;">
          <!-- Left col -->
          <section class="col-lg-7 connectedSortable ui-sortable">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a href="../../index2.html" class="h1"><b>Admin</b>LTE</a>
    </div>
    <div class="card-body">
      <p class="login-box-msg">Register a new membership</p>

      <form runat="server" id="RegisterForm">
        <div class="input-group mb-3">
          <input type="text" class="form-control" id="txtFname" name="Fname" placeholder="First Name">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          <div class="input-group mb-3">
          <input type="text" class="form-control" id="txtLname" name="Lname" placeholder="Last Name">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          <div class="input-group mb-3">
            <input type="text" class="form-control" id="UNameInput" name="UserName" placeholder="User Name:">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          <div class="input-group mb-3">
            <input type="text" class="form-control" id="txtAge" name="Age" placeholder="Age">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>
          <div class="input-group mb-3">
          <input type="text" class="form-control" id="txtNum" name="Number" placeholder="Mobile Number">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div>  
          <div class="input-group mb-3">
          <input type="text" class="form-control" id="txtEmail" name="Email" placeholder="Email">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-user"></span>
            </div>
          </div>
        </div> 
          <div class="input-group mb3" style="margin-top:20px;">
                <select class="form-select" id="StateDDL" onchange="GetCity()" name="State" aria-label="Default select example">
                <option selected>Select State</option>
                </select>
          </div>
          <div class="input-group mb3" style="margin-top:20px;margin-bottom:20px;">
                <select class="form-select" id="CityDDL" name="City" aria-label="Default select example">
                <option selected>Select City</option>
                </select> 
          </div>
          <div class="input-group mb-3">
            <select class="form-select" id="AccTypeInput" aria-label="Default select example">
                 <option selected>Select Account Type</option>
            </select> 
            </div>  
        <div class="input-group mb-3">
          <input type="password" class="form-control" id="PassInput" placeholder="Password">
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <input type="password" class="form-control" placeholder="Retype password">
          <div class="input-group-append">      
            <i class="bi bi-eye-slash" 
                    id="togglePassword">
            </i>
          </div>
        </div>
        <div class="row">
          <div class="col-8">
            <div class="icheck-primary">
              <input type="checkbox" id="agreeTerms" name="terms" value="agree">
              <label for="agreeTerms">
               I agree to the <a href="#">terms</a>
              </label>
            </div>
          </div>
          <div class="SubmitButton" >
              <button onclick="SubmitForm()" class="btn btn-primary btn-lg btn-block">Register</button>
          </div>
        </div>
      </form>

      <a href="login.html" class="text-center">I already have a membership</a>
    </div>
  </div>
</section>
    </div>
          </div>
        </section>
<%--</div>--%>
</form>
</body>
</html>