namespace Lncodes.DesignPattern.FactoryMethod
{
    public abstract class Enemy
    {
        public abstract string Type { get; }

        public Vector2 Position { get; internal set; }
    }
}
