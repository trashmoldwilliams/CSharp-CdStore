using Nancy;
using System.Collections.Generic;
using CDstore.objects;

namespace CDstore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ =>{
        List<CD> allCds = CD.GetAll();
        return View["index.cshtml", allCds];
      };
      Get["/cds/new"]=_=>{
        return View["cds_form.cshtml"];
      };
      Post["/addCD"]= _ => {
        var newCD = new CD(Request.Form["artist-name"], Request.Form["album-name"], Request.Form["price"]);
        List<CD> allCds = CD.GetAll();
        return View["index.cshtml", allCds];
      };
      Get["/cds/search"]= _ =>{
        return View["search_form.cshtml"];
      };
      Post["/cdsearch"]= _ => {
        string searchinput = Request.Form["match"];
        List<CD> returnCds = new List<CD>{};
        List<CD> allCds = CD.GetAll();
        foreach (CD album in allCds)
        {
          if (album.SearchArtist(searchinput))
          {
            returnCds.Add(album);
          }
        }
        return View["search_results.cshtml", returnCds];
      };
    }
  }
}
