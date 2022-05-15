using System.Text.Json;

namespace Spotiflix.Data
{
    public class HandleData
    {
        List<EntertainmentItem> data;
        string path;
        public HandleData()
        {
            path = "Data/content.json";
            readFromFile();
        }
        public void readFromFile()
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                Console.WriteLine(json);
            }
        }

        public void writeToFile(EntertainmentItem item)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                string json = JsonSerializer.Serialize(item);
                writer.WriteLine(json);
            }
        }
    }
}
