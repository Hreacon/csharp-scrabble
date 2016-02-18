using Xunit;
using ScrabbleNS.Objects;
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
      Assert.Equals(1, test.LetterValue('a'));
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
