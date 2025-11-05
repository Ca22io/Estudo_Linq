using Estudo_Linq.Enum;

namespace Estudo_Linq.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public required string NomeTurma { get; set; }
        public Turno Turno { get; set; }
    }
}