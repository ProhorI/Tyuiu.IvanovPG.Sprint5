

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.IvanovPG.Sprint5.Task1.V21.Lib
{
    public class DataService : ISprint5Task1V21
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x), 2);
                strY = Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);

                }
                else
                {
                    File.AppendAllText(path, strY);
                }

            }
            return path;
        }
    }
}
//(2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - Math.Sin(x)