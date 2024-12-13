using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SyrtsovaSA.Sprint6.Task6.V2.Lib
{
    public class DataService : ISprint6Task6V2
    {
        public string CollectTextFromFile(string path)
        {
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line == "")
                        break;
                    string[] words = line.Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
                    str = str + " " + words[1];
                }
            }
            return str.Trim();
        }
    }
}
