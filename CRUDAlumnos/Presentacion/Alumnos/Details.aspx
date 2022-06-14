<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="Presentacion.Alumnos.Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


     <asp:Label ID="lblHidden" runat="server" Text=""></asp:Label>

      <ajaxtoolkit:modalpopupextender ID="mpeModalISR" runat="server" TargetControlID="lblHidden" PopupControlID="venModalSrvISR" DropShadow="true"></ajaxtoolkit:modalpopupextender>



    <div class="form-horizontal">
        <h2>Datos del alumno</h2>
        <hr />
        <dl class="dl-horizontal">
            <dt>
                <asp:Label ID="Label" runat="server" Text="ID"></asp:Label>
            </dt>
            <dd>
                <asp:Label ID="lblId" runat="server" Text="" ClientIDMode="Static"></asp:Label>
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
                <asp:Label ID="lblidEstatus" runat="server" Text=""></asp:Label>

            </dd>

            <br>

            <dt>
            <%--<asp:Button class="btn-info" ID="btnIMSS" runat="server" Text="Calcular IMSS" OnClick="btnIMSS_Click" />--%>
                <input id="iModal" type="button" onclick="CalcularIMSS()" class="btn btn-primary btn-md" value="CalcularIMSS" />
            </dt>

            <dd>
                   <asp:Button ID="btnIsr" runat="server" Text="Calcular ISR" OnClick="btnIsr_Click" />
            </dd>


        </dl>

        <div class="">

            <div>
                <div>
                    <asp:Label ID="lblIMSS" runat="server" Text="Label"></asp:Label>
                    <br />
                    <asp:Label ID="lblISR" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
            <div>
                <div>
                    <a href="Index.aspx">Regresar a la lista</a>
                    <br />
                    <br />
                </div>
            </div>
        </div>
</div>










        <%--Ventana Modal ISR - Servidor--%>
  <div id="venModalSrvISR">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del ISR</h4>
                    <asp:Button ID="btnXISR" runat="server" Text="&times;" class="close" OnClick="btnCerrarISR_Click" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblLimInf" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Limite Superior</dt>
                        <dd>
                            <asp:Label ID="lblLimSup" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cuota Fija</dt>
                        <dd>
                            <asp:Label ID="lblCuotaFija" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Excedente Limite Inferior</dt>
                        <dd>
                            <asp:Label ID="lblExcedente" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Subsidio</dt>
                        <dd>
                            <asp:Label ID="lblSubsidio" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Impuesto</dt>
                        <dd>
                            <asp:Label ID="lblImpuesto" runat="server" Text="Label"></asp:Label>
                        </dd>

                    </dl>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <asp:Button ID="btnCerrarISR" runat="server" Text="Cerrar" CssClass="btn btn-danger" OnClick="btnCerrarISR_Click" />
                </div>
            </div>
        </div>
    </div>





      <%--Ventana Modal IMSS - Cliente--%>
  <div class="modal" id="venModalclienteIMSS">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h4 class="modal-title">Cálculo del IMSS</h4>
                    <asp:Button ID="btnX" runat="server" Text="&times;" class="close" OnClick="btnCancelar_Click" />
                </div>
                <!-- Cuerpo de la Modal -->
                <div class="modal-body">
                    <dl>
                        <dt>Enfermedades y Maternidad</dt>
                        <dd>
                            <asp:Label ID="lblEnfermedades" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Invalidez y Vida</dt>
                        <dd>
                            <asp:Label ID="lblInvalidez" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Retiro</dt>
                        <dd>
                            <asp:Label ID="lblRetiro" runat="server" Text="Label"></asp:Label>
                        </dd>

                        <dt>Cesantia</dt>
                        <dd>
                            <asp:Label ID="lblCesantia" runat="server" Text="Label"></asp:Label>
                        </dd>
                        <dt>Infonavit</dt>
                        <dd>
                            <asp:Label ID="lblInfonavit" runat="server" Text="Label"></asp:Label>
                        </dd>

                    </dl>

                </div>
                <!-- Modal footer -->
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Cerrar</button>
                </div>
            </div>
        </div>

    </div>





      <script type="text/javascript">

        function CalcularIMSS() {

            var urlws = 'https://localhost:44394/WSAlumnos.asmx/CalcularIMSS';
            var id = $("#lblId").text();
            var alumno = { id: id};
            var parametros = JSON.stringify(alumno);
            LLamaAJAXPost(urlws, parametros, MuestraAportacionesIMSS);
           

        }
        function LLamaAJAXPost(url, parametros,funcionExito) {
            $.ajax(
                {

                type: 'post',
                url: url,
                data: parametros,
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: funcionExito,
                error: errorGenerico
                }
            );

        }

        function MuestraAportacionesIMSS(data) {
            try {
                imss = data.d;
                if (imss != null) {
                    $("#<%= lblEnfermedades.ClientID%>").text(imss.EnfermedadMaternidad);
                    $("#<%= lblInvalidez.ClientID%>").text(imss.InvalidezVida);
                    $("#<%= lblRetiro.ClientID%>").text(imss.Retiro);
                    $("#<%= lblCesantia.ClientID%>").text(imss.Cesantía);
                    $("#<%= lblInfonavit.ClientID%>").text(imss.Infonavit);
                    $("#venModalclienteIMSS").modal();
                }
                else {
                    alert('La respuesta recibida del Web Service es incorrecta ' + data.d);
                }
            }
            catch (ex) {
                alumno = [];
                alert('Error al recibir los datos');
            }
        }



        function errorGenerico(jqXHR, exception) {
            var msg = '';
            if (jqXHR.status === 0) {
                msg = 'No está conectado, favor de verificar su conexión.';
            }
            else if (jqXHR.status === 404) {
                msg = 'Página no encontrada [404]';
            }
            else if (jqXHR.status === 500) {
                msg = 'Error no hay conexión al servidor [500]';
            }
            else if (jqXHR.status === 'parseerror') {
                msg = 'El parseo del JSON es erróneo.';
            }
            else if (jqXHR.status === 'timeout') {
                $('body').addClass('loaded');
            }
            else if (jqXHR.status === 'abort') {
                msg = 'La petición Ajax fue abortada.';
            }
            else {
                msg = 'Error no conocido. ';
                console.log(exception);
            }
            alert(msg);
        }

      </script>


</asp:Content>
