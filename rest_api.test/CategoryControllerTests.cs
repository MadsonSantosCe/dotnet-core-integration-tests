using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rest_api;
using System.Net;
using System.Threading.Tasks;

namespace api_rest.Test
{

    [TestClass]
    public class CategoryControllerTests
    {
        private static WebApplicationFactory<Startup> _factory;

        [ClassInitialize]
        public static void ClassInit(TestContext testContext)
        {
            _factory = new WebApplicationFactory<Startup>();
        }

        [TestMethod]
        public async Task Test()
        {
            var client = _factory.CreateClient();
            var response = await client.GetAsync("api/category");

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _factory.Dispose();
        }
    }
}

