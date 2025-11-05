using Estudo_Linq.Enum;
using Estudo_Linq.Models;

namespace Estudo_Linq.Data
{
    public static class BaseDeDados
    {
        public static List<Turma> GetTurmas()
        {
            return new List<Turma>
            {
                new() { Id = 1, NomeTurma = "3A", Turno = Turno.Matutino },
                new() { Id = 2, NomeTurma = "3B", Turno = Turno.Vespertino }
            };
        }

        public static List<Aluno> GetAlunos()
        {
            return new List<Aluno>
            {
                new() { Id = 101, Nome = "Ana", Idade = 17, TurmaId = 1 },
                new() { Id = 102, Nome = "Bruno", Idade = 18, TurmaId = 1 },
                new() { Id = 103, Nome = "Carla", Idade = 17, TurmaId = 1 },
                new() { Id = 104, Nome = "Daniel", Idade = 18, TurmaId = 2 },
                new() { Id = 105, Nome = "Elisa", Idade = 19, TurmaId = 2 },
                new() { Id = 106, Nome = "Felipe", Idade = 18, TurmaId = 2 }
            };
        }

        public static List<Nota> GetNotas()
        {
            return new List<Nota>
            {
                new() { AlunoId = 101, Disciplina = Disciplinas.Matematica, Valor = 8.5 },
                new() { AlunoId = 101, Disciplina = Disciplinas.Portugues, Valor = 9.0 },
                new() { AlunoId = 102, Disciplina = Disciplinas.Matematica, Valor = 6.0 },
                new() { AlunoId = 102, Disciplina = Disciplinas.Portugues, Valor = 7.5 },
                new() { AlunoId = 103, Disciplina = Disciplinas.Matematica, Valor = 9.5 },
                new() { AlunoId = 103, Disciplina = Disciplinas.Portugues, Valor = 8.0 },
                new() { AlunoId = 104, Disciplina = Disciplinas.Matematica, Valor = 7.0 },
                new() { AlunoId = 104, Disciplina = Disciplinas.Portugues, Valor = 6.5 },
                new() { AlunoId = 105, Disciplina = Disciplinas.Matematica, Valor = 8.0 },
                new() { AlunoId = 105, Disciplina = Disciplinas.Portugues, Valor = 9.0 },
                new() { AlunoId = 106, Disciplina = Disciplinas.Matematica, Valor = 5.5 },
                new() { AlunoId = 106, Disciplina = Disciplinas.Portugues, Valor = 7.0 }
            };
        }
    }
}