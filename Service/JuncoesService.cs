using App.Data;
using App.Models;

namespace App.Service
{
    public class JuncoesService
    {
        private static readonly List<Aluno> alunos = BaseDeDados.GetAlunos();
        private static readonly List<Nota> notas = BaseDeDados.GetNotas();
        private static readonly List<Turma> turmas = BaseDeDados.GetTurmas();

        // Join (Turma e Aluno): Criar uma lista que mostre o Nome do Aluno e o Nome da Turma em que ele está. (Juntar Alunos com Turmas usando TurmaId e Turma.Id).
        public static void JoinTurmaEAluno()
        {
            var consulta = alunos
                .Join(turmas,
                      aluno => aluno.TurmaId,
                      turma => turma.Id,
                      (aluno, turma) => new
                      {
                          NomeAluno = aluno.Nome,
                          turma.NomeTurma
                      });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-- Lista de Alunos com suas respectivas Turmas:");
            foreach (var item in consulta)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Aluno: {item.NomeAluno}, Turma: {item.NomeTurma}");
            }
        }

        // Join Triplo (Desafio): Criar um relatório que mostre: Nome do Aluno, Nome da Turma e Média de Notas desse aluno. (Você precisará juntar Alunos, Turmas e o resultado do seu GroupBy da Fase 4).
        public static void JoinTriploRelatorio()
        {
            var mediasPorAluno = alunos
                .Join(notas,
                      aluno => aluno.Id,
                      nota => nota.AlunoId,
                      (aluno, nota) => new
                      {
                          aluno.Id,
                          aluno.Nome,
                          aluno.TurmaId,
                          Nota = nota.Valor
                      })
                .GroupBy(x => new { x.Id, x.Nome, x.TurmaId })
                .Select(g => new
                {
                    AlunoId = g.Key.Id,
                    NomeAluno = g.Key.Nome,
                    g.Key.TurmaId,
                    MediaNotas = g.Average(x => x.Nota)
                });

            var relatorio = mediasPorAluno
                .Join(turmas,
                      media => media.TurmaId,
                      turma => turma.Id,
                      (media, turma) => new
                      {
                          media.NomeAluno,
                          turma.NomeTurma,
                          media.MediaNotas
                      });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-- Relatório de Alunos com suas Turmas e Médias de Notas:");
            foreach (var item in relatorio)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"Aluno: {item.NomeAluno}, Turma: {item.NomeTurma}, Média de Notas: {item.MediaNotas:F2}");
            }
        }
    }
}