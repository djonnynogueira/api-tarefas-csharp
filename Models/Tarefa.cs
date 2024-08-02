using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ApiTarefas.Models;
using ApiTarefas.Data;
using ApiTarefas.Services;


namespace ApiTarefas.Models
{

    [Table("tarefas")]
    public class Tarefa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Titulo { get; set; }
        [Column(TypeName = "text")]
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}