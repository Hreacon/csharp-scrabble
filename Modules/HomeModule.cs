using Nancy;
using ScrabbleNS.Objects;
using System.Collections.Generic;
namespace ScrabbleNS
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["header.cshtml"];
      };
    }
  }
}
