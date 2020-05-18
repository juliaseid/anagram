using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Models
{
  public class Word
  {

    private static List<string> _words = new List<string> { };
    private static List<char[]> _instances = new List<char[]> { };
    public static List<string> anagramMatches = new List<string> { };
    public static string BaseWord {get;set;}

    public static string GetBaseWord(string word)
    {
      BaseWord = word;
      return BaseWord;
    }

    public static List<char[]> CompareWord(string word)
    {
      _words.Add(word);
      char[] TempArray = word.ToCharArray();
      Array.Sort(TempArray);
      _instances.Add(TempArray);
      return _instances;
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

    public static List<int> CompareAllArrays()
    {
      List<char[]> arrayList = GetAllArrays();
      List<int> intList = new List<int> { };
      bool isSame = true;

      for (int i = 1; i < arrayList.Count; i++)
      {
        for (int j = 0; j < arrayList[i].Length; j++)
        {
          int originalLength = arrayList[0].Length;
          char[] markOffArray = new char[originalLength];
          arrayList[0].CopyTo(markOffArray, 0);
          if (markOffArray.Contains(arrayList[i][j]))
          {
            int markOffIndex = Array.IndexOf(arrayList[0], arrayList[i][j]);
            markOffArray[markOffIndex] = '#';
          }
          else
          {
            isSame = false;
          }
        }
        if (isSame)
        {
          intList.Add(i);
        }
      }
      return intList;
    }


    public static List<string> ReturnMatches(List<int> intList)
    {
      List<string> allWords = GetAllWords();
      List<int> intList2 = Word.CompareAllArrays();
      foreach (int index in intList2)
      {
        anagramMatches.Add(allWords[index]);
      }
      return anagramMatches;
    }

    // public static string MatchesAsString(List<string> matches)
    // {
    //   string matchString = String.Join(String.Empty, matches.ToArray());
    //   return matchString;
    // }


  }
}