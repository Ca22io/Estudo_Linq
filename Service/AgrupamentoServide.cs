using App.Data;
using App.Models;

namespace App.Service
{
    public class AgrupamentoService
    {
        private static readonly List<Aluno> alunos = BaseDeDados.GetAlunos();
        private static readonly List<Nota> notas = BaseDeDados.GetNotas();
        // GroupBy Simples: Agrupar alunos por TurmaId e contar quantos alunos há em cada turma.
        public static void GroupBySimples()
        {
            var agrupamento = alunos
                .GroupBy(a => a.TurmaId)
                .Select(g => new
                {
                    TurmaId = g.Key,
                    QuantidadeAlunos = g.Count()
                });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-- Quantidade de alunos por turma:");
            foreach (var grupo in agrupamento)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Turma {grupo.TurmaId}: {grupo.QuantidadeAlunos} alunos");
            }
        }

        // GroupBy Avançado (Média por Aluno): Agrupar todas as notas por AlunoId. Para cada grupo, calcular a média de notas daquele aluno.
        public static void GroupByMediaPorAluno()
        {
            var agrupamento = alunos
                .Join(notas,
                    aluno => aluno.Id,
                    nota => nota.AlunoId,
                    (aluno, nota) => new
                    {
                        aluno.Id,
                        Nota = nota.Valor
                    })
                .GroupBy(x => x.Id)
                .Select(g => new
                {
                    AlunoId = g.Key,
                    MediaNotas = g.Average(x => x.Nota)
                });

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-- Média de notas por aluno:");
            foreach (var grupo in agrupamento)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Aluno {grupo.AlunoId}: Média de Notas = {grupo.MediaNotas:F2}");
            }
        }
    }
}