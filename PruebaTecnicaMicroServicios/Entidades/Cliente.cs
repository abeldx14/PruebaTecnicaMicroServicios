using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMicroServicios.Entidades
{
    public class Cliente
    {
        public int clienteid { get; set; }
        public string contraseña { get; set; }
        public string estado { get; set; }
        public virtual Persona Peronsa { get; set; }
    }
}
