using Xunit;
using ScrabbleNS.Objects;
using System.Collections.Generic;

namespace ScrabbleNS
{
  public class ScrabbleTest
  {
    /*
      scrabble class
      constructed with the word to test
      holds the word and the score of the word
      has function for finding the value of a single letter


      Tests:
      test the function for single letters
      pass it one letter of each value

      Test the funciton for words
      pass it simple two character "words"
      get more complex words

    /**/
    [Fact]
    public void LetterValue_ForA_1()
    {
      Scrabble test = new Scrabble("a");
      Assert.Equal(1, test.LetterValue('a'));
      Assert.Equal(2, test.LetterValue('d'));
      Assert.Equal(3, test.LetterValue('b'));
      Assert.Equal(4, test.LetterValue('f'));
      Assert.Equal(5, test.LetterValue('k'));
      Assert.Equal(8, test.LetterValue('j'));
      Assert.Equal(10, test.LetterValue('q'));
      Scrabble.DeleteAll();
    }

    [Fact]
    public void WordValue_ForAsk_7()
    {
      Scrabble test = new Scrabble("ask");
      Assert.Equal(7, test.WordValue());
      Scrabble.DeleteAll();
    }

    [Fact]
    public void WordValue_ForLook_8()
    {
      Scrabble test = new Scrabble("look");
      Assert.Equal(8, test.WordValue());
      Scrabble.DeleteAll();
    }

    [Fact]
    public void Return_Result_Of_User_Entry()
    {
      Dictionary <string, int> test = new Dictionary <string, int> { {"look", 8} };
      Scrabble scrab = new Scrabble("look");
      Assert.Equal(test, Scrabble.GetAll());
      Scrabble.DeleteAll();
    }
    /* EXAMPLE
    // Have a queen object that knows what coordinants its at
    [Fact]
    public void QueenAttack_ForCoordinants_SeeCoordinants()
    {
      QueenAttack queen = new QueenAttack(8, 2);
      Assert.Equal(8, queen.GetX());
      Assert.Equal(2, queen.GetY());
    }
    /**/
  }
}
