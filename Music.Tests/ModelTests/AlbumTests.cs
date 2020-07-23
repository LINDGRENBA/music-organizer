using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {

    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album ourAlbum = new Album("Red");
      Assert.AreEqual(typeof(Album), ourAlbum.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Red";
      Album ourAlbum = new Album(name);
      string result = ourAlbum.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string name = "Red";
      Album ourAlbum = new Album(name);
      int result = ourAlbum.Id;
      Assert.AreEqual(1, result);
    }
  }
}