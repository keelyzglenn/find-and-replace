using Xunit;
using FindAndReplace.Objects;
using System;
using System.Collections.Generic;

namespace FindAndReplace
{
  public class ReplaceTest
  {
      [Fact]
      public void GetSentenceSplitArray_SplitSentenceIntoWords_Array()
      {
          //Arrange
          string sentence = "This sentence";
          string word = "This";
          Replace newReplace = new Replace(sentence, word);
          string[] sentenceSplitArray = new string[] {"This", "sentence"};
          //Act
          var result = newReplace.GetSentenceSplitArray();
        //   Console.WriteLine(result[0]);
        //   Console.WriteLine(sentenceSplitArray[0]);
          //Assert
          Assert.Equal(sentenceSplitArray, result);
      }

      [Fact]
      public void CompareWords_ReturnAnyMatchingWords_List()
      {
          //Arrange
          string sentence = "this sentence is this";
          string word = "this";
          Replace newReplace = new Replace(sentence, word);
          List<string> matchingWords = new List<string> {"this", "this"};
          //Act
          List<string> result = newReplace.CompareWords();
          Console.WriteLine(matchingWords[0]);
          Console.WriteLine(result[0]);
          //Assert
          Assert.Equal(matchingWords, result);
      }
  }
}
