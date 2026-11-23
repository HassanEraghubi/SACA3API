namespace TVMazeAPI.Models;

public class Episode
{
    public int ID{get;set;}

    public string Name{get;set;} = "";

    public int Season{get;set;}

    public int? Number{get;set;}

    public string AirDate{get;set;} = "";

    public int? Runtime{get;set;}

    public Rating? Rating{get;set;}

    public Image? Image{get;set;}
    

    public string? Summary{get;set;}
}