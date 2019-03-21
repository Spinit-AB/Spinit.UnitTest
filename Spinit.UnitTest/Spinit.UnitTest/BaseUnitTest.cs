using NUnit.Framework;
using AutoFixture;

namespace Spinit.UnitTest
{
    [TestFixture]
    public class BaseUnitTest<TSut> where TSut : class
    {
        public UnitTestFixture Fixture { get; private set; }
        public TSut SUT => Fixture.Create<TSut>();

        [SetUp]
        protected void Setup()
        {
            Fixture = new UnitTestFixture();
        }
    }
}
