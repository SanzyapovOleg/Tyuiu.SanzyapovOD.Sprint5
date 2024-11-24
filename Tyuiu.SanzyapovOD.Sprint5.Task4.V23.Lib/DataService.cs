using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SanzyapovOD.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX.Replace(".", ","));
            double res = Math.Round(Math.Pow(x, -3) + 2 + Math.Cos(x), 3);
            return res;
        }
    }
}
