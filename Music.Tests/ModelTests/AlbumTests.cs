using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests
  {
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album ourAlbum = new Album("Red");
      Assert.AreEqual(typeof(Album), ourAlbum.GetType());
    }
  }
}