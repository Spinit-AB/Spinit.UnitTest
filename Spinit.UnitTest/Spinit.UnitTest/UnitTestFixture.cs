using AutoFixture;
using AutoFixture.AutoMoq;
using AutoFixture.Kernel;
using Moq;
using Spinit.UnitTest.Factories;

namespace Spinit.UnitTest
{
    public class UnitTestFixture : Fixture
    {
        public CollectionFactory CollectionFactory { get; set; } = CollectionFactory.Instance;

        public Mock<T> GetMock<T>()
            where T : class
        {
            var mock = this.Freeze<Mock<T>>();
            mock.Invocations.Clear();

            return mock;
        }

        public UnitTestFixture() : base(new Fixture().Engine, new MultipleRelay())
        {
            Customize(new AutoMoqCustomization());
        }
    }
}
