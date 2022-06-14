using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace Datos
{
    public class DEstatusAlumno
    {

        EstatusAlumno ea = new EstatusAlumno();
        List<EstatusAlumno> lstEstados = new List<EstatusAlumno>();


        string _cnnString = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        SqlCommand comando;

        public List<EstatusAlumno> Consultar()
        {
            string query = $"PO_consultarEstatusAlumnos";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter("@ida", -1));
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    lstEstados.Add(new EstatusAlumno()
                    {
                        id = Convert.ToInt32(reader["id"]),
                        nombre = reader["nombre"].ToString(),
                    });
                }
                con.Close();
            }
            return lstEstados;
        }
    }
}
