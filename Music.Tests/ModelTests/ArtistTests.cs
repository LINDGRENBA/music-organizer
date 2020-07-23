using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests 
{
  [TestClass]
  public class ArtistTest : IDisposable
  {
    public void Dispose()
    {
      Artist.ClearAll();
    }

    [TestMethod]
    public void ArtistConstructor_CreatesInstanceOfArtist_Artist()
    {
      Artist newArtist = new Artist("Taylor Swift");
      Assert.AreEqual(typeof(Artist), newArtist.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Taylor Swift";
      Artist newArtist = new Artist(name);

      string result = newArtist.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsArtistId_Int()
    {
      string name = "Taylor Swift";
      Artist newArtist = new Artist(name);
      int result = newArtist.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllArtistObjects_ArtistList()
    {
      string name1 = "Taylor Swift";
      string name2 = "Mountain Goats";
      Artist newArtist1 = new Artist(name1);
      Artist newArtist2 = new Artist(name2);
      List<Artist> newList = new List<Artist> {newArtist1, newArtist2};

      List<Artist> result = Artist.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectArtistObject_Artist()
    {
      string name1 = "Taylor Swift";
      string name2 = "Mountain Goats";
      Artist newArtist1 = new Artist(name1);
      Artist newArtist2 = new Artist(name2);
      Artist result = Artist.Find(2);
      Assert.AreEqual(newArtist1, result);
    }

  }
}