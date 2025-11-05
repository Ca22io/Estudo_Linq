using Estudo_Linq.Service;

// Consultas Básicas com LINQ
Console.WriteLine("Filtros (Where) e Projeções (Select)\n");

ConsultasBasicasService.ObterAlunosTurma3A();
ConsultasBasicasService.ObterAlunosTurma3ACom18AnosOuMais();
ConsultasBasicasService.ObterNomesDeTodosOsAlunos();
ConsultasBasicasService.ObterNomeEIdadeEmMesesDeTodosAlunos();