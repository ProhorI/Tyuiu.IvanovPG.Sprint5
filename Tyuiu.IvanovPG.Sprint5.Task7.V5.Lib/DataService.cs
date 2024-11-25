
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.IvanovPG.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            string strLine = "";
            using (StreamReader R = new(path))
            {
                string L;
                while ((L = R.ReadLine()) != null)
                {
                    for (int i = 0; i < L.Length; i++)
                    {
                        if ((L[i] >= 'А' && L[i] <= 'я' || L[i] == '!' || L[i] == '.' || L[i] == ',') ^ (L[i] == ' '))
                        {
                            strLine = strLine + L[i];
                        }
                    }
                }
                return strLine.Trim('!');
            }
        }
    }
}
