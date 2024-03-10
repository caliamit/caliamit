<%@ Page Title="" Language="C#" MasterPageFile="~/pages/MasterPage.master" AutoEventWireup="true" CodeFile="Transform.aspx.cs" Inherits="pages_Transform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        body{

           background-image:none !important; 
            background-color:black !important;
            
           
        }
        .navbar{
            background-color:darkcyan !important;
            
        }
        .navbar a:hover, .dropdown:hover .dropbtn{
            color: rgba(138, 43, 226, 1) !important;            
        }
        .navbar a:active, .dropdown:active .dropbtn {
         color: rgba(138, 43, 226, 0.7) !important;            
        }



    </style>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="header" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="nav" Runat="Server">
</asp:Content>

<asp:Content ID="transform" ContentPlaceHolderID="main" Runat="Server">
    
    
        <div class="TRIMG">
        <div class="image-container">
            <img src="../images/Transform 1.jpg" />
            <h3>Mateusz Werner</h3>
            <p>I started working out after I saw Darek’s one year<br /> body transofmration video. Attached photos show<br /> my 1 year progress. Started when I was 16 years old <br />at 59kg and got to 68kg (172cm). Never could have<br /> accomplished it without the help of Caliathletics<br /> program.</p>
        </div>


        <div class="image-container">
            <img src="../Images/Transform 2.jpg" />
            <h3>Alessandro Carrozza</h3>
            <p>Thanks to Caliathletics for great and effective<br /> workout program. It keeps you motivated with<br /> constant new workout at each Level. This program <br />challanges yourself. I’ve been working with it for 6<br /> months and now I fell more athletic, full of energy,<br /> definitely much stronger and muscular. If you want to<br /> change your life, choose Caliathletics program!</p>
        </div>


        <div class="image-container">
            <img src="../Images/Transform 3.jpg" />
            <h3>Jake Bertram</h3>
            <p>
                I grew up with bad shoulders so I wasn’t really able to<br /> use weights. Because of that I decided to try<br /> calishtenics. My body reacted to calishetnics so much<br /> better than any weight routine I have done in a past.<br /> Thanks to Caliathletics workout program I lost over<br /> 25 lbs and I’m working on building my skills now.
            </p>
        </div>

    </div>

  

</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="footer" Runat="Server">
</asp:Content>

