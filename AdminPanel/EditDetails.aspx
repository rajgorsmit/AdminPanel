<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="EditDetails.aspx.cs" Inherits="AdminPanel.Controllers.EditDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" runat="server">

<!DOCTYPE html>

<html lang="en">

<head>
    <style>
        body {
            background: linear-gradient(90deg, #d53369 0%, #daae51 100%);
        }        
    </style>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
  <title>AdminLTE 3 | Edit Details (v2)</title>

  <!-- Google Font: Source Sans Pro -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback" />
  <!-- Font Awesome -->
  <link rel="stylesheet" href="../../plugins/fontawesome-free/css/all.min.css" />
  <!-- icheck bootstrap -->
  <link rel="stylesheet" href="../../plugins/icheck-bootstrap/icheck-bootstrap.min.css" />
  <!-- Theme style -->
  <link rel="stylesheet" href="../../dist/css/adminlte.min.css">
</head>
<body class="hold-transition">
<%--<div class="register-box">--%>
    <section class="content">
      <div class="container-fluid">
<div class="row" style="justify-content: center;">
          <!-- Left col -->
          <section class="col-lg-7 connectedSortable ui-sortable">
  <div class="card card-outline card-primary">
    <div class="card-header text-center">
      <a href="../../index2.html" class="h1"><b>Admin LTE</b> - Edit Profile</a>
    </div>
    <div class="card-body">
      <form runat="server" id="RegisterForm" action="/Dashboard.aspx" >
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
          <input type="password" class="form-control" id="PassInput" placeholder="Password"/>
          <div class="input-group-append">
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>
        <div class="input-group mb-3">
          <input type="password" class="form-control" placeholder="Retype password" />
          <div class="input-group-append">      
            <div class="input-group-text">
              <span class="fas fa-lock"></span>
            </div>
          </div>
        </div>        
          <div class="SubmitButton" >
              <button onclick="EditDetails()" class="btn btn-primary btn-lg btn-block" accesskey="btn btn-primary btn-lg btn-block">Update Details</button>
          </div>
      </form>      
    </div>
  </div>
</section>
    </div>
          </div>
        </section>
<%--</div>--%>

<script src="../../plugins/jquery/jquery.min.js"></script>

<script src="../../plugins/bootstrap/js/bootstrap.bundle.min.js"></script>
<script src="Scripts/FillDataEditProfile.js"
<script src="../../dist/js/adminlte.min.js"></script>
<script src="Scripts/Register.js"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
</body>
</html>

</asp:Content>