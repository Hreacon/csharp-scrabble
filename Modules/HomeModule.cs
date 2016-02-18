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
        return View["index.cshtml", Scrabble.GetAll()];
      };
      Post["/scrabble"]= _ =>
      {
        new Scrabble(Request.Form["userWord"]);

        return View["index.cshtml", Scrabble.GetAll()];
      };
      Get["/deleteAll"] = _ => {
        Scrabble.DeleteAll();
        return View["index.cshtml", Scrabble.GetAll()];
      };
    }
  }
}
