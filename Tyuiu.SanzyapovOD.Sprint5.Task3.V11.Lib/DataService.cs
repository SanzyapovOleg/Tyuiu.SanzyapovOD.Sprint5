﻿using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.SanzyapovOD.Sprint5.Task3.V11.Lib
{
    public class DataService : ISprint5Task3V11
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.GetTempFileName();
            double y = Math.Round((4 - Math.Pow(x, 3)) / (Math.Pow(x, 2)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path;
        }
    }
}
