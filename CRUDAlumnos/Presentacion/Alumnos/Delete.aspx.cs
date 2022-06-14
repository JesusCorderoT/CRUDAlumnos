using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;


namespace Presentacion.Alumnos
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1013");

            NAlumno cap = new NAlumno();
            Alumno alu = cap.Consultar(id);


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



            //{
            //    id = 1012,
            //};
            //cap.Eliminar(alu);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["ID"] ?? "1011");
            NAlumno cap = new NAlumno();
            Alumno alu = cap.Consultar(id);



            alu.nombre = lblNombre.Text;
            cap.Eliminar(alu);

            Response.Redirect($"Index.aspx");
        }
    }
}