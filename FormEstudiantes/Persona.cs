using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crear un formulario que contenga la clase Persona: Nombres, Apellidos, FechaNacimiento, FechaCreacion, UsuarioCreacion y que inserte
20 personas, lo muestre en un datagridview (tabla) solo tres campos; Nombres, Apellidos y FechaNacimiento. */

namespace FormEstudiantes
{
    internal class Persona
    {
        //Agregar los atributos de las personas
        public int PersonaId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
    }
}
