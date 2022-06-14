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
    public class DAlumno
    {

        string _cnnString = ConfigurationManager.ConnectionStrings["InstitutoConnection"].ConnectionString;
        SqlCommand comando;
        Alumno alumno = new Alumno();
        List<Alumno> _listA = new List<Alumno>();
        List<ItemTablaISR> _listISR = new List<ItemTablaISR>();

        public List<ItemTablaISR> ConsultarTablaISR()
        {
            string query = $"SELECT * FROM TABLAISR";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {

                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.Text;
                //comando.Parameters.Add(new SqlParameter ("@ida", -1));
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listISR.Add(new ItemTablaISR()
                        {
                        LimiteInferior = Convert.ToDecimal(reader["LimInf"]),
                        LimiteSuperior = Convert.ToDecimal(reader["LimSup"]),
                        CuotaFija = Convert.ToDecimal(reader["CuotaFija"]),
                        Excedente = Convert.ToDecimal(reader["ExedLimInf"]),
                        Subsidio = Convert.ToDecimal(reader["Subsidio"]),
                    });
                }
                con.Close();
            }
            return _listISR;
        }

        public List<Alumno> Consultar()
        {
            string query = $"PO_Consulta_A";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {

                comando = new SqlCommand(query, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add(new SqlParameter ("@ida", -1));
                con.Open();
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    _listA.Add(new Alumno()
                        {
                        id = Convert.ToInt32(reader["id"]),
                        nombre = reader["nombre"].ToString(),
                        primerApellido = reader["primerApellido"].ToString(),
                        segundoApellido = reader["segundoApellido"].ToString(),
                        correo = reader["correo"].ToString(),
                        telefono = reader["telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(reader["fechanacimiento"]),
                        curp = reader["curp"].ToString(),
                        sueldo = Convert.ToInt32(reader["sueldo"]),
                        idestadoorigen = Convert.ToInt32(reader["idestadoorigen"]),
                        idEstatus = Convert.ToInt32(reader["idEstatus"]),
                    });
                }
                con.Close();
            }
            return _listA;
        }

        public Alumno Consultar(int id)
        {
            Alumno es = new Alumno();
            string queryu = $"PO_Consulta_A";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
               
                comando = new SqlCommand(queryu, con);
                comando.CommandType = CommandType.StoredProcedure;
                con.Open();
                comando.Parameters.AddWithValue("@ida", id);
                SqlDataReader adpter = comando.ExecuteReader();
                while (adpter.Read())
                {

                    es = new Alumno()
                    {
                        id = Convert.ToInt32(adpter["id"]),
                        nombre = adpter["nombre"].ToString(),
                        primerApellido = adpter["primerApellido"].ToString(),
                        segundoApellido = adpter["segundoApellido"].ToString(),
                        correo = adpter["correo"].ToString(),
                        telefono = adpter["telefono"].ToString(),
                        fechaNacimiento = Convert.ToDateTime(adpter["fechanacimiento"]),
                        curp = adpter["curp"].ToString(),
                        sueldo = Convert.ToInt32(adpter["sueldo"]),
                        idestadoorigen = Convert.ToInt32(adpter["idestadoorigen"]),
                        idEstatus = Convert.ToInt32(adpter["idEstatus"]),
                    };


                }


                con.Close();
            }
            return es;
        }

       public void Agregar(Alumno estatus) {
       
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                string queryA = $"PO_agregarAlumnos";
                comando = new SqlCommand(queryA, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@name", estatus.nombre);
                comando.Parameters.AddWithValue("@first", estatus.primerApellido);
                comando.Parameters.AddWithValue("@surname", estatus.segundoApellido);
                comando.Parameters.AddWithValue("@mail", estatus.correo);
                comando.Parameters.AddWithValue("@phone", estatus.telefono);
                comando.Parameters.AddWithValue("@birth", estatus.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", estatus.curp);
                comando.Parameters.AddWithValue("@money", estatus.sueldo);
                comando.Parameters.AddWithValue("@state", estatus.idestadoorigen);
                comando.Parameters.AddWithValue("@status", estatus.idEstatus);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }

        }

        public Alumno Actualizar(Alumno estatus) {
          
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                string queryAc = $"PO_actualizarAlumnos";
                comando = new SqlCommand(queryAc, con);
                con.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@name", estatus.nombre);
                comando.Parameters.AddWithValue("@first", estatus.primerApellido);
                comando.Parameters.AddWithValue("@surname", estatus.segundoApellido);
                comando.Parameters.AddWithValue("@mail", estatus.correo);
                comando.Parameters.AddWithValue("@phone", estatus.telefono);
                comando.Parameters.AddWithValue("@birth", estatus.fechaNacimiento);
                comando.Parameters.AddWithValue("@curp", estatus.curp);
                comando.Parameters.AddWithValue("@money", estatus.sueldo);
                comando.Parameters.AddWithValue("@state", estatus.idestadoorigen);
                comando.Parameters.AddWithValue("@status", estatus.idEstatus);
                comando.Parameters.AddWithValue("@ida", estatus.id);
              
                comando.ExecuteNonQuery();
                con.Close();
            }
            return estatus;
        }

        public void Eliminar(Alumno estatus) {

            string queryd = $"PO_EliminarAlumno";
            using (SqlConnection con = new SqlConnection(_cnnString))
            {
                comando = new SqlCommand(queryd, con);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", estatus.id);
                con.Open();
                comando.ExecuteNonQuery();
                con.Close();
            }
        }
    }



}

