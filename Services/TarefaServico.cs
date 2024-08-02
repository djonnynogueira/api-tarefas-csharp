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
using ApiTarefas.Services.Interfaces;


namespace ApiTarefas.Services
{
    public class TarefaServico : ITarefaServico
    {
        public TarefaServico(TarefasContext db)
        {
            _db = db;
        }

        private TarefasContext _db;

        public List<Tarefa> Lista(int page = 1)
        {
            if(page < 1) page = 1;
            int limit = 10;
            int offset = (page - 1) * limit;
            return _db.Tarefas.Skip(offset).Take(limit).ToList();
        }

        public Tarefa Incluir(TarefaDto tarefaDto)
        {
            if (string.IsNullOrEmpty(tarefaDto.Titulo))
                throw new TarefaErro("O titulo da tarefa não pode ser vazio.");
                
            var tarefa = new Tarefa
            {
                Titulo = tarefaDto.Titulo,
                Descricao = tarefaDto.Descricao,
                Concluida = tarefaDto.Concluida,
            };

            _db.Tarefas.Add(tarefa);
            _db.SaveChanges();
            return tarefa;
        }

        public Tarefa Update(int id, TarefaDto tarefaDto)
        {

            if (string.IsNullOrEmpty(tarefaDto.Titulo))
               throw new TarefaErro("O titulo da tarefa não pode ser vazio.");
            //var tarefa = new Tarefa
            var tarefaDb = _db.Tarefas.Find(id);
            if (tarefaDb == null)
                throw new TarefaErro("Tarefa não encontrada");

            tarefaDb.Titulo = tarefaDto.Titulo;
            tarefaDb.Descricao = tarefaDto.Descricao;
            tarefaDb.Concluida = tarefaDto.Concluida;

            _db.Tarefas.Update(tarefaDb);
            _db.SaveChanges();
            return tarefaDb;
        }

        public Tarefa BuscaPorId(int id)
        {
            var tarefaDb = _db.Tarefas.Find(id);
            if (tarefaDb == null)
                throw new TarefaErro("Tarefa não encontratda");
                

            return tarefaDb;
        }

        public void Delete(int id)
        {
            var tarefaDb = _db.Tarefas.Find(id); 
            if (tarefaDb == null)
                throw new TarefaErro("Tarefa não encontratda");

            _db.Tarefas.Remove(tarefaDb);
            _db.SaveChanges();
        }
    }
}