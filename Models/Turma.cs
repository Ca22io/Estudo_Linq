using App.Enum;

namespace App.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public required string NomeTurma { get; set; }
        public Turno Turno { get; set; }
    }
}