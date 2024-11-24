using Tyuiu.SanzyapovOD.Sprint5.Task2.V3.Lib;
namespace Tyuiu.SanzyapovOD.Sprint5.Task2.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);
        }
    }
}