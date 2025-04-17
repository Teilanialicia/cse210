using System.Text.Json;

namespace W02
{
    class Journal
    {

        // Your list of prompts must contain at least five different prompts 
        public List<Entry> _entries = [];

        // let you write in it
        public void Write()
        {
            string prompt = Prompt.GetRandomPrompt();
            Console.WriteLine(prompt);
            Console.Write("> ");
            string? response = Console.ReadLine();

            Entry entry = new Entry(DateOnly.FromDateTime(DateTime.Now), prompt, response);
            _entries.Add(entry);
        }


        // show the entries in the journal
        public void Display()
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        // Save the journal to a file
        public void Save()
        {
            Console.Write("Please enter a file name to save the journal to (do not include the extension): ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            string filepath = $"{Directory.GetCurrentDirectory()}\\{filename}.json";

            // this is my stretch work. I used a json serializer for the save function
            string serializedJson = System.Text.Json.JsonSerializer.Serialize(_entries, new JsonSerializerOptions(JsonSerializerDefaults.General));
            File.WriteAllText(filepath, serializedJson);
        }

        // Load the journal from a file
        public void Load()
        {
            Console.Write("Please enter a file name to load into the journal (do not include the extension): ");
            string filename = Console.ReadLine();
            Console.WriteLine();

            string filepath = $"{Directory.GetCurrentDirectory()}\\{filename}.json";

            if (!File.Exists(filepath))
            {
                Console.WriteLine("Please enter a valid file name (or one that exists)\n");
                return;
            }

            try
            {
                // this is also my stretch work. I used a json deserializer for the load function
                string serializedJson = File.ReadAllText(filepath);
                _entries = JsonSerializer.Deserialize<List<Entry>>(serializedJson, new JsonSerializerOptions(JsonSerializerDefaults.General));
            }
            catch(Exception e)
            {
                Console.WriteLine("Please try again with a valid serialized Entry Json file.\n");
                return;
            }
        }
    }
}