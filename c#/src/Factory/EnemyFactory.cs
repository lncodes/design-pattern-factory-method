namespace Lncodes.DesignPattern.FactoryMethod
{
    public abstract class EnemyFactory
    {
        /// <summary>
        /// Method to create the enemy
        /// </summary>
        /// <returns cref="Enemy"></returns>
        protected abstract Enemy Create();

        /// <summary>
        /// Method to spawn enemy
        /// </summary>
        /// <returns cref="Enemy"></returns>
        public Enemy Spawn()
        {
            var enemy = Create();
            enemy.Position = new Vector2(10, 10);
            return enemy;
        }
    }
}
