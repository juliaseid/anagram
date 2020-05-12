using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void WordConstructor_CreatesCharArray_CharArray()
    {
      //Arrange
      char[] breadArray = { 'a', 'b', 'd', 'e', 'r' };
      Word newWord2 = new Word("bread");
      //Act
      char[] newWord2Array = newWord2.GetArray;
      //Assert
      CollectionAssert.AreEqual(breadArray, newWord2Array);
    }

    [TestMethod]
    public void WordConstructor_SortsCharArray_CharArray()
    {
      char[] breadArray = { 'a', 'b', 'd', 'e', 'r' };
      Word newWord = new Word("bread");
      char[] newWordArraySorted = newWord.GetArray;
      CollectionAssert.AreEqual(breadArray, newWordArraySorted);
    }

    [TestMethod]
    public void WordConstructor_AddsMultipleWords_Strings()
    {
      string breadString = "bread";
      string beardString = "beard";
      Word newWord = new Word("bread");
      Word newWord2 = new Word("beard");
      List<string> tempList = Word.GetAllWords();

      string tempString = tempList[0];
      string temporaryString = tempList[1];
      Assert.AreEqual(breadString, tempString);
      Assert.AreEqual(beardString, temporaryString);
    }

    [TestMethod]
    public void WordConstructor_AddsMultipleWords_CharArrays()
    {
      char[] breadArray = { 'a', 'b', 'd', 'e', 'r' };
      char[] beardArray = { 'a', 'b', 'd', 'e', 'r' };
      Word newWord = new Word("bread");
      Word newWord2 = new Word("beard");
      List<char[]> tempArrayList = Word.GetAllArrays();
      char[] temp1 = tempArrayList[0];
      char[] temp2 = tempArrayList[1];
      CollectionAssert.AreEqual(breadArray, temp1);
      CollectionAssert.AreEqual(beardArray, temp2);
    }

    [TestMethod]
    public void WordConstuctor_ComparesCharArrayList_IntList()
    {
      Word newWord = new Word("bread");
      Word newWord2 = new Word("beard");
      Word newWord3 = new Word("bearq");
      List<int> confirmIntList = new List<int> { 1 };
      List<int> matchIntList = Word.CompareAllArrays();
      CollectionAssert.AreEqual(confirmIntList, matchIntList);
    }

    [TestMethod]
    public void WordConstructor_ReturnsAnagrams_StringList()
    {
      Word newWord = new Word("bread");
      Word newWord2 = new Word("beard");
      Word newWord3 = new Word("bearq");
      List<string> confirmStringList = new List<string> { "beard" };
      List<int> matchIntList = Word.CompareAllArrays();
      List<string> anagramMatch = Word.ReturnMatches(matchIntList);
      CollectionAssert.AreEqual(confirmStringList, anagramMatch);

    }

  }
}




