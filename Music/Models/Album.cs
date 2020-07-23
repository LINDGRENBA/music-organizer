using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    public string Title { get; }
    public int Id { get; }
    private static List<Album> _albumList = new List<Album> {};

    public Album(string title)
    {
      Title = title;
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
      return _albumList[searchId - 1];
    }
  }
}
