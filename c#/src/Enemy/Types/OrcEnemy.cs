namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class OrcEnemy : Enemy
    {
        public override string Type { get; } = nameof(EnemyTypes.Orc);
    }
}