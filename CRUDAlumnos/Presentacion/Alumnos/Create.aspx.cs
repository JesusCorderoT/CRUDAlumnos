using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Negocio;
using Entidades;

namespace Presentacion.Alumnos
{
    public partial class Create : System.Web.UI.Page
    {
        NAlumno cap = new NAlumno();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1");
                //Alumno alu = cap.Consultar(id);

                //txtPrueba.Text = alu.fechaNacimiento.ToShortDateString();
                //var a = txtPrueba.Text.Substring(8, 2) + txtPrueba.Text.Substring(3, 2) + txtPrueba.Text.Substring(0, 2);
                //txtF.Text = a;

                //txtPrueba2.Text = alu.curp.ToString();
                //var a2 = txtPrueba2.Text.Substring(4, 6);
                //txtC.Text = a2;

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
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Alumno alu = new Alumno();
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
                cap.Agregar(alu);
                Response.Redirect($"Index.aspx");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {

        }
    }
}






//Alumno alu = new Alumno() {
//    nombre = "nrvo",
//    primerApellido = "Scott",
//    segundoApellido = "Bot",
//    correo = "as@bot.com",
//    telefono = "5540677545",
//    fechaNacimiento = new DateTime(1999, 12, 23),
//    curp = "YSIB",
//    sueldo = 30000,
//    idestadoorigen = 1,
//    idEstatus = 2
//};

//cap.Agregar(alu);




//cbxEstados.DataSource = ado.Consultar();
//cbxEstados.DisplayMember = "nombre";
//cbxEstados.ValueMember = "id";