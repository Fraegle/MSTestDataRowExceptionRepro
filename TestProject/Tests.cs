using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        [DataRow("DataRow 1")]
        [DataRow("DataRow 2")]
        [DataRow("DataRow 3")]
        [DataRow("DataRow 4")]
        [DataRow("DataRow 5")]
        [DataRow("DataRow 6")]
        [DataRow("DataRow 7")]
        [DataRow("DataRow 8")]
        [DataRow("DataRow 9")]
        [DataRow("DataRow 10")]
        [DataRow("DataRow 11")]
        [DataRow("DataRow 13")]
        [DataRow("DataRow 14")]
        [DataRow("DataRow 15")]
        [DataRow("DataRow 16")]
        [DataRow("DataRow 17")]
        [DataRow("DataRow 18")]
        [DataRow("DataRow 19")]
        [DataRow("DataRow 20")]
        [DataRow("DataRow 21")]
        [DataRow("DataRow 22")]
        [DataRow("DataRow 23")]
        [DataRow("DataRow 24")]
        public void TestMultipleDataRows(string value)
        {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(value));
        }
    }
}
