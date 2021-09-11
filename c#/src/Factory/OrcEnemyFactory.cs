namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class OrcEnemyFactory : EnemyFactory
    {
        /// <inheritdoc cref="EnemyFactory.Create"/>
        protected override Enemy Create() =>
            new OrcEnemy();
    }
}