using App.Service;

// Consultas Básicas com LINQ
// Console.WriteLine("----Filtros (Where) e Projeções (Select)----\n");

// ConsultasBasicasService.ObterAlunosTurma3A();
// ConsultasBasicasService.ObterAlunosTurma3ACom18AnosOuMais();
// ConsultasBasicasService.ObterNomesDeTodosOsAlunos();
// ConsultasBasicasService.ObterNomeEIdadeEmMesesDeTodosAlunos();

// Ordenação de Elementos com LINQ
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("\n----Ordenação de Elementos (OrderBy / OrderByDescending)----\n");
OrdenacaoElementosService.OrdenarElementos();
OrdenacaoElementosService.FirstVsFirstOrDefault();
OrdenacaoElementosService.SingleVsSingleOrDefault();