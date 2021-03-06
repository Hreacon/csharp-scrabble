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
      Save();
    }

    public string GetWord()
    {
      return _userWord;
    }
    public int LetterValue(char letter)
    {
      int score = 0;
      string stringLetter = letter.ToString();

      foreach(var values in scrabbleValues)
      {
        if(values.Key.Contains(stringLetter.ToUpper()))
        {
          score = values.Value;
        }
      }

      Console.WriteLine("for letter " + letter + " score is " + score);
      return score;
    }

    public int WordValue()
    {
      int score = 0;

      char[] wordArray = _userWord.ToCharArray();
      for (var i = 0; i < wordArray.Length; i++)
      {
        score += LetterValue(wordArray[i]);
      }
      return score;
    }

    private static Dictionary <string, int> _wordList = new Dictionary<string, int> {};

    public void Save()
    {
      //this method is supposed to add the user word and the score to a dictionary to display to the page using razor.
      if(!_wordList.ContainsKey(_userWord))
        _wordList.Add(_userWord, WordValue());
    }

    public static Dictionary<string, int> GetAll()
    {
      return _wordList;
    }

    public static void DeleteAll()
    {
      _wordList.Clear();
    }

  } // end class
} // end namespace
