using ContosoWeb.Controllers;
using Xunit;

namespace ContosoWeb.Tests
{
    public class ProductsControllerTests
    {
        [Fact]
        public void Products_ReturnsExpectedText()
        {
            var controller = new ProductsController();

            Assert.Equal("Products", controller.Index());
        }

        [Fact]
        public void DetailsWithId_ReturnsExpectedText()
        {
            var controller = new ProductsController();

            Assert.Equal("Product Details: 7", controller.Details(7));
        }

        [Fact]
        public void Details_ReturnsExpectedText()
        {
            var controller = new ProductsController();

            Assert.Equal("Product Details", controller.Details());
        }

        [Fact]
        public void Count_ReturnsExpectedText()
        {
            var controller = new ProductsController();

            Assert.Equal("Product Count", controller.Count());
        }
    }
}