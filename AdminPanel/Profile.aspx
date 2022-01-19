<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AdminPanel.Profile1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   <head>
        <link rel="stylesheet"href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" />
        <title></title>
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
        <script src="Scripts/GetDataForProfile.js"></script>
        <style>
            .table-item {
                margin:50px;
            }
        </style>
   </head>     
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainBody" runat="server">    
                    <h1 style="color:#4699ca">Profile</h1>                                        
                        <br /><br />
                <table class="table table-bordered" id="UserDetails">
                  <thead>
                    <tr>
                      <th style="width: 10px">#</th>
                      <th class="table-item">User-Name</th>
                      <th class="table-item">First Name</th>
                      <th class="table-item">Last Name</th>
                      <th class="table-item">Age</th>
                      <th class="table-item">Mobile Number</th>
                      <th class="table-item">Email</th>
                      <th class="table-item">City</th>
                      <th class="table-item">State</th>
                      <th class="table-item">Date</th>
                      <th class="table-item">Password</th>
                      <th class="table-item">Account Type</th>
                      <th class="table-item">Reported</th>
                      <th class="table-item">Is Active</th>
                    </tr>
                  </thead>                    
                </table>
                        <div style="margin-top:20px;">
                    <div class="btn-group" role="group" aria-label="Third group">                        
                        <button type="button" class="btn btn-secondary" style="border:none; background-color:#e13a3a; color:white;" onclick="DeleteUser()">Delete</button>
                    </div>
                    <div class="btn-group" role="group" aria-label="Third group">
                        <button type="button" class="btn btn-secondary" style="border:none; background-color:#4cff00; color:white;" onclick="EditUser()">Edit</button>
                    </div>
                    <div class="btn-group" role="group" aria-label="Third group">
                        <button type="button" class="btn btn-secondary" style="border:none; background-color:#ff6a00; color:white;" onclick="ReportUser()">Report</button>
                    </div>              
                  </div></div>
                </div>
            </div>             
</asp:Content>


