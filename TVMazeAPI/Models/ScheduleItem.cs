namespace TVMazeAPI.Models;

public class ScheduleItem
{
    public string Name
    {
        get;set;
    } = "";

    public int Season
    {
        get;set;
    }

    public int? Number
    {
        get;set;
    }

    public string Airtime
    {
        get;set;
    } = "";

    public Show Show
    {
        get;set;
    } = new();

}