using Jazmine_AP1_P1.Models;
using Microsoft.EntityFrameworkCore;

namespace Jazmine_AP1_P1.Context;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public virtual DbSet<Autores> Models { get; set; }
}
