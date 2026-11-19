namespace TVMazeAPI.Models;

public class SearchResult
{

    public decimal Score
    {
        get;set;
    }
    public Show Show
    {
        get;set;
    } = new();

}