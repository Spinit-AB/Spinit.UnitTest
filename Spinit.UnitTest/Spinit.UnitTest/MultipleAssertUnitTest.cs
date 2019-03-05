using System;
using AutoFixture;
using NUnit.Framework;

namespace Spinit.UnitTest
{
    [TestFixture]
    public abstract class MultipleAssertUnitTest<TSut, TParent> : MultipleAssertUnitTest<TSut>
        where TSut : class 
        where TParent : BaseUnitTest<TSut>
    {
        protected TParent Parent => Activator.CreateInstance<TParent>();
    }

    [TestFixture]
    public abstract class MultipleAssertUnitTest<TSut> : MultipleAssertTest where TSut : class
    {
        protected TSut SUT => Fixture.Create<TSut>();
    }

    [TestFixture]
    public abstract class MultipleAssertTest
    {
        public UnitTestFixture Fixture { get; private set; }

        public MultipleAssertTest()
        {
            Fixture = new UnitTestFixture();
        }

        protected abstract void Setup();
        protected abstract void Act();

        protected virtual void AssertPreparation()
        {

        }

        [OneTimeSetUp]
        public void Init()
        {
            Fixture.CollectionFactory.Flush();

            Setup();
            Act();
            AssertPreparation();
        }
    }
}
