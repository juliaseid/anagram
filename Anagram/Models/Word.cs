using System;
using System.Collections.Generic;

namespace Anagram.Models
{
  public class Word
  {
    public char[] GetArray { get; set; }

    private static List<string> _words = new List<string> { };
    private static List<char[]> _instances = new List<char[]> { };
    public Word(string word)
    {
      _words.Add(word);

      char[] TempArray = word.ToCharArray();
      Array.Sort(TempArray);
      GetArray = TempArray;

      _instances.Add(TempArray);
    }

    public static List<string> GetAllWords()
    {
      return _words;
    }

    public static List<char[]> GetAllArrays()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _words.Clear();
      _instances.Clear();
    }
  }
}