using Tyuiu.SanzyapovOD.Sprint5.Task3.V11.Lib;
namespace Tyuiu.SanzyapovOD.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExsist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExsist);
        }
    }
}