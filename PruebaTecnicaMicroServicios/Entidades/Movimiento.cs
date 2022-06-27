using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMicroServicios.Entidades
{
    public class Movimiento
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string tipoMovimiento { get; set; }
        public string valor { get; set; }
        public  double saldo { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}
