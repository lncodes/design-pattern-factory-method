namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class GoblinEnemyFactory : EnemyFactory
    {
        /// <inheritdoc cref="EnemyFactory.Create"/>
        protected override Enemy Create() =>
            new GoblinEnemy();
    }
}