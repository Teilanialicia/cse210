namespace week04
{
    class Program
    {
        static void Main(string[] args)
        {
            Video video1 = new Video("How to code in C#", "Bro Code", 3600);
            Video video2 = new Video("How to sing the national anthem", "Some guy", 300);
            Video video3 = new Video("How to come up with good video names", "VideoJames", 601);

            video1.AddComments("This is absolutely mind-blowing!", "Sarah");
            video1.AddComments("I can't believe they pulled this off!", "David");
            video1.AddComments("This left me speechless!", "Emily");

            video2.AddComments("That anthem gave me chills! Incredible performance!", "Chris");
            video2.AddComments("This is legendary! Poggers indeed!", "Alex");
            video2.AddComments("Amazing vocals! Can't stop watching this!", "Jordan");

            video3.AddComments("Trying to think of more titles, but it's tough!", "Sophie");
            video3.AddComments("It's hard to come up with names that do this video justice.", "Daniel");
            video3.AddComments("Running out of ideas for titles, haha!", "Olivia");


            Console.WriteLine(video1.GetVideoInformation());
            Console.WriteLine(video1.GetAllComments());

            Console.WriteLine(video2.GetVideoInformation());
            Console.WriteLine(video2.GetAllComments());

            Console.WriteLine(video3.GetVideoInformation());
            Console.WriteLine(video3.GetAllComments());
        }
    }
}