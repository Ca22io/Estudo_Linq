using App.Data;

namespace App.Service
{
    public class OrdenacaoElementosService
    {
        // OrderBy / OrderByDescending: Listar todos os alunos em ordem alfabética (e depois em ordem de idade, do mais velho para o mais novo).
        public static void OrdenarElementos()
        {
            var alunos = BaseDeDados.GetAlunos();

            var alunosOrdenadosPorNome = alunos.OrderBy(a => a.Nome).ToList();
            var alunosOrdenadosPorIdadeDesc = alunos.OrderByDescending(a => a.Idade).ToList();


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Alunos ordenados por nome:");
            foreach (var aluno in alunosOrdenadosPorNome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos");
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Alunos ordenados por idade (do mais velho para o mais novo):");
            foreach (var aluno in alunosOrdenadosPorIdadeDesc)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"{aluno.Nome} - {aluno.Idade} anos");
            }
        }

        // First vs FirstOrDefault: Encontrar o primeiro aluno da Turma "3B".

        public static void FirstVsFirstOrDefault()
        {
            var alunos = BaseDeDados.GetAlunos();

            var primeiroAluno3B = alunos.Where(a => a.TurmaId == 2).First();
            var primeiroAluno3BVazio = alunos.Where(a => a.TurmaId == 4).FirstOrDefault();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Primeiro aluno da Turma 3B:");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{primeiroAluno3B.Nome} - 3B");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Primeiro aluno da Turma Inexistente (usando FirstOrDefault):");
            if (primeiroAluno3BVazio == null)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Nenhum aluno encontrado.");
            }
        }

        // Single vs SingleOrDefault: Encontrar o aluno com Id = 3.
        public static void SingleVsSingleOrDefault()
        {
            var alunos = BaseDeDados.GetAlunos();

            var alunoComId3 = alunos.Where(a => a.Id == 3).Single();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Aluno com Id = 3:");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{alunoComId3.Nome} - Id: {alunoComId3.Id}");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-- Aluno com Id Inexistente (usando SingleOrDefault):");


            var alunoComIdInexistente = alunos.Where(a => a.Id == 99).SingleOrDefault();
            if (alunoComIdInexistente == null)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Nenhum aluno encontrado.");
            }

        }
    }
}