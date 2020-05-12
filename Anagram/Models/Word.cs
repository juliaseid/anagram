using System;

namespace Anagram.Models
{
  public class Word
  {
    public char[] GetArray { get; set; }
    public Word(string word)
    {
      GetArray = word.ToCharArray();
    }
  }
}