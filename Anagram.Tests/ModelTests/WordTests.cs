using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;

namespace Anagram.Tests
{
  [TestClass]
  public class WordTests //: IDisposable
  {
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }

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

  }
}



//2 pathways:
//path 1 - single word:
//single word -> charArray
//charArray alpha sort

//path 2 - list of words:
//list of charArrays
//alpha sort each charArray

//compare each charArray in list to single word charArray
//if match, use index w/in list of charArrays to return anagram words
