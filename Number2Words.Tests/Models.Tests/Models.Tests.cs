using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Number2Words.Models;
using System;

namespace Number2Words.Models.Tests
{
  [TestClass]
  public class ModelsTest
  {
    [TestMethod]
    public void NumConvert_ConvertsSingleDigit_True()
    {
      int userNum = 8;
      WordBeNice word = new WordBeNice();
      Assert.AreEqual("eight", word.NumConvert);
    }
  }
}