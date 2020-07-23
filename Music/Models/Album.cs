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
      Name = name;
      _albumList.Add(this);
      Id = _albumList.Count;
    }

    public static void ClearAll()
    {
      _albumList.Clear();
    }

    public static List<Album> GetAll()
    {
      return _albumList;
    }

    public static Album Find(int searchId)
    {
      Album albumOne = new Album("name1");
      return albumOne;
    }
  }
}
