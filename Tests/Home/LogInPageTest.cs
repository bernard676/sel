namespace Selenium.Tests.Home
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Browser.Init();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TearDown]
        public void TearDown()
        {
            Browser.Close();
        }
    }
}