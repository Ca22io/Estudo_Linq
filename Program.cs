using App.Service;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("----------------------------------------------------");
Console.ResetColor();
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
Console.ResetColor();
Console.WriteLine("       Ordenação de Elementos         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------------");

OrdenacaoElementosService.OrdenarElementos();
OrdenacaoElementosService.FirstVsFirstOrDefault();
OrdenacaoElementosService.SingleVsSingleOrDefault();

//------------------------------------------------------------------------------------------------------------

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n------------------------------------");
Console.ResetColor();
Console.WriteLine("       AGREGAÇÕES COM LINQ         ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("------------------------------------");

AgregadoresService.CountAlunosTurma3A();
AgregadoresService.AverageNotasMatematica();
AgregadoresService.MaxMinNotasPortugues();
AgregadoresService.SumNotasMatematicaPortugues(1);