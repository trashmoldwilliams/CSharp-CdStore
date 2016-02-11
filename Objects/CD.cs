using System.Collections.Generic;

namespace CD.objects
{
  public class CD
  {
    private string _artist;
    private string _albumTitle;
    private int _price;
    private int _id;
    private static List<CD> _instances = new List<CD> {};

    public CD (string artist, string albumTitle, int price = 10)
    {
      _artist = artist;
      _albumTitle = albumTitle;
      _price = price;
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetArtist()
    {
      return _artist;
    }

    public void SetArtist(string newArtist)
    {
      _artist = newArtist;
    }

    public string GetAlbumTitle()
    {
      return _albumTitle;
    }

    public void SetAlbumTitle(string newAlbumTitle)
    {
      _albumTitle = newAlbumTitle;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetId()
    {
      return _id;
    }

    public static CD Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}
