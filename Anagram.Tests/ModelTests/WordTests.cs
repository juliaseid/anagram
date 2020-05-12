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
      char[] breadArray = { 'b', 'r', 'e', 'a', 'd' };
      Word newWord2 = new Word("bread");
      //Act
      char[] newWord2Array = newWord2.GetArray;
      //Assert
      CollectionAssert.AreEqual(breadArray, newWord2Array);
    }

  }
}
