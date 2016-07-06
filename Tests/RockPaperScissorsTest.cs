using Xunit;
using System.Collections.Generic;

namespace Game
{
  public class Gametest
  {
    [Fact]
    public void IsGame_forvartest_true()
    {
      Game testGame1 = new Game("r");
      Game testGame2 = new Game("p");
      var result = Game.RockPaperScissors();
      Assert.Equal("draw", result);
    }
  }
}
