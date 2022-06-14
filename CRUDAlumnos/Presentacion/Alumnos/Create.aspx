<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Presentacion.Alumnos.Create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="form-horizontal">
        <h2>Agregar alumno</h2>
        <hr />

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre" CssClass="alert-danger" ErrorMessage="El nombre es necesario"></asp:RequiredFieldValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtNombre" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvPApellido" runat="server" ControlToValidate="txtPa" CssClass="bg-danger" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtPa" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvSApellido" runat="server" ControlToValidate="txtSp" CssClass="btn-danger" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtSp" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvFecha" runat="server" ControlToValidate="txtFn" CssClass="btn-danger focus" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ClientValidationFunction="CurpValidar" ErrorMessage="La fecha de nacimiento no coincide con el CURP" CssClass="alert-danger" ControlToValidate="txtFn" ></asp:CustomValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtFn" runat="server" type="DateTime" TextMode="Date"></asp:TextBox>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFn" CssClass="bg-danger" ErrorMessage="La fecha debe estar entre 31-12-1990 y 01-01-2000" MaximumValue="01-01-2000" MinimumValue="31-12-1990" Type="Date"></asp:RangeValidator>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label6" runat="server" Text="Curp"></asp:Label>
            <asp:RequiredFieldValidator ID="rfvCurp" runat="server" ControlToValidate="txtCurp" CssClass="alert-danger" ErrorMessage="El campo es obligatorio"></asp:RequiredFieldValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtCurp" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="evCurp" runat="server" ControlToValidate="txtCurp" CssClass="alert-danger" ErrorMessage="El formato del curp es incorrecto" ValidationExpression="^[A-Z]{4}[0-9]{6}[A-Z]{6}[0-9]{2}"></asp:RegularExpressionValidator>
            </div>
        </div>


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label7" runat="server" Text="Correo"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label8" runat="server" Text="Telefono"></asp:Label>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtTelefono" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label9" runat="server" Text="Sueldo"></asp:Label>
            <asp:RangeValidator ID="rgvSueldo" runat="server" ControlToValidate="txtSueldo" CssClass="alert-warning" ErrorMessage="El sueldo debe de ser de 10,000 a 40,000" MaximumValue="40000" MinimumValue="10000" Type="Double"></asp:RangeValidator>
            <div class="col-md-2">
                <asp:TextBox Class="form-control text-box single-line" ID="txtSueldo" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSueldo" ErrorMessage="Sueldo"></asp:RequiredFieldValidator>
            </div>
        </div>


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label10" runat="server" Text="Estado"></asp:Label>
            <div class="col-md-2">
                <asp:DropDownList Class="form-control single-line" ID="drpEstados" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label11" runat="server" Text="Estatus"></asp:Label>
            <div class="col-md-2">
                <asp:DropDownList Class="form-control single-line" ID="drpEstatus" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <asp:Button class="btn btn-success" ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                <br />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <a href="Index.aspx">Regresar a la lista</a>
            </div>
        </div>

    </div>


    <script type="text/javascript">
        function CurpValidar(source, args) {
            var fechaN = $("#<%=txtFn.ClientID%>").val();
            var curpFecha = $("#<%=txtCurp.ClientID%>").val().substr(4, 6);
            var curpForma = fechaN.substr(2, 2) + fechaN.substr(5, 2) + fechaN.substr(8, 2);
            args.IsValid = curpFecha == curpForma;
        }
    </script>


</asp:Content>

