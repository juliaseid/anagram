using System;

namespace Anagram.Models
{
  public class Word
  {
    public char[] GetArray { get; set; }
    public Word(string word)
    {
      char[] TempArray = word.ToCharArray();
      Array.Sort(TempArray);
      GetArray = TempArray;
    }
  }
}