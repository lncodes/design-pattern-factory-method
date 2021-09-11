using Xunit;

namespace Lncodes.DesignPattern.FactoryMethod
{
    public sealed class FactoryMethodTest
    {
        [Theory]
        [ClassData(typeof(FactoryMethodTheoryData))]
        public void Enemy_Type_ShouldEqual(EnemyFactory factory, string expected)
        {
            var enemy = factory.Spawn();

            var actual = enemy.Type;

            Assert.Equal(expected, actual);
        }
    }
}
