using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiTarefas.Data;
using ApiTarefas.Models;
using ApiTarefas.Services;
using ApiTarefas.Controller;
using ApiTarefas.Models.Erros;
using ApiTarefas.Views;
using ApiTarefas.Dto;

namespace ApiTarefas.Services.Interfaces
{
    public interface ITarefaServico
    {
        List<Tarefa> Lista(int page);

        Tarefa Incluir(TarefaDto tarefaDto);
        Tarefa Update(int id, TarefaDto tarefaDto);
        Tarefa BuscaPorId(int id);

        void Delete(int id);
    }
}