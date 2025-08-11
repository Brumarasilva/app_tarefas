using app_tarefas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace app_tarefas.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)

    {

    }
    public DbSet<Tipo> Tipos { get; set; } = null!;

public DbSet<app_tarefas.Models.Tarefa> Tarefa { get; set; } = default!;

   
}
