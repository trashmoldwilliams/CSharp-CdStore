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

    }
  }
}
