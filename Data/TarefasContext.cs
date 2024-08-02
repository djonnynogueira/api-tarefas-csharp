using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations.Schema;
using ApiTarefas.Models;
using ApiTarefas.Data;
namespace ApiTarefas.Data
{
    public class TarefasContext : DbContext
    {
        public TarefasContext(DbContextOptions<TarefasContext> options) : base(options)

    {
    }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}