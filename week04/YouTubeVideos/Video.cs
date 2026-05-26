using System;
using System.Collections.Generic;
public class Video
{
    public string _title;
    public string _autor;
    public int _duration;

    public List<Comment> _comment = new List<Comment>();

    public int ReturnComent()
    {
        return _comment.Count();
    }
}