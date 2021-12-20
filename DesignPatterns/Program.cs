// See https://aka.ms/new-console-template for more information
using Strategy;

var strategyContext = new StrategyContext();

var strategies = new int[]{0, 1, 2, 3};

foreach(var strategy in strategies)
{
    strategyContext.SetStrategy((StrategyType) strategy);

    try
    {
        Console.WriteLine(strategyContext.Excecute());
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}