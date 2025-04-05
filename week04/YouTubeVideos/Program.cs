namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("How to code in C#", "Bro Code", 3600);
            Video video2 = new Video("How to sing the national anthem", "Some guy", 300);
            Video video3 = new Video("How to come up with good video names", "VideoJames", 601);

            video1.AddComments("I can't believe they did this!", "John");
            video1.AddComments("I can't believe they did this!", "John");
            video1.AddComments("I can't believe they did this!", "John");

            video2.AddComments("Wow, that truly is poggers. Good anthem singing.", "Paul");
            video2.AddComments("Wow, that truly is poggers. Good anthem singing.", "Paul");
            video2.AddComments("Wow, that truly is poggers. Good anthem singing.", "Paul");

            video3.AddComments("I don't think I could come up with enough video names", "Matthew");
            video3.AddComments("I don't think I could come up with enough video names", "Matthew");
            video3.AddComments("I don't think I could come up with enough video names", "Matthew");

            Console.WriteLine(video1.GetVideoInformation());
            Console.WriteLine(video1.GetAllComments());

            Console.WriteLine(video2.GetVideoInformation());
            Console.WriteLine(video2.GetAllComments());

            Console.WriteLine(video3.GetVideoInformation());
            Console.WriteLine(video3.GetAllComments());
        }
    }
}