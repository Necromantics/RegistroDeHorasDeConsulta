using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_consultas
    {
        private CD_consultas instancia_CD_consultas = new CD_consultas();

        public DataTable MostrarProductos()
        {
            DataTable tabla = new DataTable();
            tabla = instancia_CD_consultas.Mostrar();
            return tabla;
        }

        public void InsertarConsulta(string semana, string estudiantes, string tipo_consulta, string tema_consulta, string fecha, string carnet, string observaciones, bool aprobación)
        {
            int _aprobacion;
            if (aprobación == true)
                _aprobacion = 1;
            else
                _aprobacion = 0;

            instancia_CD_consultas.Insertar(Convert.ToInt32(semana), Convert.ToInt32(estudiantes), tipo_consulta, tema_consulta, fecha, carnet, observaciones, _aprobacion);
        }

        public void EditarConsulta(int id, string semana, string estudiantes, string tipo_consulta, string tema_consulta, string fecha, string carnet, string observaciones, bool aprobación)
        {
            int _aprobacion;
            if (aprobación == true)
                _aprobacion = 1;
            else
                _aprobacion = 0;

            instancia_CD_consultas.Editar(id, Convert.ToInt32(semana), Convert.ToInt32(estudiantes), tipo_consulta, tema_consulta, fecha, carnet, observaciones, _aprobacion);
        }

        public void EliminarConsulta(string id)
        {
            instancia_CD_consultas.Eliminar(Convert.ToInt32(id));
        }
    }
}
