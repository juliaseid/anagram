using Microsoft.AspNetCore.Mvc;
using Anagram.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index() 
    { 
      return View(); 
    }
    
    [Route("/anagramlist")]
    public ActionResult AnagramList(string baseWord, string compWord1, string compWord2, string compWord3, string compWord4, string compWord5)
    {
        Word ourWords = new Word();      
      Word.GetBaseWord(baseWord);
      Word.CompareWord(compWord1);
      Word.CompareWord(compWord2);
      Word.CompareWord(compWord3);
      Word.CompareWord(compWord4);
      Word.CompareWord(compWord5);
      Word.ReturnMatches(Word.CompareAllArrays());
      return View(ourWords);
    }
  }
}