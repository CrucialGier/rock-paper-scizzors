using Nancy;
using GameStuff;
using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"]=_=> {
        Game.ClearAll();
        return View["index.cshtml"];
      };
      Get["/player1"]=_=>{
        return View["player1.cshtml"];
      };
      Post["/player2"]=_=>{
        Game testGame1 = new Game(
        Request.Form["player"]
        );
        return View["player2.cshtml"];
      };
      Post["/winner"]=_=>{
        Game testGame2 = new Game(
        Request.Form["player"]
        );
        var result = Game.RockPaperScissors();
        return View["result.cshtml", result];
      };
    }
  }
}
