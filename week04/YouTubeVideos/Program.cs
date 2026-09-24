using System;
using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");
        Random random = new Random();

        List<Video> videos = new List<Video>
        {
            new Video("C# introduction", "Maggie McCausland", 1780),
            new Video("JavaScript introduction", "Jessica Nearing", 920),
            new Video("Python introduction", "Rodger Smith", 1874)
        };

        List <Comment> randomComments = new List<Comment>
        {
            new Comment("Luke", "Thank you for your video explanation!"),
            new Comment("Michael", "This answered a lot of my questions. Thank you."),
            new Comment("Jess", "Thank you!!!"),
            new Comment("Nicole", "I feel like I finally understand!"),
            new Comment("Jordan", "Awesome!"),
            new Comment("Victor", "This helped so much!"),
            new Comment("David", "Great video!"),
            new Comment("Sarah", "Wonderful tutorial."),
            new Comment("Johnson", "Great explanations!"),
            new Comment("Cody", "Finally makes sense!"),
            new Comment("Weston", "Can't wait to see your next video."),
            new Comment("Quinn", "Love it. Subscribed!")
        };

        foreach (Video video in videos)
        {
            var getRandomComments = randomComments.OrderBy(comment => random.Next()).Take(3).ToList();
            
            foreach (var comment in getRandomComments)
            {
                video.AddComment(comment);
            }
        }

        foreach(Video video in videos)
        {
            video.VideoInfo();
            Console.WriteLine();
        }
    }
}