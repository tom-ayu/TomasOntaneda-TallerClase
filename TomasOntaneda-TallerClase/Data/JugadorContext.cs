using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TomasOntaneda_TallerClase.Models;

    public class JugadorContext : DbContext
    {
        public JugadorContext (DbContextOptions<JugadorContext> options)
            : base(options)
        {
        }

        public DbSet<TomasOntaneda_TallerClase.Models.Jugador> Jugador { get; set; } = default!;

public DbSet<TomasOntaneda_TallerClase.Models.Equipo> Equipo { get; set; } = default!;

public DbSet<TomasOntaneda_TallerClase.Models.Estadio> Estadio { get; set; } = default!;
    }
