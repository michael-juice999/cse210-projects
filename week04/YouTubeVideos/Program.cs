using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Learning C#", "John Doe", "10:59");
        Video video2 = new Video("Advanced C#", "Jane Smith", "15:30");
        Video video3 = new Video("Projects for C#", "Bro Code", "5:30");
        Video video4 = new Video("Projects for Python and C#", "Bro Code", "10:23");

        // Add to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Add comments to video1
        video1.AddComment("Ama", "Very helpful!");
        video1.AddComment("Kwame", "Nice tutorial.");
        video1.AddComment("Yaa", "Thanks a lot!");

        // Add comments to video2
        video2.AddComment("Kojo", "Deep explanation!");
        video2.AddComment("Afia", "Too fast, but good.");
        video2.AddComment("Nana", "Saved my day.");

        // Add comments to video3
        video3.AddComment("Kwaku", "I'm learning a lot.");
        video3.AddComment("Serwaa", "Clear and simple.");
        video3.AddComment("Abena", "Well explained!");

        // Add comments to video4
        video4.AddComment("Mensah", "Useful for my project.");
        video4.AddComment("Akosua", "More of these please.");
        video4.AddComment("Yaw", "Awesome content!");

        // Display all video info
        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine($" - {comment.Name}: {comment.Text}");
            }

            Console.WriteLine(); // spacing between videos
        }
    }
}
