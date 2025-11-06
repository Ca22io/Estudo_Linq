using App.Service;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("----------------------------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("       Filtros (Where) e Projeções (Select)         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("----------------------------------------------------");

ConsultasBasicasService.ObterAlunosTurma3A();
ConsultasBasicasService.ObterAlunosTurma3ACom18AnosOuMais();
ConsultasBasicasService.ObterNomesDeTodosOsAlunos();
ConsultasBasicasService.ObterNomeEIdadeEmMesesDeTodosAlunos();

//------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n------------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("       Ordenação de Elementos         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------------");

OrdenacaoElementosService.OrdenarElementos();
OrdenacaoElementosService.FirstVsFirstOrDefault();
OrdenacaoElementosService.SingleVsSingleOrDefault();

//------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n-------------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("       AGREGAÇÕES COM LINQ         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("-------------------------------------");

AgregadoresService.CountAlunosTurma3A();
AgregadoresService.AverageNotasMatematica();
AgregadoresService.MaxMinNotasPortugues();
AgregadoresService.SumNotasMatematicaPortugues(1);

//------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("       JUNÇÕES (Join)         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------");
JuncoesService.JoinTurmaEAluno();
JuncoesService.JoinTriploRelatorio();

//------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n------------------------------");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("    AGRUPAMENTO (GroupBy)      ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------");
AgrupamentoService.GroupBySimples();
AgrupamentoService.GroupByMediaPorAluno();