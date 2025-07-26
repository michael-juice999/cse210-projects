using System.Collections.Generic;

class Video
{
    public string Title;
    public string Author;
    public string Length;

    // Constructor
    public Video(string title, string author, string length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();  // Initialize the comment list
    }

    // Store all comments for this video
    public List<Comment> Comments;

    // Add a comment to this video
    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        Comments.Add(newComment);
    }

    // Return number of comments
    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    // Optional: Display video info
    public string GetDisplayText()
    {
        return $"{Title} by {Author} ({Length})";
    }
}
