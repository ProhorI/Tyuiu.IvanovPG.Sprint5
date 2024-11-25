

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanovPG.Sprint5.Task6.V10.Lib
{
    public class DataService : ISprint5Task6V10
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] charsToRemove = new string[5] { "?", ",", ".", ";", "'" };
                    foreach (var c in charsToRemove)
                    {
                        line = line.Replace(c, string.Empty);
                    }
                    string[] lineArray = line.Split(' ');
                    for (int i = 0; i < lineArray.Length; i++)
                    {
                        if (lineArray[i].Length == 4)
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