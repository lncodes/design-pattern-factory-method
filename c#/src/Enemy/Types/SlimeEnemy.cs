namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class SlimeEnemy : Enemy
    {
        public override string Type { get; } = nameof(EnemyTypes.Slime);
    }
}