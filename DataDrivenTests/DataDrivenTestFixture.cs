using NUnit.Framework;

namespace DataDrivenTests
{
    [TestFixture(10)]
    [TestFixture(42)]
    public class DataDrivenTestFixture
    {
        int _x;

        public DataDrivenTestFixture(int x)
        {
            _x = x;
        }

        [Test]
        public void TestArguments()
        {
            //Assert.Pass($"X is {_x}");
            if (_x.Equals(10))
                Assert.AreEqual(10, _x);
            if (_x==42)
                Assert.AreEqual(42, _x);
        }
    }
}
