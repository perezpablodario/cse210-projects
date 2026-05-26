using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Abstraction Can Make Your Code Worse";
        video1._autor = "CodeAesthetic";
        video1._duration = 313;

        Comment comment1 = new Comment();
        comment1._namePerson = "codersbringchange";
        comment1._comment = "What a great animation to show extracting the generalized code!";
        video1._comment.Add(comment1);

        Comment comment2 = new Comment();
        comment2._namePerson = "SpencerColaco";
        comment2._comment = "Gotta say, you couldn't have picked a better choice of music to put me in a state of flow. Didn't rewind the video once";
        video1._comment.Add(comment2);

        Comment comment3 = new Comment();
        comment3._namePerson = "ciberman";
        comment3._comment = "I REALLY love this way of showing code. Explaining what are you doing while showing a speed up video of the changes.";
        video1._comment.Add(comment3);

        videos.Add(video1);

        Video video2 = new Video();
        video2._title = "If Statements";
        video2._autor = "Malloc";
        video2._duration = 794;

        Comment comment4 = new Comment();
        comment4._namePerson = "OmegaFalcon";
        comment4._comment = "Took me a while to realize this was just a normal programming video on how if statements work";
        video2._comment.Add(comment4);

        Comment comment5 = new Comment();
        comment5._namePerson = "davidntumba2447";
        comment5._comment = "Anyway... no not anyway";
        video2._comment.Add(comment5);

        Comment comment6 = new Comment();
        comment6._namePerson = "ultron-debugs";
        comment6._comment = "I am really glad you are back.. its been like a year.... Pls keep making videos";
        video2._comment.Add(comment6);

        videos.Add(video2);

        Video video3 = new Video();
        video3._title = "15 conceptos de frontend que todo desarrollador senior domina";
        video3._autor = "theSeniorDev";
        video3._duration = 2142;

        Comment comment7 = new Comment();
        comment7._namePerson = "onecuriousmuggle";
        comment7._comment = "Probably the only Channel on youtube with quality frontend senior specifuc content. Thanks a lot for filling the gaps !";
        video3._comment.Add(comment7);

        Comment comment8 = new Comment();
        comment8._namePerson = "triscuit5103";
        comment8._comment = "I've been a Meta engineer for almost 10 years now, this is very good content.";
        video3._comment.Add(comment8);

        Comment comment9 = new Comment();
        comment9._namePerson = "ai_solve_studio";
        comment9._comment = "I love how you explain. I work as Senior frontend dev, have never seen dynamic imports in code ....";
        video3._comment.Add(comment9);

        videos.Add(video3);

        Console.WriteLine("----- YouTube report -----");
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._autor}");
            Console.WriteLine($"Length: {video._duration}");
            Console.WriteLine($"Number of comment: {video.ReturnComent()}");
            Console.WriteLine($"Comments:");

            foreach (Comment comment in video._comment)
            {
                Console.WriteLine($"{comment._namePerson} -- {comment._comment}");
            }

            Console.WriteLine("---------------------------------------------------------------------------");
        }
    }
}