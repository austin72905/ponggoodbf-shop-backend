using ponggoodbf_shop_backend.Services;
using NUnit.Framework;
using ponggoodbf_shop_backend.Models;
using System.Collections.Generic;

namespace ponggoodbf_shop_backend.UnitTests
{
    [TestFixture]
    public class ProductServiceTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("newArrival")]
        public void GetProducts_PassCategory_ReturnListOfProductInfomation(string category)
        {
            var returnCategory=new ProductService().GetProducts(category);
            Assert.That(returnCategory,Is.TypeOf<List<ProductInfomation>>());
        }

        [Test]
        [TestCase("1")]
        public void GetProductById_PassProductId_ReturnProductInfomation(string productId)
        {
            var product = new ProductService().GetProductById(productId);
            Assert.That(product, Is.TypeOf<ProductInfomation>());
        }
    }
}
