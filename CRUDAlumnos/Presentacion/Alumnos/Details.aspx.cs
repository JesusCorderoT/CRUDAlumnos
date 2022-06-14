using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using Negocio.WSAlumnosASMX;
using Newtonsoft.Json;
using Negocio.WSAlumnosASMX;
using Microsoft.AspNetCore.Cors;

namespace Presentacion.Alumnos
{
    public partial class Details : System.Web.UI.Page
    {
        NAlumno cap = new NAlumno();

        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");

            Alumno estatus = cap.Consultar(id);

            lblId.Text = estatus.id.ToString();
            lblNombre.Text = estatus.nombre.ToString();
            lblPa.Text = estatus.primerApellido.ToString();
            lblSp.Text = estatus.segundoApellido.ToString();
            lblFn.Text = estatus.fechaNacimiento.ToString();
            lblCurp.Text = estatus.curp.ToString();
            lblCorreo.Text = estatus.correo.ToString();
            lblTelefono.Text = estatus.telefono.ToString();
            lblSueldo.Text = estatus.sueldo.ToString();
            lbliEstado.Text = estatus.idestadoorigen.ToString();
            lblidEstatus.Text = estatus.idEstatus.ToString();
            lblTelefono.Text = estatus.telefono.ToString();
        }

        protected void btnIMSS_Click(object sender, EventArgs e)
        {
            Entidades.AportacionesIMSS item = cap.CalcularIMSS(Convert.ToDecimal(lblSueldo.Text));

            lblIMSS.Text = ($"Enfermedades maternidad: {item.EnfermedadMaternidad} " +
                $"Invalidez vida {item.InvalidezVida}  Retiro: {item.Retiro} " +
                $"Cesantia: {item.Cesantía}  Infonativ {item.Infonavit}");
            NAlumno nAlumno = new NAlumno();
            Entidades.AportacionesIMSS imss = nAlumno.CalcularIMSS(Convert.ToDecimal(lblSueldo.Text) / 2);
            lblEnfermedades.Text = imss.EnfermedadMaternidad.ToString("C2");
            lblCesantia.Text = imss.Cesantía.ToString("C2");
            lblInvalidez.Text = imss.InvalidezVida.ToString("C2");
            lblRetiro.Text = imss.Retiro.ToString("C2");
            lblInfonavit.Text = imss.Infonavit.ToString("C2");
           // venModalclienteIMSS.Show();




            //try
            //{
            //    WSAlumnosSoapClient wSAlumnos = new WSAlumnosSoapClient();
            //    Negocio.WSAlumnosASMX.AportacionesIMSS IMS = wSAlumnos.CalcularIMSS(Convert.ToInt32(lblId.Text));
            //    string Json = JsonConvert.SerializeObject(IMS);
            //    Entidades.AportacionesIMSS imss = JsonConvert.DeserializeObject<Entidades.AportacionesIMSS>(Json);
            //    MostrarISR(imss);
            //}
            //catch (Exception)
            //{
            //    NAlumno nAlumno = new NAlumno();
            //    //ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToDecimal(lblSueldoMensual.Text) / 2);
            //    Entidades.ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToInt32(lblId.Text));
            //    MostrarISR(tablaISR);
            //}




        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            //mpeModal.Hide();
        }

        protected void btnIsr_Click(object sender, EventArgs e)
        {

            //decimal sueldoQ = (Convert.ToDecimal(lblSueldo.Text)) / 2;
            //Entidades.ItemTablaISR item = cap.CalcularISR(sueldoQ);
            //lblISR.Text = ($"Limite inferior: {item.LimiteInferior} Limite superior: {item.LimiteSuperior}" +
            //    $"Cuota fija: {item.CuotaFija} Excedente: {item.CuotaFija}  Subsidio: {item.Subsidio} " +
            //    $"ISR: {item.ISR}");


            try
            {
                WSAlumnosSoapClient wSAlumnos = new WSAlumnosSoapClient();
                Negocio.WSAlumnosASMX.ItemTablaISR ISR = wSAlumnos.CalcularISR(Convert.ToInt32(lblId.Text));
                string Json = JsonConvert.SerializeObject(ISR);
                Entidades.ItemTablaISR tablaISR = JsonConvert.DeserializeObject<Entidades.ItemTablaISR>(Json);
                MostrarISR(tablaISR);
            }
            catch (Exception)
            {
                NAlumno nAlumno = new NAlumno();
                //ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToDecimal(lblSueldo.Text) / 2);
                Entidades.ItemTablaISR tablaISR = nAlumno.CalcularISR(Convert.ToInt32(lblId.Text));
                MostrarISR(tablaISR);
            }
        }

        protected void btnCerrarISR_Click(object sender, EventArgs e)
        {

            //mpeModalISR.Hide();
        }

        private void MostrarISR(Entidades.ItemTablaISR tablaISR)
        {
            lblLimInf.Text = tablaISR.LimiteInferior.ToString("C2");
            lblLimSup.Text = tablaISR.LimiteSuperior.ToString("C2");
            lblCuotaFija.Text = tablaISR.CuotaFija.ToString("C2");
            lblExcedente.Text = tablaISR.Excedente.ToString("C2");
            lblSubsidio.Text = tablaISR.Subsidio.ToString("C2");
            lblImpuesto.Text = tablaISR.ISR.ToString("C2");
            mpeModalISR.Show();
        }

    }
}



//List<Alumno> lista = cap.Consultar(id);

//foreach (Alumno alumno in lista) { 

//}



//int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1" );

//Alumno al = cap.Consultar(id);
//lblId.Text = Convert.ToString(al.id);
//lblName.Text = Convert.ToString(al.nombre);




//Alumno al = cap.Consultar(id);
//lblNombre.Text = al.nombre;


//ADOEstatusAlumno ado = new ADOEstatusAlumno();



//Alumno es = new Alumno()
//{
//    id = 1012
//};
//lblId.Text = Convert.ToString(es.id);
//lblName.Text = Convert.ToString(es.nombre); 
//cap.Consultar(es.id);


