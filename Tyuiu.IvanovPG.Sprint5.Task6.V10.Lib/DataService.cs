

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanovPG.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 3;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 2; i++)
                    {
                        if ((char.IsDigit(line[i])) && (char.IsDigit(line[i + 1])) && (char.IsDigit(line[i + 2])))
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
//if ((char.IsDigit(line[i])) && (char.IsDigit(line[i + 1])) && (char.IsDigit(line[i + 2])))