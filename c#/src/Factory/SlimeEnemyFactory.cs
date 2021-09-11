namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class SlimeEnemyFactory : EnemyFactory
    {
        /// <inheritdoc cref="EnemyFactory.Create"/>
        protected override Enemy Create() =>
            new SlimeEnemy();
    }
}