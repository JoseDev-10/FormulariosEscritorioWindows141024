using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioEstudiantes
{
    public class Estudiante
    {
        //Declaramos las variables de la clase
        public int IdEstudiante { get; set; }
        public string nombres {  get; set; }
        public string apellidos { get; set; }
        public DateTime fechamat { get; set; }
        public bool becado {  get; set; }

    }
}
