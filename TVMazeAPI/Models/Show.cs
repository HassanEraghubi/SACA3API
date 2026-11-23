namespace TVMazeAPI.Models;

public class Show
{
    public int ID
    {
        get;set;
    }

    public string Name
    {
        get;set;
    } = "";

    public List<string> Genres
    {
        get;set;
    } = new();

    public DateOnly? Premiered
    {
        get;set;
    }

    public string? Summary
    {
        get;set;
    }

    public Rating? Rating
    {
        get;set;
    }
    
    public Image? Image
    {
        get;set;
    }


}

