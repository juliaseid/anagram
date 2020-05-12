using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Program
{
  public class AnagramChecker
  {
    static void Main()
    {
      Console.Write("Enter a word for anagram assessment: ");
      string userInput = Console.ReadLine().ToLower();
      Word userWord = new Word(userInput);
      Console.Write("Enter another word to check if it is an anagram of " + userInput + ": ");
      string userInputCompare = Console.ReadLine().ToLower();
      Word userCompareWord = new Word(userInputCompare);
      Console.Write("Would you like to [A]dd or [C]ompare? ");
      string addOrCompare = Console.ReadLine().ToLower();

      while (addOrCompare == "a")
      {
        Console.Write("Enter another word to check if it is an anagram of " + userInput + ": ");
        string userInputCompareContinue = Console.ReadLine().ToLower();
        Word userCompareWordContinue = new Word(userInputCompareContinue);
        Console.Write("Would you like to [A]dd or [C]ompare? ");
        addOrCompare = Console.ReadLine().ToLower();
      }

      if (addOrCompare == "c")
      {
        List<int> intList = Word.CompareAllArrays();
        List<string> matches = Word.ReturnMatches(intList);
        Console.WriteLine("Here are your anagrams!");
        foreach (string match in matches)
        {
          Console.WriteLine(match);
        }
      }

    }
  }
}