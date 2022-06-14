using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
using System.Threading.Tasks;
using System.Configuration;
using Negocio.WSAlumnosASMX;
using Newtonsoft.Json;

namespace Negocio
{
    public class NAlumno
    {
        DAlumno da = new DAlumno();

        public List<Alumno> Consultar() 
        { 
        List<Alumno> lstAlumnos = new List<Alumno>();
        lstAlumnos = da.Consultar();
        return lstAlumnos;
        }

        public Alumno Consultar(int id)
        {
            Alumno alumno = new Alumno();
            alumno = da.Consultar(id);
            return alumno;
        }

        public void Agregar(Alumno alumno) 
        {
            da.Agregar(alumno);
        }

        public void Actualizar(Alumno alumno)
        {
            da.Actualizar(alumno);
        }

        public void Eliminar(Alumno alumno)
        {
            da.Eliminar(alumno);
        }



        public Entidades.ItemTablaISR CalcularISR(decimal sueldo) {
            decimal calculoISR = 0;
            decimal resultado = 0;
            Entidades.ItemTablaISR iti = new Entidades.ItemTablaISR();
            try {
                WSAlumnosSoapClient wsAlumnos = new WSAlumnosSoapClient();
                WSAlumnosASMX.ItemTablaISR itemTablaISR = wsAlumnos.CalcularISR(5);
                string Json = JsonConvert.SerializeObject(itemTablaISR);
                Entidades.ItemTablaISR tablaISR = JsonConvert.DeserializeObject<Entidades.ItemTablaISR>(Json);
                return tablaISR;
            }
            catch (Exception){
                List<Entidades.ItemTablaISR> list = da.ConsultarTablaISR();
                iti = list.Find(x => x.LimiteInferior <= sueldo && x.LimiteSuperior >= sueldo);
                resultado = sueldo - iti.LimiteInferior;
                resultado = resultado * (resultado + (iti.Excedente / 100));
                iti.ISR = (resultado + iti.CuotaFija) - iti.Subsidio;
            }
            return iti;
        }

        public Entidades.AportacionesIMSS CalcularIMSS(decimal sueldo) {

            Entidades.AportacionesIMSS a = new Entidades.AportacionesIMSS();
            try
            {
                WSAlumnosSoapClient wsAlumnos = new WSAlumnosSoapClient();
                WSAlumnosASMX.AportacionesIMSS aportacionesIMSS = wsAlumnos.CalcularIMSS(2);
                string Json = JsonConvert.SerializeObject(aportacionesIMSS);
                Entidades.AportacionesIMSS iMSS = JsonConvert.DeserializeObject<Entidades.AportacionesIMSS>(Json);
                return iMSS;
            }
            catch (Exception)
            {
               // Entidades.AportacionesIMSS apm = new Entidades.AportacionesIMSS();
                decimal uma = Convert.ToDecimal(ConfigurationManager.AppSettings["UMA"]);
                a.EnfermedadMaternidad = (sueldo - 3 * uma) * 0.04m;
                a.InvalidezVida = sueldo * 0.605m;
                a.Retiro = sueldo * 0;
                a.Cesantía = sueldo * 1.125m;
                a.InvalidezVida = sueldo * 0;
            }
            return a;
        }
    }
}
