using DevExpress.Mvvm.DataAnnotations;
using Projetos.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Projetos.ViewModels
{
    [POCOViewModel]
    public class MainViewModel
    {
        public virtual ObservableCollection<Projeto> ListaProjetos { get; set; } =
            new ObservableCollection<Projeto>() { new Projeto(1, "Projeto 1"), new Projeto(2, "Projeto 2") };
        public virtual ObservableCollection<Tarefa> ListaTarefas { get; set; } =
            new ObservableCollection<Tarefa>() {
                new Tarefa(1, "Tarefa 1 do projeto 1", DateTime.Now.AddDays(-5), DateTime.Now, 1),
                new Tarefa(2, "Tarefa 2 do projeto 1", DateTime.Now.AddDays(-4), null, 1),
                new Tarefa(3, "Tarefa 3 do projeto 1", DateTime.Now.AddDays(-4), null, 1) ,
                new Tarefa(4, "Tarefa 1 do projeto 2", DateTime.Now.AddDays(-10), DateTime.Now, 2),
                new Tarefa(5, "Tarefa 2 do projeto 2", DateTime.Now.AddDays(-4), null, 2)};
        public virtual IList<Tarefa> ListaFiltrada { get; set; } =
            new List<Tarefa>();

        public virtual void FiltrarTarefasPorProjeto(int projetoId)
        {
            ListaFiltrada = ListaTarefas.Where(x => x.ProjetoId == projetoId).ToList();
        }
    }
}