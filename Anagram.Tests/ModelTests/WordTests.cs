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
      Word newWord = new Word();
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }


  }
}
