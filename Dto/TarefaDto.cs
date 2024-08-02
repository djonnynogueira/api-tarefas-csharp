using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefas.Models;
using ApiTarefas.Dto;

namespace ApiTarefas.Dto
{
    public record TarefaDto
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
        public bool Concluida { get; set; }
    }
}