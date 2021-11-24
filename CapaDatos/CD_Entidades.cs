using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos.Models;

namespace CapaDatos
{
    class CD_Entidades
    {
        private readonly REGISTROEntities _db;

        public CD_Entidades()
        {
            _db = new REGISTROEntities();
        }

        public List<CONSULTAS> Mostrar() => _db.CONSULTAS.ToList();

        public void Insertar(int semana, int estudiantes, string tipo_consulta, string tema_consulta, DateTime fecha, string carnet, string observaciones, bool aprobación)
        {
            var NuevaConsulta = new CONSULTAS()
            {
                NUMERO_SEMANA = semana,
                CANTIDAD_ESTUDIANTE = estudiantes,
                TIPO_CONSULTA = tipo_consulta,
                TEMA_CONSULTA = tema_consulta,
                FECHA = fecha,
                CARNET_ESTUDIANTE = carnet,
                OBSERVACIONES = observaciones,
                APROBACION = aprobación
            };

            _db.CONSULTAS.Add(NuevaConsulta);
            _db.SaveChanges();
        }

        public void Editar(int id, int semana, int estudiantes, string tipo_consulta, string tema_consulta, DateTime fecha, string carnet, string observaciones, bool aprobación)
        {
            var ConsultaAEditar = _db.CONSULTAS.FirstOrDefault(x => x.ID == id);

            ConsultaAEditar.NUMERO_SEMANA = semana;
            ConsultaAEditar.CANTIDAD_ESTUDIANTE = estudiantes;
            ConsultaAEditar.TIPO_CONSULTA = tipo_consulta;
            ConsultaAEditar.TEMA_CONSULTA = tema_consulta;
            ConsultaAEditar.FECHA = fecha;
            ConsultaAEditar.CARNET_ESTUDIANTE = carnet;
            ConsultaAEditar.OBSERVACIONES = observaciones;
            ConsultaAEditar.APROBACION = aprobación;

            _db.Entry(ConsultaAEditar).State = System.Data.Entity.EntityState.Modified;
            _db.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var ConsultaAEliminar = _db.CONSULTAS.FirstOrDefault(x => x.ID == id);

            _db.CONSULTAS.Remove(ConsultaAEliminar);
            _db.SaveChanges();
        }
    }
}
