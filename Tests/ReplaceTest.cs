using Xunit;
using FindAndReplace.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FindAndReplace
{
  public class ReplaceTest
  {
// checks that the sentence splits into individual strings
      [Fact]
      public void GetSentenceSplitArray_SplitSentenceIntoWords_Array()
      {
          //Arrange
          string sentence = "this sentence";
          string word = "this";
          string replace = "not";
          Replace newReplace = new Replace(sentence, word, replace);
          string[] sentenceSplitArray = new string[] {"this", "sentence"};
          //Act
          var result = newReplace.GetSentenceSplitArray();

          //Assert
          Assert.Equal(sentenceSplitArray, result);
      }
// checks that the input word matches word from sentence
      [Fact]
      public void CompareWords_ReturnAnyMatchingWords_List()
      {
          //Arrange
          string sentence = "this sentence is this";
          string word = "this";
          string replace = "not";
          Replace newReplace = new Replace(sentence, word, replace);
          List<string> matchingWords = new List<string> {"this", "this"};
          //Act
          List<string> result = newReplace.CompareWords();

          //Assert
          Assert.Equal(matchingWords, result);
      }

// checks that the input word is replaced with replacement word
      [Fact]
      public void ReplaceWord_ReturnReplacementWord_String()
      {
          //Arrange
          string sentence = "This sentence is this";
          string word = "this";
          string replace = "not";
          Replace newReplace = new Replace(sentence, word, replace);
          string replacement = "Not sentence is not ";
          //Act
          string result = newReplace.ReplaceWord();


          //Assert
          Assert.Equal(replacement, result);
      }

  }
}
