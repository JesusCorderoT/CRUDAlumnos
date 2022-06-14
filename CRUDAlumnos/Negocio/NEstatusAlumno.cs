using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class NEstatusAlumno
    {

        DEstatusAlumno da = new DEstatusAlumno();

        public List<EstatusAlumno> Consultar()
        {
            List<EstatusAlumno> lstAlumnos = new List<EstatusAlumno>();
            lstAlumnos = da.Consultar();
            return lstAlumnos;
        }


    }
}
