using App.Enum;

namespace App.Models
{
    public class Nota
    {
        public int AlunoId { get; set; }
        public Disciplinas Disciplina { get; set; }
        public double Valor { get; set; }
    }
}