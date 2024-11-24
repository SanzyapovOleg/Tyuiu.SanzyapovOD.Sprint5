using Tyuiu.SanzyapovOD.Sprint5.Task0.V12.Lib;
namespace Tyuiu.SanzyapovOD.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\olegs\source\repos\Tyuiu.SanzyapovOD.Sprint5\Tyuiu.SanzyapovOD.Sprint5.Task0.V12\bin\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool tyta = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, tyta);
        }
    }
}