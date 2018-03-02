<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <p class="lead">Here, the below items are what I can do.</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Mobile Development</h2>
            <p>
                On Android, Windows Mobile and iOS, using Java, C# and Swift.
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Development</h2>
            <p>
                Java (JSP, Spring, Tomcat, JBoss, MySQL, PostgreSQL), ASP.NET (ASP, Razor, IIS, Microsoft SQL Server).
            </p>
            <p>
                <a class="btn btn-default" href="#">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>App Development</h2>
            <p>
                Java, C#, C++.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
