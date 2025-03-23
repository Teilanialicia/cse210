using System.ComponentModel.DataAnnotations;

namespace W02
{
    class Entry
    {
        public DateOnly _date { get; set; }

        public string _prompt { get; set; }

        public string _response { get; set; }

        public Entry(DateOnly _date, string _prompt, string _response)
        { 
            this._date = _date;
            this._prompt = _prompt;
            this._response = _response;
        }

        public void Display()
        {
            Console.WriteLine($"Date: {_date} - Prompt: {_prompt}");
            Console.WriteLine($"{_response}\n");
        }
    }
}