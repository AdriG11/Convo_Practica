using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convo_Practica
{
    public class Estudiante : Matricula
    {
        public string Nombre_Estudiante { get; set; }
        public string Apellido { get; set; }
        public int Fecha_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public int Numero_celular { get; set; }
        public string Codigo_Estudiantil { get; set; }
    }
}
