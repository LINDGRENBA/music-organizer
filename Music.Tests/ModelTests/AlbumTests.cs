using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System;
using System.Collections.Generic;

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
      string title = "Red";
      Album ourAlbum = new Album(title);
      string result = ourAlbum.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      string title = "Red";
      Album ourAlbum = new Album(title);
      int result = ourAlbum.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyAlbumList_AlbumList()
    {
    List<Album> newList = new List<Album> { };
    List<Album> result = Album.GetAll();
    CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectsAlbum_Album()
    {
      Album albumOne = new Album("title1");
      Album albumTwo = new Album("title2");
      Album result = Album.Find(2);
      Assert.AreEqual(albumTwo , result);
    }
      

  }
}