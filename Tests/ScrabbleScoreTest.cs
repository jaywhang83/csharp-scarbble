using System;
using System.Collections.Generic;
using Xunit;

namespace ScrabbleScoreNS
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Score_SingleLetter()
    {
      ScrabbleScore test = new ScrabbleScore();
      Assert.Equal(1, test.Score("A"));
    }

  }
}
