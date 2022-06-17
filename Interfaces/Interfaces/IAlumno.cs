using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Interfaces
{
    public interface IAlumno
    {
        AlumnoModel GetAlumno();
        List<AlumnoModel> GetAlumnos();
        List<AlumnoModel> GetAlumnoByFirstLetter(char FirstLetter);
        void SetAlumno(AlumnoModel alumno);
        void DeleteAlumno(int id);
        void EditAlumno(AlumnoModel alumno);


    }
}
