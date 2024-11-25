
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanovPG.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V5.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i] >= 'а') && (line[i] <= 'я')) || ((line[i] >= 'А') && (line[i] <= 'Я')) || line[i] == ' ' || line[i] == '!' || line[i] == ',' || line[i] == '.')
                        {
                            strLine = strLine + line[i];
                        }
                    }

                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;
        }
    }
}
