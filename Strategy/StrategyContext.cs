using Strategy.Strategies;

namespace Strategy
{
    public class StrategyContext
    {
        private IStrategy? _strategy;

        private static readonly Dictionary<StrategyType, Type> _strategies = new() {
            { StrategyType.Strategy1, typeof(Strategy1) },
            { StrategyType.Strategy2, typeof(Strategy2) },
            { StrategyType.Strategy3, typeof(Strategy3) },
        };

        public void SetStrategy(StrategyType strategy)
        {
            _strategy = _strategies.TryGetValue(strategy, out var strategyType) ? (IStrategy?)Activator.CreateInstance(strategyType) : null;
        }

        public string Excecute()
        {
            if(_strategy == default)
            {
                throw new InvalidOperationException("No strategy has been set");
            }

            return _strategy.Execute();
        }
    }
}
