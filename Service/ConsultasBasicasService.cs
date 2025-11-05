using Estudo_Linq.Data;
using Estudo_Linq.Models;

namespace Estudo_Linq.Service
{

    public class ConsultasBasicasService
    {
        private static readonly List<Aluno> alunos = BaseDeDados.GetAlunos();

        // Utilizando where simples para filtrar alunos da turma 3A Id = 1
        public static void ObterAlunosTurma3A()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--Relatório 1: Alunos da turma 3A:");

            Console.ForegroundColor = ConsoleColor.Gray;
            var resultado = alunos.Where(a => a.TurmaId == 1);

            foreach (var aluno in resultado)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }

        }

        // Where Composto: Encontrar todos os alunos da Turma "3A" que têm 18 anos ou mais.
        public static void ObterAlunosTurma3ACom18AnosOuMais()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--Relatório 2: Alunos da turma 3A com 18 anos ou mais:");
            var resultado = alunos.Where(a => a.TurmaId == 1 && a.Idade >= 18);

            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var aluno in resultado)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }

        }

         // Select criar uma lista apenas com os nomes de todos os alunos.
        public static void ObterNomesDeTodosOsAlunos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--Relatório 3: Nomes de todos os alunos:");
            var resultado = alunos.Select(a => new Aluno { Nome = a.Nome });

            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var aluno in resultado)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
            }
        }

        // Select criar uma lista contendo o Nome do aluno e Idade em meses.
        public static void ObterNomeEIdadeEmMesesDeTodosAlunos()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--Relatório 4: Nome e Idade em meses de todos os alunos:");
            var resultadoIdadeMeses = alunos.Select(a => new
            {
                a.Nome,
                IdadeEmMeses = a.Idade * 12
            });

            Console.ForegroundColor = ConsoleColor.Gray;
            foreach (var aluno in resultadoIdadeMeses)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade em meses: {aluno.IdadeEmMeses}");
            }

        }

    }
}