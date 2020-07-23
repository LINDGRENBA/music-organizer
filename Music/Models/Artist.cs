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
      Id = 0; 
      //_artistList.Count;
      Albums = new List<Album> {};
    }
  }
}