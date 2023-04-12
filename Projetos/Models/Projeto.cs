namespace Projetos.Models
{
    public class Projeto
    {
        public Projeto(int id, string nomeProjeto)
        {
            Id = id;
            NomeProjeto = nomeProjeto;
        }

        public int Id { get; set; }
        public string NomeProjeto { get; set; }
    }
}
