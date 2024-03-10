<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="pages_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style>
        body{
              background-image: url("../images/login.jpg") !important;
              height: 100vh;
              background-size: cover;
              background-position: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="nav" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="main" Runat="Server">
  
    
    <form method="post" action="Login.aspx">
        

        <div class="signIn">
            <div class="background">
                <div class="txt-box-login">
                    <h2 id="signin-opening">Let's sign you in!</h2>

        <label for="userName" ></label><br/> 
        <input type="text" id="userName" name="userName" placeholder="Username" /><br />

        <label for="passwd"></label><br />
        <input type="password" id="passwd" name="passwd" placeholder="Password" /><br />
                   


 <div class="rememberMe">
     
     <div class="checkbox">
<label for="" ><input type="checkbox" id="rememberMe" />Remember Me</label>
         </div>
</div>

                    
        <input type="submit" id="submit" name="submit"/> <br /> <br />
                    <br />
            <p id="register">Don't have an account yet? <br /> <a href="Registration.aspx">Register Here!</a> </p>


                 
</div>
        </div>
            </div>
    </form>
    
<div class="errorMsg"><%Response.Write(msg); %></div>








</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

