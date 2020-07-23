using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Name { get; }
    public int Id { get; }
    private static List<Album> _albumList = new List<Album> {};

    public Album(string name)
    {
      Name = "";
      _albumList.Add(this);
      Id = _albumList.Count;
    }
  }
}