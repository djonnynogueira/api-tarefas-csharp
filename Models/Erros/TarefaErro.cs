using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTarefas.Models.Erros
{
    public class TarefaErro : Exception {
        public TarefaErro(string message) : base(message) 
        { 
            
        }
    }


}