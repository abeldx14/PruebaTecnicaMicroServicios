using Microsoft.EntityFrameworkCore;
using PruebaTecnicaMicroServicios.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaMicroServicios.DBContexts
{
    public class PersonaContext: DbContext
    {
        public  PersonaContext(DbContextOptions<PersonaContext> opciones) : base(opciones)
        {

        }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }

    }
}
