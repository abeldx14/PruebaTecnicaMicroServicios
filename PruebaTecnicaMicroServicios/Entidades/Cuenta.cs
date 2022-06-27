using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMicroServicios.Entidades
{
    public class Cuenta
    {
        public int Id { get; set; }
        public int numeroCuenta { get; set; }
        public string tipoCuenta { get; set; }
        public double saldoInicial { get; set; }
        public string estado { get; set; }
        public virtual Cliente Clientes { get; set; }
    }
}
