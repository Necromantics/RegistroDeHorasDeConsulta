using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_consultas
    {
        private CD_conexion conexion = new CD_conexion();

        SqlDataReader lector;
        DataTable tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        public DataTable Mostrar()
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "select ID, NUMERO_SEMANA as Semana, CANTIDAD_ESTUDIANTE AS 'Estudiantes Atendidos', TIPO_CONSULTA as 'Tipo de consulta', TEMA_CONSULTA as 'Tema de consulta', FECHA AS 'Fecha', CARNET_ESTUDIANTE as 'Carnet del estudiante', OBSERVACIONES as 'Observaciones', APROBACION as 'Aprobacion' from CONSULTAS";
            lector = Comando.ExecuteReader();
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(int semana, int estudiantes, string tipo_consulta, string tema_consulta, string fecha, string carnet, string observaciones, int aprobación)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "INSERT INTO CONSULTAS VALUES (" +
                semana + ", " + estudiantes + ", '" + tipo_consulta +"', '" +tema_consulta+ "', '" + fecha + "', '" + carnet + "', '" + observaciones + "', '"+ aprobación+"')";
            Comando.ExecuteNonQuery();
        }

        public void Editar(int id, int semana, int estudiantes, string tipo_consulta, string tema_consulta, string fecha, string carnet, string observaciones, int aprobación)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "Update Consultas set" +
                " NUMERO_SEMANA =" +semana+ ", CANTIDAD_ESTUDIANTE = " + estudiantes + ", TIPO_CONSULTA = '" + tipo_consulta + "', TEMA_CONSULTA = '" + tema_consulta + "', FECHA = '" + fecha + "', CARNET_ESTUDIANTE = '"+ carnet+ "', OBSERVACIONES = '" + observaciones + "', APROBACION = '" + aprobación + "' WHERE ID = " + id;
                
                /*"INSERT INTO CONSULTAS VALUES (" +
                semana + ", " + estudiantes + ", '" + tipo_consulta + "', '" + tema_consulta + "', '" + fecha + "', '" + carnet + "', '" + observaciones + "', " + aprobación + ")";*/
            Comando.ExecuteNonQuery();
        }

        public void Eliminar(int id)
        {
            Comando.Connection = conexion.AbrirConexion();
            Comando.CommandText = "DELETE FROM CONSULTAS WHERE ID = " + id +"";
            Comando.ExecuteNonQuery();
        }
    }
}
