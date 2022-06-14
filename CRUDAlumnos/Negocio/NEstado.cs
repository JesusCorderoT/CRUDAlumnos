using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class NEstado
    {
        DEstado da = new DEstado();
        public List<Estado> Consultar()
        {
            List<Estado> lstAlumnos = new List<Estado>();
            lstAlumnos = da.Consultar();
            return lstAlumnos;
        }

    }
}
