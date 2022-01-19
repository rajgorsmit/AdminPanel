<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="AdminPanel.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
    <h1 style="color:cadetblue">All Users</h1> <hr /><br /><br />
        <center>
        
        <asp:GridView runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="MainDataSource" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
            <asp:BoundField DataField="AccountType" HeaderText="AccountType" SortExpression="AccountType" />
            <asp:BoundField DataField="Number" HeaderText="Number" SortExpression="Number" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="UName" HeaderText="UName" SortExpression="UName" />
            <asp:BoundField DataField="Reported" HeaderText="Reported" SortExpression="Reported" />
        </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>

    <h1 style="color:cadetblue">Reported Users</h1> <hr /><br /><br />
    
    <asp:GridView runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="ReportedUsersSrc" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
            <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
            <asp:BoundField DataField="AccountType" HeaderText="AccountType" SortExpression="AccountType" />
            <asp:BoundField DataField="Number" HeaderText="Number" SortExpression="Number" />
            <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
            <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
            <asp:BoundField DataField="Date" HeaderText="Date" SortExpression="Date" />
            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            <asp:BoundField DataField="UName" HeaderText="UName" SortExpression="UName" />
            <asp:BoundField DataField="Reported" HeaderText="Reported" SortExpression="Reported" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>

        <asp:SqlDataSource ID="ReportedUsersSrc" runat="server" ConnectionString="<%$ ConnectionStrings:C:\USERS\MR\SOURCE\REPOS\ADMINWEB\ADMINWEB\APP_DATA\MAINDATA.MDFConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>

    <asp:SqlDataSource ID="MainDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:C:\USERS\MR\SOURCE\REPOS\ADMINWEB\ADMINWEB\APP_DATA\MAINDATA.MDFConnectionString %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
</center>
</form>
</asp:Content>


