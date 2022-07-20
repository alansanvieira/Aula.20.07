namespace PoCWebAPI.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public Curso Curso { get; set; } = new Curso();
    }
}
