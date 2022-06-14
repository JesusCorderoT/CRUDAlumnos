using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;

namespace Presentacion.Alumnos
{
    public partial class Edit : System.Web.UI.Page
    {
        NAlumno cap = new NAlumno();
        int id = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { 
            int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");
            Alumno alu = cap.Consultar(id);
            txtId.Text = alu.id.ToString();
            txtNombre.Text = alu.nombre.ToString();
            txtPa.Text = alu.primerApellido.ToString();
            txtSp.Text = alu.segundoApellido.ToString();


                //DateTime date = Convert.ToDateTime(txtFn.Text);
                //txtFn.Text = date.ToString("yyyy-MM-dd");

                //txtFn.Text = DateTime.Now.ToString("yyyy-MM-dd");


                //txtFn.Text = alu.fechaNacimiento.ToString();

                txtFn.Text = String.Format("{0:yyyy-MM-dd}", alu.fechaNacimiento);

                //txtFn.Text = alu.fechaNacimiento.ToShortDateString();

            txtCurp.Text = alu.curp.ToString();
            txtCorreo.Text = alu.correo.ToString();
            txtTelefono.Text = alu.telefono.ToString();
            txtSueldo.Text = alu.sueldo.ToString();
            drpEstados.SelectedValue = alu.idestadoorigen.ToString();
            drpEstatus.SelectedValue = alu.idEstatus.ToString();
            txtTelefono.Text = alu.telefono.ToString();



                if (!IsPostBack)
                {

                    NEstatusAlumno ado = new NEstatusAlumno();
                    NEstado es = new NEstado();

                    drpEstados.DataSource = es.Consultar();
                    drpEstados.DataValueField = "id";
                    drpEstados.DataTextField = "nombre";
                    drpEstados.DataBind();

                    drpEstatus.DataSource = ado.Consultar();
                    drpEstatus.DataValueField = "id";
                    drpEstatus.DataTextField = "nombre";
                    drpEstatus.DataBind();

                }
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Page.IsValid) { 
                int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");
                Alumno alu = cap.Consultar(id);
                alu.nombre = txtNombre.Text;
                alu.primerApellido = txtPa.Text;
                alu.segundoApellido = txtSp.Text;
                alu.correo = txtCorreo.Text;
                alu.telefono = txtTelefono.Text;
                alu.fechaNacimiento = Convert.ToDateTime(txtFn.Text);
                alu.curp = txtCurp.Text;
                alu.sueldo = Convert.ToDecimal(txtSueldo.Text);
                alu.idestadoorigen = Convert.ToInt32(drpEstados.SelectedValue);
                alu.idEstatus = Convert.ToInt32(drpEstatus.SelectedValue);
                cap.Actualizar(alu);
                Response.Redirect($"Index.aspx");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            var fechaNac = txtFn.Text;
            var extracCurpFecha = txtCurp.Text.Substring(4,6);
            var fechaNacCurp = fechaNac.Substring(2,2) + fechaNac.Substring(5,2) + fechaNac.Substring(8,2);
            args.IsValid = extracCurpFecha == fechaNacCurp;
        }
    }
}





//CODIGO DURO
//List<Alumno> lista = cap.Consultar();
//Alumno alu = new Alumno()
//{
//    nombre = "ACTULIZADO",
//    primerApellido = "ACTULIZADO",
//    segundoApellido = "ACTULIZADO",
//    correo = "ACTULIZADO@bot.com",
//    telefono = "5540677545",
//    fechaNacimiento = new DateTime(1999, 12, 23),
//    curp = "YSIB",
//    sueldo = 30000,
//    idestadoorigen = 1,
//    idEstatus = 2,
//    id = 1010
//};

//cap.Actualizar(alu);
