using Xunit;

namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class FactoryMethodTheoryData : TheoryData<EnemyFactory, string>
    {
        public FactoryMethodTheoryData()
        {
            Add(new OrcEnemyFactory(), nameof(EnemyTypes.Orc));
            Add(new SlimeEnemyFactory(), nameof(EnemyTypes.Slime));
            Add(new GoblinEnemyFactory(), nameof(EnemyTypes.Goblin));
        }
    }
}
