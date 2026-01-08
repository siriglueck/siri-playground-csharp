using System.Text.Json;

namespace ListeWebJsonMVC.Controllers
{
    public class JsonFileController<T>
    {
        private readonly string _filePath;

        public JsonFileController(string filePath)
        {
            _filePath = filePath;
        }

        public List<T> Load()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<T>>(json) ?? new();
        }

        public void Save(List<T> data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(_filePath, json);
        }
    }
}
