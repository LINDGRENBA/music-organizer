using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Artist
  {
    public string Name { get; }
    public int Id { get; }
    public List<Album> Albums { get; set; }
    private static List<Artist> _artistList = new List<Artist> {};

    public Artist(string name)
    {
      Name = name;
      _artistList.Add(this);
      Id = _artistList.Count;
      Albums = new List<Album> {};
    }

    public static void ClearAll()
    {
      _artistList.Clear();
    }

    public static List<Artist> GetAll()
    {
      return _artistList;
    }
    public static Artist Find(int searchId)
    {
      return _artistList[searchId - 1];
    }

  }
}