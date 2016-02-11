using Nancy;
using System.Collections.Generic;
using CD.objects;

namespace CdStore
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]= _ =>{
        return View["index.cshtml"];
      };
    }
  }
}
