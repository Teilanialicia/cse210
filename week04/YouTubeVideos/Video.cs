namespace week04
{
    class Video
    {
        private string _title;
        private string _author;
        private int _lengthSeconds;
        private List<Comment> _comments;

        public Video(string title, string author, int lengthSeconds)
        {
            _title = title;
            _author = author;
            _lengthSeconds = lengthSeconds;
            _comments = [];
        }

        public string GetTitle()
        {
            return _title;
        }

        public string GetAuthor()
        {
            return _author;
        }

        public int GetLengthSeconds()
        {
            return _lengthSeconds;
        }

        public List<Comment> GetComments()
        {
            return _comments;
        }

        public void SetTitle(string title)
        {
            _title = title;
        }

        public void SetAuthor(string author)
        {
            _author = author;
        }

        public void SetLengthSeconds(int lengthSeconds)
        {
            _lengthSeconds = lengthSeconds;
        }

        public void AddComments(string text, string name)
        {
            Comment comment = new Comment(name, text);
            _comments.Add(comment);
        }

        public string GetAllComments()
        {
            string allCommentsText = "";

            foreach (Comment comment in _comments)
            {
                allCommentsText = allCommentsText + comment.GetCommentText();
            }
            return allCommentsText;
        }

        public string GetVideoInformation()
        {
            return $"{_title} by {_author} - {_lengthSeconds} seconds long";
        }
    }
}