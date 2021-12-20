// See https://aka.ms/new-console-template for more information
using Strategy;

var strategyContext = new StrategyContext();

strategyContext.SetStrategy(StrategyType.Strategy1);
Console.WriteLine(strategyContext.Excecute());


strategyContext.SetStrategy(StrategyType.Strategy2);
Console.WriteLine(strategyContext.Excecute());


strategyContext.SetStrategy(StrategyType.Strategy3);
Console.WriteLine(strategyContext.Excecute());