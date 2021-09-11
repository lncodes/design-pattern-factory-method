namespace Lncodes.DesignPattern.FactoryMethod
{
    public struct Vector2
    {
        public readonly int X;
        public readonly int Y;

        public Vector2(int x, int y) =>
            (X, Y) = (x, y);
    }
}