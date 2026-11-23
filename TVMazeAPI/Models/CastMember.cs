namespace TVMazeAPI.Models;

public class CastMember
{
    public Person Person{get;set;} = new();

    public Character Character{get;set;} = new();
}