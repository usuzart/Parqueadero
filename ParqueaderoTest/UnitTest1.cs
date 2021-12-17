using NUnit.Framework;
using Hoga.Tech.DependecyInjection;
using Moq;
using NUnit.Framework;
using Persona.Domain.Repositories;

namespace ParqueaderoTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            ContainerBuilder.StartIoC();
            ContainerBuilder.CleanCache();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}