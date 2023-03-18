using NUnit.Framework;
using ponggoodbf_shop_backend.Services;

namespace ponggoodbf_shop_backend.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            new ProductService();
            Assert.Pass();
        }
    }
}