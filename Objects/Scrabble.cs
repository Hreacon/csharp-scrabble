using System.Collections.Generic;
using System;
namespace ScrabbleNS.Objects
{
  public class Scrabble
  {
    private string _userWord;
    private Dictionary <string, int> scrabbleValues;

    public Scrabble(string word)
    {
      _userWord = word;
      scrabbleValues = new Dictionary <string, int> {};
      scrabbleValues.Add("A, E, I, O, U, L, N, R, S, T", 1);
      scrabbleValues.Add("D, G ", 2);
      scrabbleValues.Add("B, C, M, P ", 3);
      scrabbleValues.Add("F, H, V, W, Y", 4);
      scrabbleValues.Add("K", 5);
      scrabbleValues.Add("JX", 8);
      scrabbleValues.Add("QZ", 10);
    }

    public int LetterValue(char letter)
    {
      return 0;
    }

  } // end class
} // end namespace
