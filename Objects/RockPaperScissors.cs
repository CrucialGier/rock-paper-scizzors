using System;
using System.Collections.Generic;

namespace GameStuff
{
  public class Game
  {
    private string _play;
    private static List<string> _plays = new List<string> {};

    public Game(string play)
    {
      _play = play;
      _plays.Add(_play);
    }

    public string GetPlay()
    {
      return _play;
    }
    public void SetPlay(string newPlay)
    {
      _play = newPlay;
    }
    public static List<string> GetPlays()
    {
      return _plays;
    }
    public static void ClearAll()
    {
      _plays.Clear();
    }

    public static string RockPaperScissors()
    {
      //game logic
      var p1 = _plays[0];
      var p2 = _plays[1];

      if (p1 == p2)
      {
        return "draw";
      }
      else if(p1 == "r")
      {
        if(p2 == "p")
        {
          return "Player 2 has dominated! Paper smothers Rock...the paper is mighter than the...rock?";
        }
        else if(p2 == "s")
        {
          return "Player 1 has dominated! Rock smashes those puny scissors to a bloody pulp, muahahahahahaha";
        }
      }
      else if(p1 == "p")
      {
        if(p2 == "r")
        {
          return "Player 1 has dominated! Paper smothers Rock...the paper is mighter than the...rock?";
        }
        else if(p2 == "s")
        {
          return "Player 2 has dominated! Scissors cuts paper!";
        }
      }
      else if(p1 == "s")
      {
        if(p2 == "p")
        {
          return "Player 1 has dominated! Scissors cuts paper!";
        }
        else if(p2 == "r")
        {
          return "Player 2 has dominated! Rock smashes those puny scissors to a bloody pulp, muahahahahahaha";
        }
      }
      return "You must have entered something wrong, try again!";
    }

  }
}
