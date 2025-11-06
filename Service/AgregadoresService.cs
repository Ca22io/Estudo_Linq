using App.Data;
using App.Enum;
using App.Models;

namespace App.Service
{
    public class AgregadoresService
    {
        private static readonly List<Aluno> alunos = BaseDeDados.GetAlunos();
        private static readonly List<Nota> Notas = BaseDeDados.GetNotas();
        // Count: Quantos alunos têm na Turma "3A"?
        public static void CountAlunosTurma3A()
        {

            var quantidadeAlunos3A = alunos.Where(a => a.TurmaId == 1).Count();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n-- Quantidade de alunos na Turma 3A:");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Total: {quantidadeAlunos3A}");
        }

        // Average: Qual a média de notas de todos os alunos em "Matemática"?
        public static void AverageNotasMatematica()
        {

            var mediaNotasMatematica = Notas
                .Where(a => a.Disciplina == Disciplinas.Matematica)
                .Average(a => a.Valor);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n-- Média de notas em Matemática:");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Média: {mediaNotasMatematica:F2}");
        }

        // Max / Min: Qual foi a nota mais alta e a mais baixa em "Português"?
        public static void MaxMinNotasPortugues()
        {

            var notaMaisAltaPortugues = Notas
                .Where(a => a.Disciplina == Disciplinas.Portugues)
                .Max(a => a.Valor);

            var notaMaisBaixaPortugues = Notas
                .Where(a => a.Disciplina == Disciplinas.Portugues)
                .Min(a => a.Valor);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n-- Notas minimas e máximas em Português:");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Nota mais alta: {notaMaisAltaPortugues}");
            Console.WriteLine($"Nota mais baixa: {notaMaisBaixaPortugues}");
        }

        // Sum: Somatoria das notas das disciplinas de Matemática e Português de um aluno específico.
        public static void SumNotasMatematicaPortugues(int alunoId)
        {
            var somaNotas = Notas
                .Where(a => a.AlunoId == alunoId)
                .Sum(a => a.Valor);

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\n-- Soma das notas de Matemática e Português do Aluno {alunoId}");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Soma das notas: {somaNotas}");
        }

    }
}