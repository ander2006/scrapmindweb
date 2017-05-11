<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Iframe.aspx.cs" Inherits="LoginWeb.Iframe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
            <script type="text/javascript">

function dihola()

{

    document.getElementById("nCedula").innerText = "1035417284";
}

</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        

       
    </div>
        
        
    </form>
</body>
</html>
