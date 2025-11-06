using App.Enum;
using App.Models;

namespace App.Data
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
                new() { Id = 1, Nome = "Ana", Idade = 17, TurmaId = 1 },
                new() { Id = 2, Nome = "Bruno", Idade = 18, TurmaId = 1 },
                new() { Id = 3, Nome = "Carla", Idade = 17, TurmaId = 1 },
                new() { Id = 4, Nome = "Daniel", Idade = 18, TurmaId = 2 },
                new() { Id = 5, Nome = "Elisa", Idade = 19, TurmaId = 2 },
                new() { Id = 6, Nome = "Felipe", Idade = 18, TurmaId = 2 }
            };
        }

        public static List<Nota> GetNotas()
        {
            return new List<Nota>
            {
                new() { AlunoId = 1, Disciplina = Disciplinas.Matematica, Valor = 8.5 },
                new() { AlunoId = 1, Disciplina = Disciplinas.Portugues, Valor = 9.0 },
                new() { AlunoId = 2, Disciplina = Disciplinas.Matematica, Valor = 6.0 },
                new() { AlunoId = 2, Disciplina = Disciplinas.Portugues, Valor = 7.5 },
                new() { AlunoId = 3, Disciplina = Disciplinas.Matematica, Valor = 9.5 },
                new() { AlunoId = 3, Disciplina = Disciplinas.Portugues, Valor = 8.0 },
                new() { AlunoId = 4, Disciplina = Disciplinas.Matematica, Valor = 7.0 },
                new() { AlunoId = 4, Disciplina = Disciplinas.Portugues, Valor = 6.5 },
                new() { AlunoId = 5, Disciplina = Disciplinas.Matematica, Valor = 8.0 },
                new() { AlunoId = 5, Disciplina = Disciplinas.Portugues, Valor = 9.0 },
                new() { AlunoId = 6, Disciplina = Disciplinas.Matematica, Valor = 5.5 },
                new() { AlunoId = 6, Disciplina = Disciplinas.Portugues, Valor = 7.0 }
            };
        }
    }
}