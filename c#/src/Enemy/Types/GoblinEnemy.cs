namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class GoblinEnemy : Enemy
    {
        public override string Type { get; } = nameof(EnemyTypes.Goblin);
    }
}