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
      ScrabbleScore test = new ScrabbleScore("A");
      Assert.Equal("Your score for A is 1", test.Score("A"));
      // Dictionary<string, int> testDictionary = test.Score("A");
      // Assert.Contains("A", testDictionary.Keys);
      // Assert.Contains(1, testDictionary.Values);
    }
    [Fact]
    public void Score_Word()
    {
      ScrabbleScore test = new ScrabbleScore("heddeqqzxllo");
        Assert.Equal("Your score for heddeqqzxllo is 51", test.Score("heddeqqzxllo"));
      // Dictionary<string, int> testDictionary = test.Score("heddeqqzxllo");
      // Console.WriteLine(testDictionary.Values);

      // Assert.Contains("heddeqqzxllo", testDictionary.Keys);
      // Assert.Contains(51, testDictionary.Values);
    }
    [Fact]
    public void Score_sentence()
    {
      ScrabbleScore test = new ScrabbleScore("Hi! how are you?");
      Assert.Equal("Your score for Hi! how are you? is 23", test.Score("Hi! how are you?"));
      // Dictionary<string, int> testDictionary = test.Score("Hi! how are you?");
      // Console.WriteLine(testDictionary.Values);
      // Assert.Contains("Hi! how are you?", testDictionary.Keys);
      // Assert.Contains(51, testDictionary.Values);
    }
  }
}
