namespace week03
{
    class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                Word worde = new Word(word);
                _words.Add(worde);
            }
        }

        // a for loop is used here because we only want to do soemthing up until the number that is put in.
        public void HideRandomWords(int numberToHide)
        {
            for (int i = 0; i < numberToHide; i++)
            {
                Random random = new Random();
                _words[random.Next(_words.Count)].Hide();
            }
        }
    
        // a for each loop is used here because we want to do soemthing to each thing in the _words list
        public string GetDisplayText()
        {
            string displayText = "";
            foreach ( Word word in _words){
                if (word.IsHidden())
                    displayText = displayText + " _";
                else
                    displayText = displayText + " " + word.GetDisplayText();
            };
            displayText = _reference.GetDisplayText() + displayText;
            return displayText;
        }

        public bool IsCompletelyHidden()
        {
            foreach ( Word word in _words){
                if (!word.IsHidden())
                    return false;
            };
            return true;
        }

    }
}