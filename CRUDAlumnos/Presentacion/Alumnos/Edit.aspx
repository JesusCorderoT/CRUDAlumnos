<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Presentacion.Alumnos.Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="form-horizontal">
        <h2>Actualizar del alumno</h2>
        <hr />


        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label" runat="server" Text="Id"></asp:Label>
            <asp:TextBox Class="form-control text-box single-line" ID="txtId" runat="server" Enabled="false"></asp:TextBox>
            <div>
            </div>
        </div>

        <div class="form-group">
            <asp:Label class="control-label col-md-2" ID="Label2" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox Class="form-control text-box single-line" ID="txtNombre" runat="server" EnableTheming="True"></asp:TextBox>
            <div style="font-weight: 700">
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
                <asp:RegularExpressionValidator ID="revNombre" runat="server" ControlToValidate="txtNombre" ErrorMessage="Solo letras y espacios" ValidationExpression="^[a-zA-Z](\s*[a-zA-Z]*)*[a-zA-Z]+$"></asp:RegularExpressionValidator>
                <asp:TextBox Class="form-control text-box single-line" ID="txtPa" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtSp" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtFn" runat="server" type="DateTime" TextMode="Date" ClientIDMode="Static"></asp:TextBox>

                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="La fecha de nacimineto no coinicde con el CURP" OnServerValidate="CustomValidator1_ServerValidate" ControlToValidate="txtCurp" CssClass="alert-danger" ValidateEmptyText="True"></asp:CustomValidator>

            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label6" runat="server" Text="Curp"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtCurp" runat="server" ClientIDMode="Static"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label7" runat="server" Text="Correo"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtCorreo" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label8" runat="server" Text="Telefono"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtTelefono" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label9" runat="server" Text="Sueldo"></asp:Label>
                <asp:TextBox Class="form-control text-box single-line" ID="txtSueldo" runat="server"></asp:TextBox>
            </div>
        </div>


        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label10" runat="server" Text="Estado"></asp:Label>
                <asp:DropDownList Class="form-control text-box single-line" ID="drpEstados" runat="server"></asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <div>
                <asp:Label class="control-label col-md-2" ID="Label11" runat="server" Text="Estatus"></asp:Label>
                <asp:DropDownList Class="form-control text-box single-line" ID="drpEstatus" runat="server">
                </asp:DropDownList>
                <br />

            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <asp:Button Class="btn btn-warning" ID="btnActualizar" runat="server" OnClick="btnActualizar_Click" Text="Guardar" />
            </div>
        </div>

        <div class="form-group">
             <div class="col-md-2">
                <a  href="Index.aspx">Regresar a la lista</a>
            </div>
        </div>


    </div>

</asp:Content>
