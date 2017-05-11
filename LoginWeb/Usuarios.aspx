<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="LoginWeb.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/bootstrap.css" rel="stylesheet" />
    <script src="https://code.jquery.com/jquery.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/npm.js"></script>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="margin-left:20%; color: #09C;">
        <!-- Inicio de ventana modal -->

        <input type="button" value="Registrar" class="btn btn-info" data-toggle="modal" data-target="#miventana"/>

        <div class="modal fade" id="miventana" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            <div class="modal-dialog">
               <div class="modal-content">
                   <div class="modal-header">
                       Registrar   
                   </div>
                   <div class="modal-body">
                <asp:Label ID="Usuario" runat="server" Text="Usuario"></asp:Label>
                <asp:TextBox ID="txtUsuario" CssClass="form-control" runat="server"></asp:TextBox> <br />
                <asp:Label ID="Cedula" runat="server" Text="Cedula"></asp:Label>
                <asp:TextBox ID="txtCedula" CssClass="form-control" runat="server"></asp:TextBox> <br />
                <asp:Label ID="Contraseña" runat="server" Text="Contraseña"></asp:Label>
                <asp:TextBox ID="txtContrasena" CssClass="form-control" runat="server"></asp:TextBox><br />
                <asp:Label ID="Administrador" runat="server" Text="Administrador"></asp:Label>
                <asp:RadioButton ID="RadioAdministrador" runat="server" />
                <asp:Label ID="Operativo" runat="server" Text="Operativo"></asp:Label>
                <asp:RadioButton ID="Radiooperativo" runat="server" /><br />
           
                   </div>
                   <div class="modal-footer">
                       <input type="button" value="Cerrar"  class="btn btn-primary" data-dismiss="modal"/>
                        <asp:Button ID="btnRegistrar" class="btn btn-success"  runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                   </div>
               </div>
            </div> 



        </div>
     
       <br /> 
        <br />
 
    

     <asp:GridView AutoGenerateColumns="False" CssClass="table table-bordered bs-table" Width="50%" ID="gvusuarios" runat="server" AllowPaging="True" DataKeyNames="codigo" DataSourceID="SqlDataSource1" >
        <Columns>
            <asp:BoundField DataField="cedula"
                HeaderText="Cédula" SortExpression="cedula" />
            <asp:BoundField DataField="usuario"
                HeaderText="Usuario" SortExpression="usuario" />
            <asp:BoundField DataField="contrasena"
                HeaderText="Contraseña" SortExpression="contrasena" />
            <asp:BoundField DataField="administrador"
                HeaderText="Administrador" SortExpression="administrador" />
            <asp:BoundField DataField="operativo"
                HeaderText="Operativo" SortExpression="operativo" />
            
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" HeaderText="Acciones" ButtonType="Button" >
            
            <ControlStyle ForeColor="White" BackColor="#5BC0DE" BorderColor="White" CssClass="btn btn-info" />
            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="75%" Wrap="False" />
            </asp:CommandField>
            
        </Columns >
        
         <EditRowStyle  BorderStyle="Solid" BorderWidth="5px" HorizontalAlign="Center" Width="5px" Wrap="True" />
        
    </asp:GridView >

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:ScrappmindConnectionString %>" DeleteCommand="DELETE FROM [tbl_persona] WHERE [codigo] = @original_codigo AND (([cedula] = @original_cedula) OR ([cedula] IS NULL AND @original_cedula IS NULL)) AND (([usuario] = @original_usuario) OR ([usuario] IS NULL AND @original_usuario IS NULL)) AND (([contrasena] = @original_contrasena) OR ([contrasena] IS NULL AND @original_contrasena IS NULL)) AND (([administrador] = @original_administrador) OR ([administrador] IS NULL AND @original_administrador IS NULL)) AND (([operativo] = @original_operativo) OR ([operativo] IS NULL AND @original_operativo IS NULL))" InsertCommand="INSERT INTO [tbl_persona] ([cedula], [usuario], [contrasena], [administrador], [operativo]) VALUES (@cedula, @usuario, @contrasena, @administrador, @operativo)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT [cedula], [usuario], [contrasena], [administrador], [operativo], [codigo] FROM [tbl_persona]" UpdateCommand="UPDATE [tbl_persona] SET [cedula] = @cedula, [usuario] = @usuario, [contrasena] = @contrasena, [administrador] = @administrador, [operativo] = @operativo WHERE [codigo] = @original_codigo AND (([cedula] = @original_cedula) OR ([cedula] IS NULL AND @original_cedula IS NULL)) AND (([usuario] = @original_usuario) OR ([usuario] IS NULL AND @original_usuario IS NULL)) AND (([contrasena] = @original_contrasena) OR ([contrasena] IS NULL AND @original_contrasena IS NULL)) AND (([administrador] = @original_administrador) OR ([administrador] IS NULL AND @original_administrador IS NULL)) AND (([operativo] = @original_operativo) OR ([operativo] IS NULL AND @original_operativo IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_codigo" Type="Int32" />
                <asp:Parameter Name="original_cedula" Type="Int32" />
                <asp:Parameter Name="original_usuario" Type="String" />
                <asp:Parameter Name="original_contrasena" Type="String" />
                <asp:Parameter Name="original_administrador" Type="Int32" />
                <asp:Parameter Name="original_operativo" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="cedula" Type="Int32" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="contrasena" Type="String" />
                <asp:Parameter Name="administrador" Type="Int32" />
                <asp:Parameter Name="operativo" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="cedula" Type="Int32" />
                <asp:Parameter Name="usuario" Type="String" />
                <asp:Parameter Name="contrasena" Type="String" />
                <asp:Parameter Name="administrador" Type="Int32" />
                <asp:Parameter Name="operativo" Type="Int32" />
                <asp:Parameter Name="original_codigo" Type="Int32" />
                <asp:Parameter Name="original_cedula" Type="Int32" />
                <asp:Parameter Name="original_usuario" Type="String" />
                <asp:Parameter Name="original_contrasena" Type="String" />
                <asp:Parameter Name="original_administrador" Type="Int32" />
                <asp:Parameter Name="original_operativo" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>

    </div>
    
   
</asp:Content>
