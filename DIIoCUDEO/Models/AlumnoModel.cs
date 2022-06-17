using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    public class AlumnoModel
    {
        public int IdAlumno { get; set; }
        public string Carne { get; set; }
        public string PrimerNombre  { get; set; }
        public string SegundoNombre  { get; set; }
        public string PrimerApellido  { get; set; }
        public string SegundoApellido  { get; set; }
        public string Celular { get; set; }
        public string TelefonoCasa { get; set; }
        public string Direccion { get; set; }
    }
}
