using System;

namespace Projetos.Models
{
    public class Tarefa
    {
        public Tarefa(int id, string nomeTarefa, DateTime dataInicio, DateTime? dataFim, int projetoId)
        {
            Id = id;
            NomeTarefa = nomeTarefa;
            DataInicio = dataInicio;
            DataFim = dataFim;
            ProjetoId = projetoId;
        }

        public int Id { get; set; }
        public string NomeTarefa { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFim { get; set; }
        public int ProjetoId { get; set; }
    }
}
