using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoWeb.Models
{
    class Tarefa
    {

        public int TarefaId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public bool Concluida { get; set; }

        public int UsuarioId { get; set; }

        public int CategoriaId { get; set; }


    }
}
