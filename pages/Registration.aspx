<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage.master" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="pages_registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" type="text/css" href="../stylesheets/StyleSheet2.css" /> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="nav" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="main" Runat="Server">

       <form action="Registration.aspx" method="post">
          
               <div class="registration-txt-box">
                    <h2 id="sign-up-welcome">Let's get you started!</h2>
               <div class="backg">
        <label for="firstName"></label><br />
        <input type="text" id="firstName" name="firstName" placeholder="First name" /><br />

        <label for="lastName"></label><br />
        <input type="text" id="lastName" name="lastName" placeholder="Last name" /><br />

        <label for="userName"></label><br />
        <input type="text" id="userName" name="userName" placeholder="Username" /><br />

        <label for="pswd"></label><br />
        <input type="Password" id="pswd" name="pswd" placeholder="Password" /><br />

        <label for="pswdValidate"></label><br />
        <input type="Password" id="pswdValidate" name="pswdValidate" placeholder="Password verification" /><br />

        <label for="idNum"></label><br />
        <input type="text" id="idNum" name="idNum" placeholder="ID" /><br />

        <label for="phone"></label><br />
        <input type="text" id="phone" name="phone" placeholder="Phone number" /><br />

        <label for="mail"></label><br />
        <input type="text" id="mail" name="mail" placeholder="Mail"  />

                   <div class="have-acc">
        <p>Already have an account?  <a href="Login.aspx"> Login Here</a> </p> 
                       </div>

               </div>
                   <div class="reg-checkbox">
                       <p id="gender" name="gender">Gender:</p> 
                       <div class="select-gender">

                       <select>       
        <option value="Choose" >Choose</option>
        <option value="Male">Male</option>
        <option value ="Female" >Female</option>
     </select>
</div>
                       <div class="approval">
        <label  for="approval">I approve the regulations:</label><br />
        <input type="checkbox" id="approval" name="approval"  />
        <br />
                           </div>

                       <div class="submit-btn">
        <input type="submit" id="submitREG" name="submit" />
                           </div>
                       <div class="reset-btn">
        <input type="reset" id="reset" name="reset" />
                           </div>

               </div>
                   </div>
           
    </form>
    <div class="errorMsg"><%Response.Write(data); %></div>


</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

