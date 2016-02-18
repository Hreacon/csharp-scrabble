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
        return View["index.cshtml"];
      };
      Post["/scrabble"]= _ =>
      {
        Scrabble newGame = new Scrabble(Request.Form["userWord"]);
        return View["scrabble.cshtml", newGame];
      };
    }
  }
}
