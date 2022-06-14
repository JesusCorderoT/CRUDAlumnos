<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="Presentacion.Alumnos.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


       <%-- <div>
        <!-- Control asp Label para mensajes -->
        <hr />
        <div>
            <!-- Par de label html - Control asp por cada propiedad -->
            <label for="idControl">Eliminiar Alumno</label>
            &nbsp;<div>
                <asp:Label ID="Label" runat="server" Text="Id"></asp:Label>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </div>
        </div>

        <div>
            <div><asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>

                <asp:Label ID="lblName" runat="server" Text=""></asp:Label>

            </div>
        </div>


        <div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
                <asp:Label ID="lblPa" runat="server" Text=" "></asp:Label>

            </div>
        </div>

        <div>
            <div>
                <asp:Label ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
                <asp:Label ID="lblSp" runat="server" Text=" "></asp:Label>
            </div>
        </div>


           <div>
            <div>
                <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
                <asp:Label ID="lblFn" runat="server" Text=""></asp:Label>
            </div>
        </div>

            <div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="Curp"></asp:Label>
                <asp:Label ID="lblCurp" runat="server" Text=" "></asp:Label>
            </div>
        </div>


            <div>
            <div>
                <asp:Label ID="Label7" runat="server" Text="Correo"></asp:Label>
                <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
            </div>
        </div>

           <div>
            <div>
                <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>
                <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
            </div>
        </div>

           <div>
            <div>
                <asp:Label ID="Label9" runat="server" Text="Sueldo"></asp:Label>
                <asp:Label ID="lblSueldo" runat="server" Text=""></asp:Label>
            </div>
        </div>


           <div>
            <div>
                <asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>
                <asp:Label ID="lbliEstado" runat="server" Text=""></asp:Label>
            </div>
        </div>

           <div>
            <div>
                <asp:Label ID="Label11" runat="server" Text="Estatus"></asp:Label>
                <asp:Label ID="lblidEstatus" runat="server" Text=""></asp:Label>
                <br />
                <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
                <br />
                <br />
                <a href="Index.aspx">Regresar a la lista</a>
                <br />
            </div>
        </div>



    </div>--%>

    
    <div class="form-horizontal">
        <h2>Eliminar alumno</h2>

         <h3>Esta seguro que quiere eliminar el alumno?</h3>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                <asp:Label ID="Label" runat="server" Text="ID"></asp:Label>
            </dt>
            <dd>
                <asp:Label ID="lblId" runat="server" Text=""></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblNombre" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <asp:Label ID="Label3" runat="server" Text="Primer apellido"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblPa" runat="server" Text=" "></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label4" runat="server" Text="Segundo apellido"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblSp" runat="server" Text=" "></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label5" runat="server" Text="Fecha nacimiento"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblFn" runat="server" Text=""></asp:Label>
            </dd>

            <dt>
                <asp:Label ID="Label6" runat="server" Text="Curp"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblCurp" runat="server" Text=" "></asp:Label>

            </dd>


            <dt>
                <asp:Label ID="Label7" runat="server" Text="Correo"></asp:Label>
            </dt>

            <dd>
                <asp:Label ID="lblCorreo" runat="server" Text=""></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label8" runat="server" Text="Telefono"></asp:Label>

            </dt>

            <dd>
                <asp:Label ID="lblTelefono" runat="server" Text=""></asp:Label>
            </dd>


            <dt>
                <asp:Label ID="Label9" runat="server" Text="Sueldo"></asp:Label>

            </dt>

            <dd>
                <asp:Label ID="lblSueldo" runat="server" Text=""></asp:Label></dd>

            <dt>
                <asp:Label ID="Label10" runat="server" Text="Estado"></asp:Label>

            </dt>

            <dd>
                <asp:Label ID="lbliEstado" runat="server" Text=""></asp:Label></dd>

            <dt>

                <asp:Label ID="Label11" runat="server" Text="Estatus"></asp:Label>

            </dt>

            <dd>
                <asp:Label ID="lblidEstatus" runat="server" Text=""></asp:Label></dd>





        </dl>




        <div class="">

            <div>
                <div>
                                    <asp:Button class="btn btn-danger" ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />

                </div>
            </div>

            <div>
                <div>
                    <br />
                    <a href="Index.aspx">Regresar a la lista</a>
                </div>
            </div>

        </div>














</asp:Content>
