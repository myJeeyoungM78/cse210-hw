

using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;

        this._comments = new List<Comment>();
    }


    public void AddComment(Comment comment)
    {
        this._comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void GetDisplayInfo()
    {
        System.Console.WriteLine(this._title + "-" + _author + $" ({_length})");
        System.Console.WriteLine("Comments:");
        foreach (Comment c in _comments)
        {
            System.Console.WriteLine(c.ToString());
        }
    }
}
