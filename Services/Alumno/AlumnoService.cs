using Dapper;
using Interfaces.Interfaces;
using Models.Models;
using Services.DB;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Alumno
{
    public class AlumnoService : IAlumno { 
    
        //Pooling de la conexión.
        //ORM Dapper, Entity Framework , NHibernate, DTO , etc
        //LECTURA -> Dapper ESCRITURA -> EF
        public void DeleteAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public void EditAlumno(AlumnoModel alumno)
        {
            throw new NotImplementedException();
            //Info anterior
            //iniciar una transacción
            //commit
        }

        public AlumnoModel GetAlumno()
        {
            //Incorrecta
            var ConnectioManager = new ConnectionManager();
            var conn = ConnectioManager.GetConnection();
            return conn.QueryFirst<AlumnoModel>("SELECT * FROM ALUMNO WHERE IdAlumno = 100");
            //return new AlumnoModel
            //{
            //    Carne = 12,
            //    Celular = 32323,
            //    Direccion = "zona 16",
            //    IdAlumno = 1,
            //    PrimerApellido = "Blanco",
            //    PrimerNombre = "Steveen",
            //    SegundoApellido = "Gómez",
            //    SegundoPrimerNombre = "Alexis",
            //    TelefonoCasa = 234324
            //};
        }

        public List<AlumnoModel> GetAlumnoByFirstLetter(char FirstLetter)
        {
            throw new NotImplementedException();
        }

        public List<AlumnoModel> GetAlumnos()
        {
            throw new NotImplementedException();
        }

        public void SetAlumno(AlumnoModel alumno)
        {
            throw new NotImplementedException();
        }
    }
}
