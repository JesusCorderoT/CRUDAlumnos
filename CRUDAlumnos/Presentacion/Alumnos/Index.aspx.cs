using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Presentacion.Alumnos
{
    public partial class Index : System.Web.UI.Page
    {
        NAlumno cap = new NAlumno();
        NEstado cEstado = new NEstado();
        NEstatusAlumno cEstatus = new NEstatusAlumno();
        //  List<Alumno> lista = cap.Consultar();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                grdAlumnos.DataSource = cap.Consultar();
               ListaNombre();
                grdAlumnos.DataBind();
            }
          

        
        }

        protected void grdAlumnos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdAlumnos.PageIndex = e.NewPageIndex;
            ListaNombre();
            grdAlumnos.DataBind();
        }

        protected void grdAlumnos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Page")
            {
                return;
            }

            int nRen = Convert.ToInt32(e.CommandArgument);

            GridViewRow renglon = grdAlumnos.Rows[nRen];


            TableCell cel = renglon.Cells[0];

            int id = Convert.ToInt32(cel.Text);

            switch (e.CommandName)
            {

                case "CommandEdit":
                    Response.Redirect($"Edit.aspx?id={id}");
                    break;
                case "CommandDel":
                    Response.Redirect($"Delete.aspx?id={id}");
                    break;
                case "CommandSel":
                    Response.Redirect($"Details.aspx?id={id}");
                    break;





            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect($"Create.aspx");
        }

        protected void grdAlumnos_Load(object sender, EventArgs e)
        {
            

        }

        public void ListaNombre() {


            List<EstatusAlumno> lstEstatus = cEstatus.Consultar();
            List<Estado> lstEstados = cEstado.Consultar();
            List<Alumno> lstAlumno = cap.Consultar();


            var ListaAEE =
             from Alum in lstAlumno
             join Estado in lstEstados on Alum.idestadoorigen equals Estado.id
             join Estatus in lstEstatus on Alum.idEstatus equals Estatus.id
             select new { Alum.id,Alum.nombre,Alum.primerApellido,Alum.segundoApellido,Alum.correo,Alum.telefono,Alum.fechaNacimiento,Alum.curp,Alum.sueldo ,estado = Estado.nombre, estatus = Estatus.nombre };

            grdAlumnos.DataSource = ListaAEE.ToList();
            grdAlumnos.DataBind();

        }

    }
}