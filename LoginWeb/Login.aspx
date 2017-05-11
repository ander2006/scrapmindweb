<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginWeb.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/style.css">
    <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'>
</head>
<body>
  
<link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css'>


<div class="login">
  
<h2 class="active"> Iniciar Sesión </h2>


  
<form runat="server">
    
   
    


  <asp:TextBox ID="txtuser" CssClass="text" runat="server"></asp:TextBox>   
<span>usuario</span>

    
<br>
    
    
<br>

    

    <asp:TextBox ID="txtcontrasena" TextMode="Password" CssClass="text" runat="server"></asp:TextBox>
<span>contraseña</span>
<br>

    

   <asp:CheckBox ID="CheckBox1" runat="server" />
 <label>No cerrar sesión</label>
    
   
 
<asp:Button ID="Button1" runat="server" CssClass="signin"  Text="Iniciar Sesión" Height="50px" Width="402px" OnClick="Button1_Click" />

    
<hr/>

    
<a href="#">¿Olvido su contraseña?</a>
  </form>

      

</div>
 
    <p>

    
    </p>
 
</body>
</html>
